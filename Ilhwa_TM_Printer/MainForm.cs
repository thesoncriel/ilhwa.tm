/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-20
 * Time: 오후 4:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.Controller.Barcode;
using Artn.Ilhwa.Controller;
using Artn.Ilhwa.View;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
using Artn.Ilhwa.View.Pop;
using Artn.Ilhwa.View.POP;
using Theson.Common;
using Theson.DBManager;
using Theson.Util.Config;

namespace Artn.Ilhwa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : DataViewForm
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			ViewCtrl = new DataViewController();
			ViewCtrl.LogMessage += PrintLogMessage;
			Form_TaskOrderList = new FormTaskOrderList();
			FormTest = new FormTaskCurrentList();
			
			FormTest.MdiParent = this;
			Form_TaskOrderList.MdiParent = this;
			
			foreach(Form frm in MdiChildren){
				(frm as DataViewForm).ViewCtrl = ViewCtrl;
				(frm as DataViewForm).LogMessage += PrintLogMessage;
			}
		}
		public FormTaskOrderList Form_TaskOrderList = null;
		public FormTaskCurrentList FormTest = null;
		
		void PrintLogMessage(object sender, string msg){
			label_Notice.Text = msg;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			LoadConfig();
			Form_TaskOrderList.Show();
			Form_TaskOrderList.WindowState = FormWindowState.Maximized;
		}
		
		void Button_ConfigClick(object sender, EventArgs e)
		{
			FormConfig frm = new FormConfig(ViewCtrl);
			
			if(frm.ShowDialog() == DialogResult.OK){
				LoadConfig();
				PrintLogMessage(this, "설정 변경을 완료 하였습니다.");
			}
			
			frm.MemberClear();
		}
		
		void LoadConfig(){
			
		}
		
		void Button_OtherProdEnterClick(object sender, EventArgs e)
		{
			ViewCtrl.Barcode.PrintOther();
		}
	}
}
