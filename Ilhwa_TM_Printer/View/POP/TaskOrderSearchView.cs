/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-22
 * Time: 오후 4:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Controller;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.TasRegistPart;
using Theson.Common;

namespace Artn.Ilhwa.View.POP
{
	/// <summary>
	/// Description of TaskOrderSearch.
	/// </summary>
	public partial class TaskOrderSearchView : DataViewUserControl
	{
		private IMultiColumnRecordable _viewData = null;
		
		public event EventHandler SearchClick = null;
		protected void OnSearchClick(object sender, EventArgs e){
			if (SearchClick != null) SearchClick(sender, e);
		}
		public event EventHandler PrintClick = null;
		protected void OnPrintClick(object sender, EventArgs e){
			if (PrintClick != null) PrintClick(sender, e);
		}
		
		public TaskOrderSearchView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		
		public override IMultiColumnRecordable ViewData {
			get { return _viewData; }
			set { 
				if (value == null) return;
				_viewData = value; 
			}
		}
		
		void TaskOrderSearchLoad(object sender, EventArgs e)
		{
			try{
				ViewData = ViewCtrl.TaskOrder.CreateModel(null);
				ViewCtrl.BindListData(comboBox_OuterDiameterFrom,
				                      DataViewBinder.TABLE_SEL_ODVALUE, true);
				ViewCtrl.BindListData(comboBox_OuterDiameterTo,
				                      DataViewBinder.TABLE_SEL_ODVALUE, true);
				ViewCtrl.BindListData(comboBox_Quality,
				                      DataViewBinder.TABLE_SEL_QUAL, true);
				ViewCtrl.BindListData(comboBox_ProdCode,
				                      DataViewBinder.TABLE_SEL_SPEC, true);
				ViewCtrl.BindListData(comboBox_ThicknessFrom,
				                      DataViewBinder.TABLE_SEL_THK, true);
				ViewCtrl.BindListData(comboBox_ThicknessTo,
				                      DataViewBinder.TABLE_SEL_THK, true);
				foreach(System.Windows.Forms.Control ctrl in Controls){
					if (ctrl is DateTimePicker){
						if (ctrl.Name.EndsWith("From") == true){
							(ctrl as DateTimePicker).Value = DateTime.Now;
						}
						else{
							(ctrl as DateTimePicker).Value = DateTime.Now.AddDays(30);//.ToString("yyyy-MM-dd");
						}
					}
				}
				
				ViewData["Published"] = "";
				ViewData["Customer"] = "";
				ViewData["OrderNo"] = "";
				ViewData["EquipCode"] = "";
				ViewData["LengthFrom"] = "0";
				ViewData["LengthTo"] = "0";
			}
			catch(Exception ex){}
			
		}
		
		
		void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			DateTimePicker dtp = sender as DateTimePicker;
			string sName = dtp.Name.Replace("dateTimePicker_", "");
			ViewData[sName] = dtp.Value.ToString("yyyy-MM-dd");
		}
		
		void RadioButton_PublishedCheckedChanged(object sender, EventArgs e)
		{
			RadioButton radBtn = sender as RadioButton;
			
			if (radBtn.Checked == false) return;

			string sLabel = radBtn.Text;
			string sValue = "A";
			
			if (sLabel == "발행") sValue = "Y";
			else if (sLabel == "미발행") sValue = "N";
			
			ViewData["Published"] = sValue;
		}
		
		void CheckBox_DateUseCheckedChanged(object sender, EventArgs e)
		{
			CheckBox chkbox = sender as CheckBox;
			string sName = chkbox.Name.Replace("checkBox_", "").Replace("Use", "");
			Controls["dateTimePicker_" + sName + "From"].Enabled = chkbox.Checked;
			Controls["dateTimePicker_" + sName + "To"].Enabled = chkbox.Checked;
			
			if (chkbox.Checked == false){
				ViewData[sName + "From"] = "1900-01-01";
				ViewData[sName + "To"] = "2812-12-31";
			}
			else{
				ViewData[sName + "From"] = (Controls["dateTimePicker_" + sName + "From"] as DateTimePicker).Value.ToString("yyyy-MM-dd");
				ViewData[sName + "To"] = (Controls["dateTimePicker_" + sName + "To"] as DateTimePicker).Value.ToString("yyyy-MM-dd");
			}
		}
		
		void TextBox_EquipCodeClick(object sender, EventArgs e)
		{
			FormEquipChange frm = new FormEquipChange();
			frm.SetCurrEquipCode("");
			frm.SetData(ViewCtrl.Data.Tables["table_select find_equipment"]);
			
			if (frm.ShowDialog() == DialogResult.OK){
				(sender as TextBox).Text = frm.GetSelectedEquipCode();
			}
		}
		
		void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox cmbBox = sender as ComboBox;
			string sName = cmbBox.Name.Replace("comboBox_", "");
			ViewData[sName] = cmbBox.SelectedValue.ToString();
			if (ViewData[sName] == "전체") ViewData[sName] = "";
		}
		
		void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox txtBox = sender as TextBox;
			string sName = txtBox.Name.Replace("textBox_", "");
			ViewData[sName] = txtBox.Text;
			if (ViewData[sName] == "전체") ViewData[sName] = "";
		}
		
		void Button_SearchClick(object sender, EventArgs e)
		{
			string[] saKey = {
				"LengthFrom",
				"ThicknessFrom",
				"OuterDiameterFrom",
			};
			string[] saKeyTo = {
				"LengthTo",
				"ThicknessTo",
				"OuterDiameterTo"
			};
			string[] saKeyStr = {
				"ProdCode",
				"Quality"
			};
			foreach(string key in saKey){
				if (ViewData[key] == "" || ViewData[key].Contains("전체")) ViewData[key] = "0";
			}
			foreach(string key in saKeyTo){
				if (ViewData[key] == "" || ViewData[key].Contains("전체")) ViewData[key] = "1000";
			}
			foreach(string key in saKeyStr){
				if (ViewData[key].Contains("전체")) ViewData[key] = "";
			}
			if (ViewData["LengthTo"] == "" || ViewData["LengthTo"] == "0") ViewData["LengthTo"] = "100000";
			if (ViewData["Published"] == "") ViewData["Published"] = "N";
			
			OnSearchClick(this, e);
		}
		
		void Button_PrintClick(object sender, EventArgs e)
		{
			OnPrintClick(this, e);
		}
	}
}
