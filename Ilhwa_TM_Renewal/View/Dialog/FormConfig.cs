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
			textBox_ComNumber.Text = ViewCtrl.DBManager.Config["Barcode Printer", "ComNumber"];
			textBox_BaudRate.Text = ViewCtrl.DBManager.Config["Barcode Printer", "BaudRate"];
			comboBox_Printer.Text = (ViewCtrl.DBManager.Config["Other", "Printer"] == "true")? "예" : "아니오";
			comboBox_SpecCheckInterlock.Text = (ViewCtrl.DBManager.Config["Other", "SpecCheckInterlock"] == "true")? "예" : "아니오";
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
		
		void ComboBox_PrinterSelectedIndexChanged(object sender, EventArgs e)
		{
			ViewCtrl.DBManager.Config["Other","Printer"] = (comboBox_Printer.Text == "예")? "true" : "false";
		}
		
		void ComboBox_SpecCheckInterlockSelectedIndexChanged(object sender, EventArgs e)
		{
			ViewCtrl.DBManager.Config["Other","SpecCheckInterlock"] = (comboBox_SpecCheckInterlock.Text == "예")? "true" : "false";
		}
	}
}
