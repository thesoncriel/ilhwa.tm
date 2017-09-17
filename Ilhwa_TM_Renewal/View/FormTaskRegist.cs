/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
using Artn.Ilhwa.View.TasRegistPart;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of FormTaskProcessRegist.
	/// </summary>
	public partial class FormTaskRegist : DataViewForm
	{		
		public FormTaskRegist()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public override Theson.Common.IMultiColumnRecordable ViewData {
			get {
				return base.ViewData;
			}
			set {
				if (value == null) return;
				
				base.ViewData = value;
				
				taskProcessViewPart.ViewData = value;
				taskOrderViewPart.ViewData = value;
				taskMaterialsViewPart.ViewData = value;
				// 12차 수정 진행 - 모든 공정에 공정 완료 버튼 기능 추가 - 121019 by jhson
				//button_ProcessComplete.Visible = (value["IsLastProc"] == "true");
			}
		}
		
		public TaskType TransformType{
			get{
				return taskMaterialsViewPart.TransformType;
			}
			set{
				taskMaterialsViewPart.TransformType = value;
			}
		}
		
		public void MoveOtherScreen(string screenName, bool refresh){
			Form frm;
			String sName = screenName;
			if (sName.Contains("TaskOrder") == true){
				frm = (MdiParent as MainForm).Form_TaskOrderList;
			}
			else{
				frm = (MdiParent as MainForm).Form_TaskProcList;
			}
			
			this.WindowState = FormWindowState.Minimized;
			frm.Show();
			ViewData.Clear();
			if (refresh == true) frm.Refresh();
			frm.WindowState = FormWindowState.Maximized;
		}
		
		void ViewPartLogMessage(object Sender, string msg)
		{
			OnLogMessage(Sender, msg);
		}
		
		void Button_GoToScreenClick(object sender, EventArgs e)
		{
			string sName = (sender as Control).Name;
			MoveOtherScreen(sName, sName.Contains("TaskProcess") == true);
		}
		
		void InputMaterialsViewPart1LogMessage(object Sender, string msg)
		{
			OnLogMessage(Sender, msg);
		}
		
		public override void Refresh(){
			base.Refresh();
			
			string sRemaining = "";

			taskMaterialsViewPart.SetInsertStatusListData(ViewCtrl.TaskRegist.GetInsertStatusData(ViewData));
			
			sRemaining = ViewData["Remaining"];
			if (sRemaining == "") sRemaining = "0";
			
			taskMaterialsViewPart.MaterialRemaining = Double.Parse(sRemaining);
		}
		
		void SubViewDataChange(object sender, string key, string value){}

		void TaskProcessViewPartAddProdClick(object sender, EventArgs e)
		{
			if ((ViewData["ProcessCode"] == "1A") && (ViewCtrl.TaskProcess.FindNextProcessCode(ViewData) != "1E")) { // 1-2차 연계 공정 시 중간 포장단계는 삭제 하여 '조관'에서 생산 하면 바로 다음 공정으로 생산 개수를 넘긴다.
				if(CheckInsertedItem() == false) return;
				ViewCtrl.TaskRegist.InsertTempMaterial(taskMaterialsViewPart.GetLastInsertedItem());
			}
			else{
				ViewCtrl.TaskRegist.AddProduct(ViewData);
			}
			
			ViewData = ViewData; // 가진 뷰 데이터를 다시 설정함으로써 UI 내용을 갱신 한다.
		}
		
		void TaskProcessViewPartBadInsertClick(object sender, EventArgs e)
		{
			if(CheckInsertedItem() == false) return;
			
			ViewCtrl.TaskRegist.UpdateBad(taskMaterialsViewPart.GetLastInsertedItem());
			ViewData = ViewData;
		}
		
		void TaskProcessViewPartWasteInsertClick(object sender, EventArgs e)
		{
			if(CheckInsertedItem() == false) return;
			
			ViewCtrl.TaskRegist.UpdateWaste(taskMaterialsViewPart.GetLastInsertedItem());
			ViewData = ViewData;
		}
		
		void TaskMaterialsViewPartAddMaterialClick(object sender, EventArgs e)
		{
			IMultiColumnRecordable matData = taskMaterialsViewPart.GetFoundMaterial();
			
			if(matData == null) {
				MsgBox.Show("오류", "자재를 검색하지 않았습니다.\r\n좌측 검색기에서 검색하여 주십시요.");
				return;
			}
			
			if (ViewCtrl.TaskRegist.CheckMaterialSpec(ViewData, matData) == false){
				return;
			}
			
			if(taskMaterialsViewPart.ContainsBarcode(matData["Barcode"]) == true){
				if(MsgBox.ShowDialog("경고", "이미 등록된 자재가 있습니다.\r\n계속 하시겠습니까?") == DialogResult.Cancel) return;
			}
			
			if (taskMaterialsViewPart.GetItemCount() == 0){
				ViewCtrl.TaskProcess.StartProcess(ViewData);
			}

			taskMaterialsViewPart.AddMaterialToInputList(matData);
			ViewCtrl.TaskRegist.InsertMaterial(matData);

			taskMaterialsViewPart.ClearSearchKeyword(); // MOD: 자재 등록 시 검색 내역 Clear - jhson 120907
			
			ViewData = ViewData;
		}
		
		void TaskMaterialsViewPartRegistRemainingClick(object sender, EventArgs e)
		{
			if(CheckInsertedItem() == false) return;
			
			IMultiColumnRecordable matData = taskMaterialsViewPart.GetLastInsertedItem();
			string sProcCode = ViewData["ProcessCode"];
			// 포장측 잉여 잔량 처리
			if ((sProcCode == "1E") || 
			    (sProcCode == "2E")){ // 잉여 잔량 처리 루틴 추가 - jhson 120925
				matData["IsRemain"] = "true";
				if (ViewCtrl.Barcode.Print(matData, ViewData["ReceivedQuantity"], "1") == false) {
					matData.RemoveKey("IsRemain");
					ViewCtrl.Log.WriteByWorking(matData, "regRemainEx");
					return;
				}
				ViewData["IsRemain"] = "true";
				//ViewCtrl.TaskRegist.CalcRecvByRemainng(ViewData);
				ViewCtrl.TaskRegist.AfterPrint(ViewData); // 포장 공정에서 제품과 잔량 수치를 합하여 실적에 반영하는 기능 추가 - by jhson 121122
			}
			// 2차 투입 잔량 처리
			else if ((sProcCode != "1A") && (ViewData["IsFirstProc"] == "true")){
				matData["IsRemain"] = "true";
				if (ViewCtrl.Barcode.PrintRemaining(matData, ViewData["Remaining"], "1") == false){
					matData.RemoveKey("IsRemain");
					return;
				}
				ViewData["Remaining"] = matData["TotalQuantity"];
				ViewCtrl.TaskRegist.RegistRemaining(matData, false);
			}
			// 1차 투입 잔량 처리
			else{
				ViewCtrl.TaskRegist.RegistRemaining(matData);
			}
			ViewData.RemoveKey("isRemain");
			matData.RemoveKey("IsRemain");
			ViewData = ViewData;
		}
		
		void Button_ProcessCompleteClick(object sender, EventArgs e)
		{
			if (CheckInsertedItem() == false) return;
			
			if ((ViewData["IsFirstProc"] == "true") && (Double.Parse(ViewData["Remaining"]) > 0)){
				MsgBox.Show("오류", "잔량이 아직 남아 있습니다.\r\n잔량 정리를 하고 다시 시도하여 주십시요.\r\n남은 잔량: " + ViewData["Remaining"]);
				return;
			}
			
			if (ViewCtrl.TaskProcess.IsPrevProcCompleted(ViewData) == false){
				MsgBox.Show("오류", "이전 공정이 완료 되지 않았습니다.\r\n이전 공정 내역을 확인하고 완료 하여 주십시요.");
				return;
			}
			
			if (MsgBox.ShowDialog("확인", "완료시 현재 작업에 대한 수정이 불가 하게 됩니다.\r\n공정 완료를 진행 하시겠습니까?") == DialogResult.Cancel) return;
			
			ViewCtrl.TaskRegist.FinishProcess(taskMaterialsViewPart.GetLastInsertedItem());
			ViewData = ViewData;
			
			if (ViewData["IsLastProc"] == "true"){
				MoveOtherScreen("TaskOrder", true);
				OnLogMessage(this, "공정이 완료 되었습니다. 다른 작업을 진행하려면 검색하여 주십시요.");
			}
			else{
				MoveOtherScreen("TaskProcess", true);
			}	
		}
		
		protected bool CheckInsertedItem(){
			bool bRet = taskMaterialsViewPart.GetItemCount() > 0;
			if (bRet == false)
				//MsgBox.Show("오류", "투입 내역을 선택하지 않았습니다.\r\n투입 목록에서 사용 할 자재를 선택하여 주십시요.");// 12차 수정 진행 - 가장 최근에 투입된 자재를 이용하기에 삭제 - 121019 by jhson
				MsgBox.Show("오류", "현재 작업에서 투입 내역이 존재하지 않습니다.\r\n자재 투입 후 다시 시도하여 주십시요.");
			
			return bRet;
		}

		void TaskMaterialsViewPartBarcodePrintClick(object sender, EventArgs e)
		{
			if (CheckInsertedItem() == false) return;
			
			string sQuantity = "0";
			string sBunchCnt = "0";
			IMultiColumnRecordable itemData = taskMaterialsViewPart.GetLastInsertedItem();
	
			if (itemData["UseTypeCode"] == "O"){
				sQuantity = itemData["PlanQuantity"];
				sBunchCnt = "1";
			}

			if (ViewCtrl.Barcode.Print(itemData, sQuantity, sBunchCnt) == true){
				ViewCtrl.TaskRegist.AfterPrint(ViewData);
				ViewData = ViewData;
				ViewData["IsPrinted"] = "true";
				OnLogMessage(this, "바코드 출력을 완료 하였습니다.");
			}
		}
		
		void TaskMaterialsViewPartChainInputClick(object sender, EventArgs e)
		{
			if (ViewData["ProcessCode"] == "1A") return;
			
			FormChainInputList frm = new FormChainInputList();
			frm.ViewCtrl = ViewCtrl;
			frm.ViewData = ViewData;
			
			if (frm.ShowDialog() == DialogResult.OK){
				frm.FillDataToDataViewList(sender as InputStatusListViewPart);
				OnLogMessage(this, "자재 연속 투입을 완료 하였습니다.");
				ViewData = ViewData;
			}
			
			frm.MemberClear();
		}
	}
}
