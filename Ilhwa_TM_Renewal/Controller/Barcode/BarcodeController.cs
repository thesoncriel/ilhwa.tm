/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-13
 * Time: 오전 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Dialog;
using Theson.Common;
using Theson.Util.Config;

namespace Artn.Ilhwa.Controller.Barcode
{
	/// <summary>
	/// Description of BarcodeController.
	/// </summary>
	public class BarcodeController: AbsViewController
	{
		private IConfigTable _printHistory = new IniConfigTable(@"Config\print_history.ini");
		public IConfigTable PrintHistory{
			get{ return _printHistory; }
		}
		
		public BarcodeController()
		{
		}
		
		protected void ResultRegist(DialogResult dialRet, IMultiColumnRecordable viewData, IMultiColumnRecordable barcodeData){
			
		}
		
		
		
		public bool Print(IMultiColumnRecordable matData, string quantity, string bunchCount){
			BarcodePrinter printer = new TemplateBarcodePrinter(ViewBinder.DBManager.Config);
			IMultiColumnRecordable barcodeData = CreateModel(matData);
			IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
			DialogResult dialRet = DialogResult.None;
			
			int iBunch = 0;
			bool bRet = false;
			bool isRemain = (matData.ContainsKey("IsRemain") == true) && (matData["IsRemain"] == "true");
			
			barcodeData["ProductCode"] = _printHistory["History", viewData["OrderNo"]];
			
			try{
				printer.Open();

				FormBarcodePrinter frm = new FormBarcodePrinter();
				FormProgressBar prog = new FormProgressBar();
				frm.ViewCtrl = ViewBinder;
				SwapDataByProcCode(barcodeData);
				barcodeData["Quantity"] = quantity;
				barcodeData["BunchCount"] = bunchCount;
				
				if ((barcodeData.ContainsKey("IsRemain") == true) &&
				    barcodeData["ProcessCode"].EndsWith("E") == true){
					barcodeData["Customer"] = "일화스텐레스(주)";
					barcodeData["CustomerCode"] = "0036600001";
				}
				//barcodeData["_OrderedProduct"] = "1";// 주문인 작업지시를 통한 바코드 출력 시 수량의 개수/전체 개수의 곱이 0이면 출력 안되게 조치 - 2013.05.14 by jhson
				frm.ViewData = barcodeData;
				
				dialRet = frm.ShowDialog();
				if(dialRet != DialogResult.Cancel){
					barcodeData = frm.ViewData;

					if (dialRet == DialogResult.Yes){
						if (barcodeData["ProductCode"].Length < 22){
							MsgBox.Show("오류", "현재 프로그램 가동 중, 바코드를 출력한 이력이 없습니다.\r\n기타 입고 내역 기록 시 화면 하단의 외주 입고를 이용하여 주십시요.");
							return false;
						}
					}
					
					barcodeData.Parent.Parent["Barcode"] = barcodeData["ProductCode"]; // 퍋 -_-
					
					iBunch = Int32.Parse(barcodeData["BunchCount"]);
					prog.Title = "바코드 출력 중...";
					prog.TopMost = true;
					prog.Show();
					for(int i = 0; i < iBunch; i++){
						prog.Content = "진행 : " + i + " / " + iBunch;
						prog.Progress = (int)((i / iBunch) * 100);
						
						barcodeData = InsertDataAndSetBarcode(dialRet, barcodeData, isRemain);
						if(barcodeData["ProcessCode"] == "1E"){
							printer.Print_1stProc(barcodeData);
						}
						else{
							printer.Print_PlanProduct(barcodeData);
						}
						System.Threading.Thread.Sleep(4000);
					}
					frm.MemberClear();
					prog.Close();
					bRet = (dialRet == DialogResult.OK);
				}
			}
			catch(IOException){
				MsgBox.Show("오류", "바코드 프린터를 연결할 수 없습니다.\r\n직렬 통신, 또는 프린터의 연결 상태를 확인하여 주십시요.");
			}
			finally{
				barcodeData.MemberClear();
				printer.MemberClear();
			}
			return bRet;
		}
		
		public bool PrintRemaining(IMultiColumnRecordable matData, string quantity, string bunchCount){
			BarcodePrinter printer = new TemplateBarcodePrinter(ViewBinder.DBManager.Config);
			IMultiColumnRecordable barcodeData = CreateModel(matData);
			IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
			DialogResult dialRet = DialogResult.None;
			int iBunch = 0;
			bool bRet = false;
			
			try{
				printer.Open();

				FormBarcodePrinter frm = new FormBarcodePrinter();
				FormProgressBar prog = new FormProgressBar();
				frm.ViewCtrl = ViewBinder;
				//SwapDataByProcCode(barcodeData);
				barcodeData["Quantity"] = quantity;
				barcodeData["BunchCount"] = bunchCount;
				
				if ((barcodeData.ContainsKey("IsRemain") == true) &&
				    barcodeData["IsFirstProc"] == "true"){
					matData["Customer"] = "일화스텐레스(주)";
					matData["CustomerCode"] = "0036600001";
				}
				frm.ViewData = barcodeData;
				
				dialRet = frm.ShowDialog();
				if(dialRet != DialogResult.Cancel){
					barcodeData = frm.ViewData;

					iBunch = Int32.Parse(barcodeData["BunchCount"]);
					prog.Title = "바코드 출력 중...";
					prog.TopMost = true;
					prog.Show();
					for(int i = 0; i < iBunch; i++){
						prog.Content = "진행 : " + i + " / " + iBunch;
						prog.Progress = (int)((i / iBunch) * 100);
						
						printer.Print_RemainProduct(barcodeData);
						System.Threading.Thread.Sleep(4000);
					}
					prog.Close();
					bRet = (dialRet == DialogResult.OK);
				}
				frm.MemberClear();
			}
			catch(IOException){
				MsgBox.Show("오류", "바코드 프린터를 연결할 수 없습니다.\r\n직렬 통신, 또는 프린터의 연결 상태를 확인하여 주십시요.");
			}
			finally{
				barcodeData.MemberClear();
				printer.MemberClear();
			}
			return bRet;
		}
		
		public void PrintOther(){
			int iBunch = 0;
			FormBarcodePrinter frm = null;
			FormProgressBar prog = null;
			IMultiColumnRecordable barcodeData = null;
			BarcodePrinter printer = new TemplateBarcodePrinter(ViewBinder.DBManager.Config);
			DialogResult dialRet = DialogResult.None;
			
			try{
				printer.Open();
				
				barcodeData = new BarcodeInfo();
				frm = new FormBarcodePrinter();
				frm.EtcMode = true;
				prog = new FormProgressBar();
				frm.ViewCtrl = ViewBinder;
				
				barcodeData["IsOtherProd"] = "true";
				barcodeData["PlanQuantity"] = "0";
				frm.ViewData = barcodeData;
				dialRet = frm.ShowDialog();
				if(dialRet == DialogResult.OK || dialRet == DialogResult.Ignore){
					barcodeData = frm.ViewData;
					barcodeData["DeliveryDate"] = DateTime.Now.ToString();
					iBunch = Int32.Parse(barcodeData["BunchCount"]);
					prog.Title = "바코드 출력 중...";
					prog.TopMost = true;
					prog.Show();
					for(int i = 0; i < iBunch; i++){
						prog.Content = "진행 : " + i + " / " + iBunch;
						prog.Progress = (int)((i / iBunch) * 100);
						
						barcodeData = InsertDataAndSetBarcode_Other(dialRet, barcodeData);
						printer.Print_Etc(barcodeData);
						System.Threading.Thread.Sleep(4000);
					}
					OnLogMessage(this, "바코드 출력을 완료 하였습니다.");
				}
				
				barcodeData.MemberClear();
				frm.MemberClear();
				prog.Close();
			}
			catch(IOException){
				MsgBox.Show("오류", "바코드 프린터를 연결할 수 없습니다.\r\n직렬 통신, 또는 프린터의 연결 상태를 확인하여 주십시요.");
			}
			finally{
				printer.MemberClear();
			}
		}
		
		public void PrintRepublish(List<IMultiColumnRecordable> data){
			FormProgressBar prog = new FormProgressBar();
			BarcodePrinter printer = new TemplateBarcodePrinter(ViewBinder.DBManager.Config);
			string sDate = DateTime.Now.ToString();
			
			try{
				printer.Open();
			}catch(IOException){
				MsgBox.Show("오류", "바코드 프린터를 연결할 수 없습니다.\r\n직렬 통신, 또는 프린터의 연결 상태를 확인하여 주십시요.");
				return;
			}
			prog.Title = "바코드 출력 중...";
			prog.TopMost = true;
			prog.Show();
			
			foreach(IMultiColumnRecordable barcodeData in data){
				barcodeData["DeliveryDate"] = sDate;
				barcodeData["PlanLength"] = barcodeData["Length"];
				printer.Print_Etc(barcodeData);
				System.Threading.Thread.Sleep(4000);
			}
			prog.Close();
			OnLogMessage(this, "바코드 출력을 완료 하였습니다.");
		}
		
		protected IMultiColumnRecordable InsertDataAndSetBarcode(DialogResult dialRet, IMultiColumnRecordable barcodeData, bool isRemain){
			IMultiColumnRecordable matData = barcodeData.Parent as IMultiColumnRecordable;
			IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
			string sProdEnterQuery = "";
			
			if (dialRet == DialogResult.OK){
				if (isRemain == true){
					sProdEnterQuery = "procedure_insert TM_BC_INSERT_Prod_Enter_Remain";
				}
				else{
					sProdEnterQuery = "procedure_insert TM_BC_INSERT_Prod_Enter";
				}
				
				if(barcodeData["ProcessCode"] == "1E"){
					ViewBinder.DBManager.ExecuteNonQuery(
						"procedure_insert TM_BC_INSERT_Prod_Enter_TEMP1", barcodeData);
				}
				else{
					
					ViewBinder.DBManager.ExecuteNonQuery(
						"procedure_insert TM_BC_INSERT_Prod_Enter_TEMP2", barcodeData);
					
					if(viewData["IsChainProc"] == "false"){
						barcodeData["MaterialCode"] = ""; // 2차 공정 바로 시작 시엔 스켈프 정보가 부족 하므로 빈 스트링 설정
						barcodeData["MaterialNo"] = "";
					}
				}
				barcodeData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1").Replace(' ', '0');
				ViewBinder.DBManager.ExecuteNonQuery(sProdEnterQuery, barcodeData);
				
				barcodeData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1").Replace(' ', '0');
				
				if (matData.ContainsKey("IsRemain") == false) _printHistory["History", viewData["OrderNo"]] = barcodeData["ProductCode"];// 제품 등록 후 잉여 잔량 처리시엔 해당 작업지시에 대한 바코드를 히스토리에 등록하지 않는다.
//				}
			}
			
			return barcodeData;
		}
		
		protected IMultiColumnRecordable InsertDataAndSetBarcode_Other(DialogResult dialRet, IMultiColumnRecordable barcodeData){
			if (dialRet == DialogResult.Ignore){
				Badness badData = new Badness(barcodeData);
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_BC_INSERT_Prod_Enter_TEMP", badData);
				// 저장 프로시저로 불량쪽 바코드를 새로 받아내어 처리한다.
				barcodeData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1");
				barcodeData["ProdName"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut2");
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_P1_INSERT_BADNESS", badData);
			}
			else{
			
				ViewBinder.DBManager.ExecuteNonQuery(
						"procedure_insert TM_BC_INSERT_Etc_Prod_Enter", barcodeData);
				barcodeData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1");
				barcodeData["ProdName"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut2");
			}
			
			return barcodeData;
		}
		
		public IMultiColumnRecordable SwapDataByProcCode(IMultiColumnRecordable viewData){
			int index = 1;
			string[] saField ={
				"ProdCode",
				"Quality",
				"ODName",
				"OuterDiameter",
				"OrderLength",
				"Thickness",
				"ProdName"
			};
			if (viewData["ProcessCode"] == "2E"){
				index = 2;
			}
			foreach(string key in saField){
				viewData[key] = viewData[key + index];
			}
			return viewData;
		}
		
		public override Theson.Common.IMultiColumnRecordable CreateModel(System.Data.DataRow row)
		{
			return new BarcodeInfo(ViewBinder.DBManager.MatchTable, row);
		}
		public IMultiColumnRecordable CreateModel(IMultiColumnRecordable matData){
			return new BarcodeInfo(matData);
		}
		
		public List<IMultiColumnRecordable> FindBarcodeList(IMultiColumnRecordable critData){
			return CreateModelList(
				ViewBinder.DBManager.ExecuteQuery("table_select find_prod_barcode", critData));
		}
	}
}
