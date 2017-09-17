/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-09-26
 * Time: 오후 1:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.TasRegistPart;
using Theson.Common;

namespace Artn.Ilhwa.View.Dialog
{
	/// <summary>
	/// Description of FormSearchOption.
	/// </summary>
	public partial class FormSearchOption : DataViewForm
	{
		private IMultiColumnRecordable _viewData = null;
		private SearchType _transform = SearchType.TaskOrderList;
		
		public FormSearchOption()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			Transform = SearchType.TaskOrderList;
		}
		
		public override Theson.Common.IMultiColumnRecordable ViewData {
			get { return _viewData; }
			set { _viewData = value; }
		}
		
		public SearchType Transform{
			get { return _transform; }
			set {
				bool isTaskOrder = (value == SearchType.TaskOrderList);
				label2.Text = (isTaskOrder)? "호기별" : "SPEC";
				label3.Text = (isTaskOrder)? "외경" : "호칭경";
				label6.Text = (isTaskOrder)? "강종" : "수량";
				
				textBox_EquipCode.Visible = isTaskOrder;
				textBox_ProdCode.Visible = !isTaskOrder;
				
				textBox_OuterDiameter.Visible = isTaskOrder;
				textBox_ODName.Visible = !isTaskOrder;
				
				textBox_Qual.Visible = isTaskOrder;
				textBox_Quantity.Visible = !isTaskOrder;
				
				label7.Visible = isTaskOrder;
				comboBox_Status.Visible = isTaskOrder;
				
				_transform = value;
			}
		}
		
		void TextBox_EquipCodeClick(object sender, EventArgs e)
		{
			FormEquipChange frm = new FormEquipChange();
			frm.SetData(ViewCtrl.Data.Tables["table_select find_equipment"]);
			
			if(frm.ShowDialog() == DialogResult.OK){
				(sender as TextBox).Text = frm.GetSelectedEquipCode();
			}
			DialogResult = DialogResult.None;
			frm.MemberClear();
		}
		
		void TextBox_Click(object sender, EventArgs e)
		{
			FormNumberPad pad = new FormNumberPad();
			
			if (pad.ShowDialog() == DialogResult.OK){
				(sender as TextBox).Text = pad.Value;
			}
			DialogResult = DialogResult.None;
		}
		
		void TextBox_TextChanged(object sender, EventArgs e)
		{
			string sName = (sender as TextBox).Name.Replace("textBox_", "");
			ViewData[sName] = (sender as TextBox).Text;
		}
		
		void FormSearchOptionLoad(object sender, EventArgs e)
		{
			_viewData = new TaskOrder(null, null);

			dateTimePicker_OrderDateFrom.Value = DateTime.Now;
			dateTimePicker_OrderDateTo.Value = DateTime.Now;
			_viewData["EquipCode"] = "";
			_viewData["OuterDiameter"] = "0";
			_viewData["Length"] = "0";
			_viewData["Thickness"] = "0";
			_viewData["Qual"] = "0";
			_viewData["Status"] = "";
			_viewData["Quantity"] = "1";
			_viewData["ProdCode"] = "";
			_viewData["ODName"] = "";
		}
		
		void DateTimePicker_OrderDateValueChanged(object sender, EventArgs e)
		{
			string sName = (sender as DateTimePicker).Name.Replace("dateTimePicker_", "");
			ViewData[sName] = (sender as DateTimePicker).Value.ToString("yyyy-MM-dd");
		}
		
		void ComboBox_StatusSelectedIndexChanged(object sender, EventArgs e)
		{
			string sValue = (sender as ComboBox).Text;
			string sStatusCode = "";
			
			if (sValue == "" || sValue == "모두"){
				sStatusCode = "";
			}
			else if (sValue == "지시대기"){
				sStatusCode = "A";
			}
			else if (sValue == "생산중"){
				sStatusCode = "I";
			}
			else if (sValue == "생산중지"){
				sStatusCode = "W";
			}
			else if (sValue == "지시취소"){
				sStatusCode = "X";
			}
			else if (sValue == "주문취소"){
				sStatusCode = "C";
			}
			else{
				sStatusCode = "E";
			}
			
			ViewData["Status"] = sStatusCode;
		}
	}
}
