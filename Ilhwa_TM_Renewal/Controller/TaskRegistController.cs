/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-02
 * Time: 오후 8:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
using Artn.Ilhwa.View.TasRegistPart;
using Theson.Common;
using Theson.Util;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of TaskRegistProcessor.
	/// </summary>
	public class TaskRegistController: AbsViewController
	{
		public TaskRegistController(){}

		/// <summary>
		/// 받은 개수와 key값에 해당되는 개수를 갱신한다.<br />
		/// 기본적으로 key값에 대응되는 개수에 대하여 증가이며<br />
		/// 반면 받은 개수는 그 개수만큼 감소 시킨다.<br />
		/// </summary>
		/// <param name="key">개수를 증가시킬 항목명</param>
		/// <param name="incValue">증가값</param>
		/// <param name="executeSingleQuery">받은 개수를 DB에 업데이트 할지의 여부</param>
		protected void UpdateQuantity(IMultiColumnRecordable viewData, string key, int incValue, bool executeSingleQuery){
			if ((key != null) && (viewData[key] == "")) viewData[key] = "0";
			if (viewData["ReceivedQuantity"] == "") viewData["ReceivedQuantity"] = "0";
			
			if (key != null) { // null이면 자재 투입으로 친다.
				viewData[key] = (Int32.Parse(viewData[key]) + incValue).ToString(); 
			}

			viewData["ReceivedQuantity"] = (Int32.Parse(viewData["ReceivedQuantity"]) - incValue).ToString();
			viewData["ProductAdd"] = incValue.ToString();
			
			if (executeSingleQuery == true) ViewBinder.DBManager.ExecuteNonQuery(
				"table_update change_task_process_recv_qty", viewData);
		}
		protected void UpdateRemaining(IMultiColumnRecordable viewData, double incValue){
			UpdateRemaining(viewData, incValue, false);
		}
		protected void UpdateRemaining(IMultiColumnRecordable viewData, double incValue, bool isWeight){
			if ((viewData["IsFirstProc"] == "true")){
				if (viewData["ProcessCode"] == "1A"){
					if (isWeight == false) viewData["Remaining"] = (Double.Parse(viewData["Remaining"]) + MaterialSkelpInfo.GetRemainingWeight(viewData, incValue)).ToString();
					else viewData["Remaining"] = (Double.Parse(viewData["Remaining"]) + incValue).ToString();
				}
				else {
					viewData["Remaining"] = (Double.Parse(viewData["Remaining"]) + incValue).ToString();
				}
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_update change_task_process_remaining", viewData);
			}
		}
		public void AddProduct(IMultiColumnRecordable viewData, string incValue){
			UpdateQuantity(viewData, "ProductionQuantity", Int32.Parse(incValue), false);
			UpdateRemaining(viewData, -Double.Parse(incValue));
			
			ViewBinder.DBManager.ExecuteNonQuery(
				"table_update change_task_process_prod_qty", viewData);
			viewData["AddValue"] = incValue;
			ViewBinder.Log.WriteByWorking(viewData, "addProd");
			viewData.RemoveKey("AddValue");
		}
		
		public void AddProduct(IMultiColumnRecordable viewData){
			string sValue = ShowNumberPad(viewData["ReceivedQuantity"]);
			if ((sValue == null) ||
				    (IsMinusValueWhenAddProd(sValue) == true)) return;
			
			AddProduct(viewData, sValue);
			OnLogMessage(this, "현재 공정에서의 생산 추가를 완료 하였습니다.");
		}
		
		public void UpdateBad(IMultiColumnRecordable matData){
			List<string[]> saList =  ShowGridSelector(DataViewBinder.TABLE_BADCODE, matData["ProcessCode"] == "1A");
			if (saList.Count == 0) return;
			IMultiColumnRecordable badData = new Badness(matData);
			
			foreach(string[] saData in saList){
				badData["BadCode"] = saData[0];
				badData["BadQuantity"] = saData[1];
	
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_BC_INSERT_Prod_Enter_TEMP", badData);
				// 저장 프로시저로 불량쪽 바코드를 새로 받아내어 처리한다.
				badData["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1");
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_BC_INSERT_Prod_Enter_Remain", badData);
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_P1_INSERT_BADNESS", badData);
				
				UpdateQuantity(matData.Parent as IMultiColumnRecordable, 
				               "BadQuantity", Int32.Parse(badData["BadQuantity"]), true);
				UpdateRemaining(matData.Parent as IMultiColumnRecordable, 
				                -Double.Parse(badData["BadQuantity"]));
			}
			badData.MemberClear();
			OnLogMessage(this, "불량 등록을 완료 하였습니다.");
		}
		
		public void UpdateWaste(IMultiColumnRecordable matData){
			List<string[]> saList =  ShowGridSelector(DataViewBinder.TABLE_BADCODE, matData["ProcessCode"] == "1A");
			if (saList.Count == 0) return;
			IMultiColumnRecordable waste = new Waste(matData);

			foreach(string[] saData in saList){
				waste["BadCode"] = saData[0];
				waste["BadQuantity"] = saData[1];
				waste["WasteWeight"] = saData[2];
				waste["WasteLength"] = "0";
				
				if(waste["ProcessCode"] == "1A") {
					ViewBinder.DBManager.ExecuteNonQuery(
						"procedure_insert TM_P1_INSERT_WASTE", waste);
					
					ViewBinder.DBManager.ExecuteNonQuery(
					"table_insert add_task_process_waste", waste);
					
					waste["BadQuantity"] = MaterialSkelpInfo.GetExpectQuantity(matData, Double.Parse(waste["WasteWeight"])).ToString();
					
					UpdateQuantity(matData.Parent as IMultiColumnRecordable, 
					               "WasteQuantity", Int32.Parse(waste["BadQuantity"]), true);
					UpdateRemaining(matData.Parent as IMultiColumnRecordable,
					                -Double.Parse(waste["WasteWeight"]), true);
					
					break;
				}
				else{
					// 1차 포장 예외처리 추가 - by jhson 121106
					if (waste["ProcessCode"] == "1E" && waste.ContainsKey("ProductCode") == false){
						IMultiColumnRecordable tempProd = new MaterialProdInfo(matData);
						tempProd["Quantity"] = tempProd["BadQuantity"];
						// 가입고 테이블에 삽입
						ViewBinder.DBManager.ExecuteNonQuery(
							"procedure_insert TM_BC_INSERT_Prod_Enter_TEMP", tempProd);
						// 저장 프로시저로 바코드를 새로 받아내어 처리한다.
						waste["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1").Replace(' ', '0');
					}
					
					ViewBinder.DBManager.ExecuteNonQuery(
						"procedure_insert TM_P2_INSERT_WASTE", waste);
					
					ViewBinder.DBManager.ExecuteNonQuery(
					"table_insert add_task_process_waste", waste);
				
					UpdateQuantity(matData.Parent as IMultiColumnRecordable, 
					               "WasteQuantity", Int32.Parse(waste["BadQuantity"]), true);
					UpdateRemaining(matData.Parent as IMultiColumnRecordable,
					                -Double.Parse(waste["BadQuantity"]));
				}
				
				
			}
			waste.MemberClear();
			OnLogMessage(this, "폐철 등록을 완료 하였습니다.");
		}
		
		public void InsertMaterial(IMultiColumnRecordable matData){
			string sQueryKey = "";
			string sQueryKey2 = "";

			try{
				if 		(matData is MaterialSkelpInfo)  {
					sQueryKey = "procedure_insert TM_P1_INSERT_T_Plan_Mat_Use";
					sQueryKey2 = "table_update change_skelp_input";
					matData.Parent["ProductAdd"] = matData["ExpectQuantity"];
					UpdateRemaining(matData.Parent as IMultiColumnRecordable,
					                Double.Parse(matData["Weight"]), true);
				}
				else if (matData is MaterialProdInfo) 	{
					sQueryKey = "table_insert add_prod_use";
					sQueryKey2 = "table_update change_prod_input";
					matData.Parent["ProductAdd"] = matData["Quantity"];
					UpdateRemaining(matData.Parent as IMultiColumnRecordable,
					                Double.Parse(matData["ProductAdd"]), false);
				}
				else return;

				ViewBinder.DBManager.ExecuteNonQuery(sQueryKey, matData);
				ViewBinder.DBManager.ExecuteNonQuery(sQueryKey2, matData);
				UpdateQuantity(matData.Parent as IMultiColumnRecordable,
				               null, -Int32.Parse(matData["ProductAdd"]), true);// 받은 수량을 증가 시키기 위해 음수로 만든다.
				
				ViewBinder.Log.WriteByWorking(matData, "insertMat");
				OnLogMessage(this, "제품 투입이 완료 되었습니다.");
			}
			catch(SqlException ex){
				if (ex.Message.Contains("PRIMARY KEY")){
					OnLogMessage(this, "오류: 동일 제품을 중복 투입 하려 하였습니다.");
				}
			}
		}
		
		public void RegistRemaining(IMultiColumnRecordable matData){
			RegistRemaining(matData, true);
		}
		
		public void RegistRemaining(IMultiColumnRecordable matData, bool showNumPad){
			IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
			string sUserValue = matData["Remaining"];
			if (showNumPad == true) sUserValue = ShowNumberPad(viewData["UIRemaining"]); // 사용자에게 입력 받음
			if (sUserValue == null) return;
			
			double dRemaining = 0;
			
			viewData["UsableValue"] = sUserValue; // 등록하려는 잔량 수치 만큼 앞으로 사용 가능하므로..			
			
			// 사용자가 등록 한 값이 0일 경우 해당 잔량 내역 레코드를 삭제 한다.
			if (Double.Parse(viewData["UsableValue"]) <= 0){
				dRemaining = 0;
			}
			else{
				dRemaining = Double.Parse(viewData["UIRemaining"]) - Double.Parse(viewData["UsableValue"]);
			}
			
			// 남은 잔량이 더이상 없을 경우 플래그를 Y로 준다.
			if (dRemaining <= 0.0) {
				matData["AllUseFlag"] = "Y";
				viewData["Remaining"] = "0";
			}
			else {
				matData["AllUseFlag"] = "N";
				viewData["Remaining"] = dRemaining.ToString("0.0");
			}
			
			if (matData is MaterialSkelpInfo) {
				matData["UseWeight"] = (Double.Parse(matData["Weight"]) - Double.Parse(matData["UsableValue"])).ToString("0.0");
				
				try{ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_P1_INSERT_MAT_USE", matData);
				}catch(Exception){}
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_update change_skelp_remaining", matData);
				ViewBinder.Log.WriteByWorking(matData, "regRemain1");
			}
			else {
				matData["UseQuantity"] = (Double.Parse(matData["Quantity"]) - Double.Parse(matData["UsableValue"])).ToString("0");
				/*ViewBinder.DBManager.ExecuteNonQuery(
					"table_update regist_remaining_product", matData);*/ // 잔량 등록 시 중복 투입이 되는 오류 차단
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_update change_prod_remaining", matData);
				ViewBinder.Log.WriteByWorking(matData, "regRemain2");
			}
			ViewBinder.DBManager.ExecuteNonQuery(
					"table_update change_task_process_remaining", viewData); // 잔량 테이블에 내용 업데이트.
			
			
			OnLogMessage(this, "잔량 등록을 완료 하였습니다.");
		}
			
		public void InsertTempMaterial(IMultiColumnRecordable matData){
			try{
				IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
				string sUserValue = ShowNumberPad(viewData["ReceivedQuantity"]); // 사용자에게 입력 받음
				if ((sUserValue == null) ||
				    (IsMinusValueWhenAddProd(sUserValue) == true)) return;
			
				string sTmpCode = viewData["ProcessCode"];
				IMultiColumnRecordable tempProd = new MaterialProdInfo(matData);
				tempProd["ProcessCode"] = viewData["NextProcCode"];
				
				tempProd["Quantity"] = sUserValue;
				// 가입고 테이블에 삽입
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_insert TM_BC_INSERT_Prod_Enter_TEMP", tempProd);
				// 저장 프로시저로 바코드를 새로 받아내어 처리한다.
				tempProd["ProductCode"] = ViewBinder.DBManager.GetOutputParamValue("@p_OutPut1").Replace(' ', '0');
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_insert add_prod_use", tempProd);
				viewData["ProcessCode"] = sTmpCode;
				AddProduct(viewData, sUserValue);
				OnLogMessage(this, "생산 추가 및 가입고 등록을 완료 하였습니다.");
			}
			catch(SqlException ex){
				if (ex.Message.Contains("PRIMARY KEY")){
					OnLogMessage(this, "오류: 동일 제품을 중복 투입 하려 하였습니다.");
				}
			}
		}
		
		public bool IsMinusValueWhenAddProd(string userValue){
			if(Int32.Parse(userValue) < 0){
				MsgBox.Show("오류", "생산 추가 시엔 음수(-)를 입력할 수 없습니다.");
				return true;
			}
			return false;
		}
		
		public void AfterPrint(IMultiColumnRecordable viewData){
			UpdateQuantity(viewData, "ProductionQuantity", Int32.Parse(viewData["TotalQuantity"]), false);
			
			ViewBinder.DBManager.ExecuteNonQuery(
				"table_update change_task_process_prod_qty", viewData);
			AddPrintQty(viewData);
		}
		
		public void FinishProcess(IMultiColumnRecordable matData){
			IMultiColumnRecordable viewData = matData.Parent as IMultiColumnRecordable;
			viewData["Status"] = "E"; // 공정상태: A=대기, I=진행, W=중단, E=종료
			
			if (viewData["IsLastProc"] == "true"){
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_update TM_P1_UPDATE_End_Packing", viewData);
			}
			
			if (viewData["ProcessCode"] == "1E"){
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_update TM_P1_UPDATE_End_Production", matData);
			}
			else if (viewData["ProcessCode"] == "2E"){
				ViewBinder.DBManager.ExecuteNonQuery(
					"procedure_update TM_P2_UPDATE_End_Production", matData);
			}

			ViewBinder.DBManager.ExecuteNonQuery(
				"table_update task_process_end", matData);
			
			OnLogMessage(this, "공정이 완료 되었습니다.");
		}
		
		public DataTable GetInsertStatusData(IMultiColumnRecordable viewData){
			string sQueryKey = "table_select find_prod_input";

			if (viewData["ProcessCode"].StartsWith("1") == true){
				sQueryKey = "table_select find_skelp_input";
			}
			else if (viewData["IsChainProc"] == "true"){
				sQueryKey = "table_select find_prod_input_temp";
			}
			
			return ViewBinder.DBManager.ExecuteQuery(
				sQueryKey, "@p_PO_No", viewData["OrderNo"]).Tables[0];
		}
		
		public override IMultiColumnRecordable CreateModel(System.Data.DataRow row)
		{
			bool bIsSkelp = (row.Table.Columns.Contains("MAT_BARCODE") == true);
			
			return CreateModel(row, bIsSkelp);
		}
		public IMultiColumnRecordable CreateModel(DataRow row, bool isSkelp){
			if(isSkelp == true){
				return new MaterialSkelpInfo(
					ViewBinder.DBManager.MatchTable, row);
			}
			else{
				return new MaterialProdInfo(
					ViewBinder.DBManager.MatchTable, row);
			}
		}
		
		public List<IMultiColumnRecordable> CreateModelList(DataTable data){
			bool bIsSkelp = (data.Columns.Contains("MAT_BARCODE") == true);
			List<IMultiColumnRecordable> viewDataList = new List<IMultiColumnRecordable>();
			
			foreach(DataRow row in data.Rows){
				viewDataList.Add(CreateModel(row, bIsSkelp));
			}
			
			return viewDataList;
		}
		
		public IMultiColumnRecordable SearchMaterial(IMultiColumnRecordable viewData, string key, string value){
			string sQueryKey = "";
			string sParam = "@p_Barcode";
			
			if(key == "MaterialProdInfo"){
				sQueryKey = "table_select find_prod_info";
			}
			else if (key == "MaterialSkelpInfo")
			{
				if (value.Length == 22) sQueryKey = "table_select find_skelp_info_by_barcode";
				else if ((value.IndexOf('-', 0) > 0) && 
				         (value.Length > 9)){
					sQueryKey = "table_select find_skelp_info_by_matno";
					sParam = "@p_Mat_No";
				}
				else return null;
			}
			else return null;
			
			return SearchMaterial(viewData, sQueryKey, sParam, value);
		}
		
		public IMultiColumnRecordable SearchMaterial(IMultiColumnRecordable viewData, string queryKey, string param, string value){
			DataTable data = ViewBinder.DBManager.ExecuteQuery(queryKey, param, value).Tables[0];
			string sUseType = viewData["ProcessCode"];
			IMultiColumnRecordable matData = null;
			
			if ((data == null) ||
			    (data.Rows.Count < 1)) {
				OnLogMessage(this, "해당 코드로 자재, 혹은 제품 정보를 찾을 수 없습니다.");
				return null;
			}
			
			if (sUseType == "1A"){
				matData = new MaterialSkelpInfo(
					ViewBinder.DBManager.MatchTable, data.Rows[0]);
			}
			else {
				matData = new MaterialProdInfo(
					ViewBinder.DBManager.MatchTable, data.Rows[0]);
			}
			
			viewData.AddChild(matData);// 자재 데이터가 만들어 졌으니 부모 데이터에 첨가 한다.
			OnLogMessage(this, "");
			return matData;
		}
		
		public bool ChangeEquip(IMultiColumnRecordable viewData){
			FormEquipChange frm = new FormEquipChange();
			frm.SetCurrEquipCode(viewData["EquipCode"]);
			frm.SetData(ViewBinder.Data.Tables["table_select find_equipment"]);
			
			if (frm.ShowDialog() == DialogResult.OK){
				viewData["EquipCode"] = frm.GetSelectedEquipCode();
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_update change_task_process_equip", viewData);

				OnLogMessage(this, "현재 공정에서의 설비 변경을 완료 하였습니다.");
				return true;
			}
			frm.MemberClear();
			return false;
		}
		
		public bool ChangeWorker(IMultiColumnRecordable viewData){
			string sWorker = ShowGridSelectorSingle(DataViewBinder.TABLE_WORKER);
			
			if (sWorker != null){
				viewData["Worker"] = sWorker;
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_update change_task_process_worker", viewData);
				
				OnLogMessage(this, "현재 공정에서의 작업자 변경을 완료 하였습니다.");
				return true;
			}
			return false;
		}
		
		public void CalcRecvByRemainng(IMultiColumnRecordable viewData){
			UpdateQuantity(viewData, null, Int32.Parse(viewData["TotalQuantity"]), true);
			AddPrintQty(viewData);
		}
		
		public void AddPrintQty(IMultiColumnRecordable viewData){
			if (viewData.ContainsKey("IsRemain") == true){
				viewData["InPrintRemainQty"] = viewData["TotalQuantity"];
				viewData["InPrintProdQty"] = "0";
			}
			else{
				viewData["InPrintRemainQty"] = "0";
				viewData["InPrintProdQty"] = viewData["TotalQuantity"];
			}
			ViewBinder.DBManager.ExecuteNonQuery("table_insert add_print_qty", viewData);
			viewData.Add("PrintRemainQty", viewData["InPrintRemainQty"]);
			viewData.Add("PrintProdQty", viewData["InPrintProdQty"]);
		}
		
		// 스켈프 투입 시 자재의 사용 여부 체크 추가 - 120911 jhson
		public bool CheckMaterialSpec(IMultiColumnRecordable targetData, IMultiColumnRecordable matData){
			SpecCheckType checkType = SpecCheckType.OK;
			
			if (
				((matData is MaterialProdInfo) && ((matData["Status"] == "U") || (matData["Status"] == "O") || (Double.Parse(matData["Quantity"]) <= 0)) ) ||
				 ((matData is MaterialSkelpInfo) && ((matData["Status"] != "I") || (Double.Parse(matData["Weight"]) <= 0)) )
			){
				MsgBox.Show("오류", "검색 된 자재는 현재 사용중이거나 소진 되었습니다.\r\n다른 자재를 검색 하여 투입 하여 주십시요.");
				return false;
			}
			
			if (matData is MaterialSkelpInfo){
				 checkType = MaterialSkelpInfo.IsEqualSpec(targetData, matData);
			}
			else {
				checkType = MaterialProdInfo.IsEqualSpec(targetData, matData);
			}
			
			if ((ViewBinder.DBManager.Config["Other", "SpecCheckInterlock"] == "true") &&
				(checkType != SpecCheckType.OK)) {
			
				if (checkType == SpecCheckType.OuterDiameter){
					MsgBox.Show("오류", "자재의 외경이 작업 지시서와 맞지 않습니다.");
				}
				else if (checkType == SpecCheckType.Thickness){
					MsgBox.Show("오류", "자재의 두께가 작업 지시서와 맞지 않습니다.");
				}
				else if (checkType == SpecCheckType.Quality){
					MsgBox.Show("오류", "자재의 강종이 작업 지시서와 맞지 않습니다.");
				}
				
				return false;
			}
			
			return true;
		}
	}
}
