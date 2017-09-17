/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-31
 * Time: 오전 9:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.Controller;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View.Dialog
{
	/// <summary>
	/// Description of FormBarcodePrinter.
	/// </summary>
	public partial class FormBarcodePrinter : DataViewForm
	{
		private IMultiColumnRecordable _viewData = null;
		private string _temp = "";
		private string _gridValue = "";
		private List<string> _prodCodeList = new List<string>();
		private bool _etcMode = false;
		
		public FormBarcodePrinter()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			EtcMode = false;
		}
		
		public bool EtcMode{
			get{
				return _etcMode;
			}
			set{
				_etcMode = value;
				textBox_ODName.Visible = !value;
				labelODLabel.Text = (value == true)? "외경" : "호칭경";
				comboBox_ODName.Visible = value;
				comboBox_ProdName.Visible = value;
				comboBox_Thickness.Visible = value;
				button_Bad.Visible = value;
				label_PlanQuantity.Visible = !value;
			}
		}
		
		public override Theson.Common.IMultiColumnRecordable ViewData {
			get { 
				_viewData["Customer"] = textBox_Customer.Text;
				_viewData["CustomerCode"] = textBox_CustomerCode.Text;
				_viewData["ProdName"] = textBox_ProdName.Text;
				_viewData["ProdCode"] = textBox_ProdCode.Text;
				_viewData["ODName"] = textBox_ODName.Text;
				_viewData["OuterDiameter"] = textBox_OuterDiameter.Text;
				_viewData["Thickness"] = textBox_Thickness.Text;
				_viewData["Worker"] = textBox_Worker.Text;
				_viewData["PlanLength"] = textBox_PlanLength.Text;
				_viewData["Quantity"] = textBox_Quantity.Text;
				_viewData["BunchCount"] = textBox_BunchCount.Text;
				
				// BarcodeInfo > MaterialData(Skelp, Pipe) > TaskProcess ===
				try{
					_viewData.Parent.Parent["TotalQuantity"] = label_TotalQuantity.Text;
				}
				catch(NullReferenceException){
					_viewData["TotalQuantity"] = label_TotalQuantity.Text;
				}
				return _viewData; 
			}
			set { 
				_viewData = value;
				ViewCtrl.BindingViewData(this, "textBox", value);
				
				if((_viewData.ContainsKey("IsRemain") == true) &&
				   (_viewData["IsRemain"] == "true")){
					button_PrintManual.Visible = false;
					label_PlanQuantity.Visible = false;
				}
				else{
					label_PlanQuantity.Visible = true;
					label_PlanQuantity.Text = "주문개수 (" + value["PlanQuantity"] + ")";
				}
				
				comboBox_Thickness.Items.Clear();
				foreach(DataRow row in ViewCtrl.Data.Tables[DataViewBinder.TABLE_THICKNESS].Select()){
					comboBox_Thickness.Items.Add(row["Std_THK"].ToString());
				}

			}
		}
		
		// 외주입고 발행 시 데이터 입력 항목 체크 기능 추가 - by jhson 121122
		public bool CheckInputValues(){
			return (textBox_CustomerCode.Text != "") &&
				(comboBox_ODName.Text != "") &&
				(comboBox_ProdName.Text != "") &&
				(comboBox_Thickness.Text != "") &&
				(textBox_PlanLength.Text != "") &&
				(textBox_Worker.Text != "") &&
				(textBox_Quantity.Text != "") &&
				(Int32.Parse(textBox_Quantity.Text) > 0) &&
				(textBox_BunchCount.Text != "") &&
				(Int32.Parse(textBox_BunchCount.Text) > 0);
		}
		
		public string GetBlankFields(){
			string sFieldName = "";
			
			if (textBox_Customer.Text == "") sFieldName += "거래처 ";
			if (comboBox_ODName.Text == "") sFieldName += "호칭경 ";
			if (comboBox_ProdName.Text == "") sFieldName += "SPEC ";
			if (comboBox_Thickness.Text == "") sFieldName += "두께 ";
			if (textBox_PlanLength.Text == "") sFieldName += "길이 ";
			if (textBox_Worker.Text == "") sFieldName += "작업자 ";
			if (textBox_Quantity.Text == "" || Int32.Parse(textBox_Quantity.Text) <= 0) sFieldName += "묶음수량 ";
			if (textBox_BunchCount.Text == "" || Int32.Parse(textBox_BunchCount.Text) <= 0) sFieldName += "발행매수 ";
			
			return sFieldName;
		}
		
		void TextBox_Click(object sender, EventArgs e)
		{
			TextBox txtBox = sender as TextBox;
			string sName = txtBox.Name.Replace("textBox_", "");
			_temp = txtBox.Text;
			
			//if 		(sName == "Customer") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_CUSTOMER].Select());
			//else if (sName == "ProdCode")		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_PRODUCT].Select());
			//else if (sName == "ODName") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_OD].Select("Prod_Code = '" + textBox_ProdCode.Text + "'"));
			//else if (sName == "Thickness") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_THICKNESS].Select("Prod_Code = '" + textBox_ProdCode.Text + "'"));
			if (sName == "Worker") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_WORKER].Select());
			else 								txtBox.Text = ShowNumberPad();
			
//			if (sName == "ODName") textBox_OuterDiameter.Text = _gridValue;
//			if (sName == "Customer") textBox_CustomerCode.Text = _gridValue;
//			if (sName == "ProdCode"){
//				textBox_ProdName.Text = _gridValue;
//			}
			
		}
		
		string ShowGridSelector(DataRow[] data){
			FormGridSelector gridFrm = new FormGridSelector(false);
			gridFrm.SetData(data);
			
			if(gridFrm.ShowDialog() == DialogResult.OK){
				_gridValue = gridFrm.GetSelectValueData();
				return gridFrm.GetSelectSingleData();
			}
			
			return _temp;
		}
		
		string ShowNumberPad(){
			FormNumberPad numPad = new FormNumberPad();
			
			if(numPad.ShowDialog() == DialogResult.OK){
				return numPad.Value;
			}
			
			return _temp;
		}
		
		void Button_ODNumPadClick(object sender, EventArgs e)
		{
			textBox_OuterDiameter.Text = ShowNumberPad();
		}
		
		void Button_ThkNumPadClick(object sender, EventArgs e)
		{
			textBox_Thickness.Text = ShowNumberPad();
		}
		
		void Button_PrintClick(object sender, EventArgs e)
		{
			// 주문인 작업지시를 통한 바코드 출력시 공백이 출력 되지 않게 조치 - 2013.05.28 by shkang
			if (ViewData["Quantity"] == "" || ViewData["BunchCount"] == "" ){
				MsgBox.Show("오류", "작업 지시가 '주문'일 경우 묶음 수량과 발행수량은 공백이 될 수 없습니다.");
				DialogResult = DialogResult.None;
				return;
			}
			// 주문인 작업지시를 통한 바코드 출력 시 수량의 개수/전체 개수의 곱이 0이면 출력 안되게 조치 - 2013.05.14 by jhson
			if (
				((Int32.Parse(ViewData["Quantity"]) * Int32.Parse(ViewData["BunchCount"])) == 0)
			   ){
				MsgBox.Show("오류", "작업 지시가 '주문'일 경우 묶음 수량과 발행수량은 각각 0이 될 수 없습니다.");
				DialogResult = DialogResult.None;
				return;
			}
			if ((ViewData.ContainsKey("IsOtherProd") == false) && (ViewData.ContainsKey("IsRemain") == false)){
				if (Int32.Parse(ViewData["PlanQuantity"]) < (Int32.Parse(ViewData["TotalQuantity"]) + Int32.Parse(ViewData["PrintProdQty"])) ){
					MsgBox.Show("오류", "작업 지시서의 계획 수량보다 바코드의 실적 등록 수량이 더 많습니다.\r\n계획수량: " + ViewData["PlanQuantity"] + "\r\n누적수량: " + ViewData["PrintProdQty"]);
					DialogResult = DialogResult.None;
				}
			}
			// 
			else if (
				(ViewData.ContainsKey("IsLastProc") == true) && 
				(ViewData["IsLastProc"] == "true") &&
				(ViewData.ContainsKey("IsRemain") == true) && 
				(ViewData["IsRemain"] == "true") &&
				(Int32.Parse(ViewData["ReceivedQuantity"]) < (Int32.Parse(ViewData["TotalQuantity"]))) ){
					MsgBox.Show("오류", "받은 수량 보다 많은 개수로 잔량을 처리하려 하였습니다.\r\n받은수량: " + ViewData["ReceivedQuantity"] + "\r\n처리수량: " + label_TotalQuantity.Text);
					DialogResult = DialogResult.None;
			}
			// 외주입고 발행 시 데이터 입력 항목 체크 기능 추가 - by jhson 121122
			else if (ViewData.ContainsKey("IsOtherProd") == true){
				if (CheckInputValues() == false){
					MsgBox.Show("오류", "입력값이 비어 있습니다.\r\n외주입고시엔 모든 항목에 입력을 해야 합니다.\r\n비어있는항목 ::: " + GetBlankFields());
					DialogResult = DialogResult.None;
				}
			}
		}
		
		void Button_PrintManualClick(object sender, EventArgs e)
		{
			
		}
		
		void FormBarcodePrinterLoad(object sender, EventArgs e)
		{
			
		}
		
		void TextBox_CodeClick(object sender, EventArgs e)
		{
			(sender as TextBox).SelectAll();
		}
		
		void TextBox_CustomerCodeTextChanged(object sender, EventArgs e)
		{
			string sCustCode = (sender as TextBox).Text;
			DataRow[] rows = ViewCtrl.Data.Tables[DataViewBinder.TABLE_CUSTOMER].Select("Code like '" + sCustCode + "%'");
			if ((rows.Length == 1) &&
			    (sCustCode.Length >= 5)){
				//(sender as TextBox).Text = rows[0]["Code"].ToString();
				textBox_Customer.Text = rows[0]["Name"].ToString();
			}
		}
		
		void TextBox_textBox_OuterDiameterTextChanged(object sender, EventArgs e)
		{
			string sODValue = (sender as TextBox).Text;
			try{
				DataRow[] rows = ViewCtrl.Data.Tables[DataViewBinder.TABLE_OD].Select("OD_Value = " + sODValue + " and Prod_Code like '" + textBox_ProdCode.Text + "%'");
				comboBox_ODName.Items.Clear();
				foreach(DataRow row in rows){
					comboBox_ODName.Items.Add(row["OD_NAME"].ToString());
				}
			}catch(Exception ex){
				
			}
		}
		
		void TextBox_ProdCodeTextChanged(object sender, EventArgs e)
		{
			string sProdCode = (sender as TextBox).Text;
			DataRow[] rows = ViewCtrl.Data.Tables[DataViewBinder.TABLE_PRODUCT].Select("Prod_Code like '" + sProdCode + "%'");
			
			comboBox_ProdName.Items.Clear();
			_prodCodeList.Clear();
			foreach(DataRow row in rows){
				comboBox_ProdName.Items.Add(row["Prod_Name"].ToString());
				_prodCodeList.Add(row["Prod_Code"].ToString());
			}
		}
		
		void ComboBox_ProdNameSelectedIndexChanged(object sender, EventArgs e)
		{
			//textBox_ProdCode.Text = _prodCodeList[comboBox_ProdName.SelectedIndex];
			textBox_ProdName.Text = (sender as ComboBox).Text;
		}
		
		void TextBox_QuantityTextChanged(object sender, EventArgs e)
		{
			string sQty = textBox_Quantity.Text;
			string sQtyBnc = textBox_BunchCount.Text;
			int iQty = 0;
			int iQtyBnc = 0;
			
			if (sQty != "") iQty = Int32.Parse(sQty);
			if (sQtyBnc != "") iQtyBnc = Int32.Parse(sQtyBnc);
			
			label_TotalQuantity.Text = (iQty * iQtyBnc).ToString();
		}
		
		void ComboBox_ODNameSelectedIndexChanged(object sender, EventArgs e)
		{
			textBox_ODName.Text = (sender as ComboBox).Text;
		}
		
		void Button_BadClick(object sender, EventArgs e)
		{
			string sBadCode = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_BADCODE].Select());
			if (sBadCode == null || sBadCode == ""){
				DialogResult = DialogResult.None;
				return;
			}
			_viewData["BadCode"] = sBadCode;
			_viewData["BadQuantity"] = label_TotalQuantity.Text;
			_viewData["ProductCode"] = "";
			_viewData["OrderNo"] = DateTime.Now.ToString("yyMMdd") + "BD";
			_viewData["PO_Seq"] = "";
			_viewData["ProcessCode"] = "1E";
			_viewData["EquipCode"] = "";
			_viewData["Length"] = textBox_PlanLength.Text;
			
			DialogResult = DialogResult.Ignore;
		}
		
		void TextBox_ODNameTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox_ThicknessSelectedIndexChanged(object sender, EventArgs e)
		{
			textBox_Thickness.Text = (sender as ComboBox).Text;
		}
	}
}
