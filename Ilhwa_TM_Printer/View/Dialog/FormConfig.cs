/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-31
 * Time: 오전 6:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.Controller;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of FormConfig.
	/// </summary>
	public partial class FormConfig : DataViewForm
	{
		public FormConfig(DataViewController viewCtrl)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			ViewCtrl = viewCtrl;
			
			textBox_IP.Text = ViewCtrl.DBManager.Config["Database Server", "IP"];
			comboBox_PrinterPreview.Text = (ViewCtrl.DBManager.Config["Other", "PrinterPreview"] == "true")? "예" : "아니오";
		}
		
		void TextBox_Click(object sender, EventArgs e)
		{
			TextBox txtBox = sender as TextBox;
			
			FormNumberPad numPad = new FormNumberPad();
			
			if (numPad.ShowDialog() == DialogResult.OK){
				txtBox.Text = numPad.Value;
				ViewCtrl.DBManager
					.Config[txtBox.Parent.Text, 
					        txtBox.Name.Replace("textBox_", "")] = txtBox.Text;
			}
		}
		
		void ComboBox_PrinterPreviewSelectedIndexChanged(object sender, EventArgs e)
		{
			ViewCtrl.DBManager.Config["Other","PrinterPreview"] = (comboBox_PrinterPreview.Text == "예")? "true" : "false";
		}
	}
}
