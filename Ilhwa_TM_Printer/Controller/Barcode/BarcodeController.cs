/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-13
 * Time: 오전 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
			BarcodePrinter printer = new BarcodePrinter(ViewBinder.DBManager.Config);
			IMultiColumnRecordable barcodeData = CreateModel(matData);
			IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
			DialogResult dialRet = DialogResult.None;
			
			int iBunch = 0;
			bool bRet = false;
			
			barcodeData["ProductCode"] = _printHistory["History", viewData["OrderNo"]];
			
			try{
				printer.Open();

				FormBarcodePrinter frm = new FormBarcodePrinter();
				FormProgressBar prog = new FormProgressBar();
				frm.ViewCtrl = ViewBinder;
				SwapDataByProcCode(barcodeData);
				barcodeData["Quantity"] = quantity;
				barcodeData["BunchCount"] = bunchCount;
				frm.ViewData = barcodeData;
				
				dialRet = frm.ShowDialog();
				if(dialRet != DialogResult.Cancel){
					barcodeData = frm.ViewData;
					
					
				
					if (dialRet == DialogResult.OK){
						if (Int32.Parse(viewData["PlanQuantity"]) < Int32.Parse(barcodeData["TotalQuantity"])){
							MsgBox.Show("오류", "작업 지시서의 계획 수량보다 바코드의 실적 등록 수량이 더 많습니다.");
							return false;
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
						ViewBinder.DBManager.ExecuteNonQuery(
								"procedure_insert TM_BC_INSERT_Prod_Enter", barcodeData);
						
						barcodeData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1").Replace(' ', '0');
						_printHistory["History", viewData["OrderNo"]] = barcodeData["ProductCode"];
						
					}
					else if (dialRet == DialogResult.Yes){
						if (barcodeData["ProductCode"].Length < 22){
							MsgBox.Show("오류", "현재 프로그램 가동 중, 바코드를 출력한 이력이 없습니다.\r\n기타 입고 내역 기록 시 화면 하단의 외주 입고를 이용하여 주십시요.");
							return false;
						}
					}
					
					iBunch = Int32.Parse(barcodeData["BunchCount"]);
					prog.Title = "바코드 출력 중...";
					prog.TopMost = true;
					prog.Show();
					for(int i = 0; i < iBunch; i++){
						prog.Content = "진행 : " + i + " / " + iBunch;
						prog.Progress = (int)((i / iBunch) * 100);
						if(barcodeData["ProcessCode"] == "1E"){
							printer.Print_1stProc(barcodeData);
						}
						else{
							printer.Print_2ndProc(barcodeData);
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
			BarcodePrinter printer = new BarcodePrinter(ViewBinder.DBManager.Config);
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
				SwapDataByProcCode(barcodeData);
				barcodeData["Quantity"] = quantity;
				barcodeData["BunchCount"] = bunchCount;
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
						if(barcodeData["ProcessCode"] == "1E"){
							printer.Print_1stProc(barcodeData);
						}
						else{
							printer.Print_2ndProc(barcodeData);
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
		
		public void PrintOther(){
			int iBunch = 0;
			FormBarcodePrinter frm = null;
			FormProgressBar prog = null;
			IMultiColumnRecordable barcodeData = null;
			BarcodePrinter printer = new BarcodePrinter(ViewBinder.DBManager.Config);
			
			try{
				printer.Open();
				
				barcodeData = new BarcodeInfo();
				frm = new FormBarcodePrinter();
				prog = new FormProgressBar();
				frm.ViewCtrl = ViewBinder;

				frm.ViewData = barcodeData;
				if(frm.ShowDialog() == DialogResult.OK){
					barcodeData = frm.ViewData;
					ViewBinder.DBManager.ExecuteNonQuery(
							"procedure_insert TM_BC_INSERT_Etc_Prod_Enter", barcodeData);
					barcodeData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1");
					barcodeData["ProdName"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut2");
					barcodeData["DeliveryDate"] = DateTime.Now.ToString();
					iBunch = Int32.Parse(barcodeData["BunchCount"]);
					prog.Title = "바코드 출력 중...";
					prog.TopMost = true;
					prog.Show();
					for(int i = 0; i < iBunch; i++){
						prog.Content = "진행 : " + i + " / " + iBunch;
						prog.Progress = (int)((i / iBunch) * 100);
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
			return null;
		}
		public IMultiColumnRecordable CreateModel(IMultiColumnRecordable matData){
			return new BarcodeInfo(matData);
		}
	}
}
