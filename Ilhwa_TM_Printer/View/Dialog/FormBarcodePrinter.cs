/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-31
 * Time: 오전 9:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
		
		public FormBarcodePrinter()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
					_viewData.Parent.Parent["TotalQuantity"] = (Int32.Parse(_viewData["Quantity"]) * Int32.Parse(_viewData["BunchCount"])).ToString();
				}
				catch(NullReferenceException){
					_viewData["TotalQuantity"] = (Int32.Parse(_viewData["Quantity"]) * Int32.Parse(_viewData["BunchCount"])).ToString();
				}
				return _viewData; 
			}
			set { 
				_viewData = value;
				ViewCtrl.BindingViewData(this, "textBox", value);
				
				if(_viewData.ContainsKey("IsRemain") == true){
					button_Print.Visible = true;
					button_PrintManual.Visible = false;
				}
				else if (_viewData.ContainsKey("OrderNo") == true) {
					button_Print.Visible = (ViewCtrl.Barcode.PrintHistory["History", _viewData["OrderNo"]] == "");
				}
			}
		}
		
		void TextBox_Click(object sender, EventArgs e)
		{
			TextBox txtBox = sender as TextBox;
			string sName = txtBox.Name.Replace("textBox_", "");
			_temp = txtBox.Text;
			
			if 		(sName == "Customer") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_CUSTOMER].Select());
			else if (sName == "ProdCode")		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_PRODUCT].Select());
			else if (sName == "ODName") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_OD].Select("Prod_Code = '" + textBox_ProdCode.Text + "'"));
			else if (sName == "Thickness") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_THICKNESS].Select("Prod_Code = '" + textBox_ProdCode.Text + "'"));
			else if (sName == "Worker") 		txtBox.Text = ShowGridSelector(ViewCtrl.Data.Tables[DataViewBinder.TABLE_WORKER].Select());
			else 								txtBox.Text = ShowNumberPad();
			
			if (sName == "ODName") textBox_OuterDiameter.Text = _gridValue;
			if (sName == "Customer") textBox_CustomerCode.Text = _gridValue;
			if (sName == "ProdCode"){
				textBox_ProdName.Text = _gridValue;
			}
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
			textBox_ODName.Text = ShowNumberPad();
		}
		
		void Button_ThkNumPadClick(object sender, EventArgs e)
		{
			textBox_Thickness.Text = ShowNumberPad();
		}
		
		void Button_PrintClick(object sender, EventArgs e)
		{
//			ViewBinder.DBManager.ExecuteNonQuery(
//				"procedure_insert TM_BC_INSERT_Etc_Prod_Enter",
				
		}
		
		void Button_PrintManualClick(object sender, EventArgs e)
		{
			
		}
		
		void FormBarcodePrinterLoad(object sender, EventArgs e)
		{
			
		}
	}
}
