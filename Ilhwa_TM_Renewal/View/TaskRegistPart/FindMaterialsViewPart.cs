/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of TaskOrderViewPart.
	/// </summary>
	public partial class FindMaterialsViewPart : DataViewUserControl
	{
		private TaskType _taskType = TaskType.MaterialProdInfo;
		private IMultiColumnRecordable _viewData = null;

		public event StringTransEventHandler CodeChanged = null;
		protected void OnCodeChanged(object sender, string key, string value){
			if(CodeChanged != null) CodeChanged(sender, key, value);
		}
		
		public FindMaterialsViewPart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public override Theson.Common.IMultiColumnRecordable ViewData {
			get {
				if (textBox_Barcode.Text == "") return null;
				return _viewData;
			}
			set {
				if(value == null) return;
				
				foreach(System.Windows.Forms.Control lblCtrl in Controls){
					if (lblCtrl is Label) (lblCtrl as Label).Visible = false;
				}

				ViewCtrl.BindingViewLabelValue(this, value);
				
				_viewData = value;
				_taskType = (TaskType)TaskType.Parse(typeof(TaskType), value.GetType().Name);
			}
		}
		
		public TaskType TransformType{
			get{
				return _taskType;
			}
			set{
				try{
					ViewCtrl.BindingViewLabel(this, value.ToString());
					textBox_Barcode.Text = "";
				}
				catch(Exception){}
				_taskType = value;
			}
		}
		
		public void Clear(){ // MOD: 자재 등록 시 검색 내역 Clear - jhson 120907
			textBox_Barcode.Text = "";
			foreach(System.Windows.Forms.Control ctrl in Controls){
				if ((ctrl.Name.Contains("_Value") == true)) {
			    	ctrl.Text = "";
			    }
			}
		}
		
		void Button_FindBarcodeClick(object sender, EventArgs e)
		{
			FormNumberPad numPad = new FormNumberPad();
			
			if(numPad.ShowDialog() == DialogResult.OK){
				textBox_Barcode.Text = numPad.Value;
				
				OnCodeChanged(this, TransformType.ToString(), textBox_Barcode.Text);
			}
		}
		
		
		
		void TextBox_BarcodeClick(object sender, EventArgs e)
		{
			textBox_Barcode.SelectAll();
		}
		
		void TextBox_BarcodeTextChanged(object sender, EventArgs e)
		{
			string sValue = textBox_Barcode.Text;
			if (sValue.Contains("\r\n") == true){
				sValue = sValue.Substring(0, sValue.IndexOf("\r\n"));
				textBox_Barcode.Text = sValue;
			}
			OnCodeChanged(this, TransformType.ToString(), sValue);
		}
		
		
	}
}
