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
using Theson.Util;
using Artn.Ilhwa.View;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
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
			
			Form_TaskProcList = new FormTaskProcessList();
			Form_TaskOrderList = new FormTaskOrderList();
			Form_TaskProcReg = new FormTaskRegist();
			Form_Barcode = new FormBarcodeList();
			
			Form_TaskOrderList.MdiParent = this;
			Form_TaskProcList.MdiParent = this;
			Form_TaskProcReg.MdiParent = this;
			Form_Barcode.MdiParent = this;

			foreach(Form frm in MdiChildren){
				(frm as DataViewForm).ViewCtrl = ViewCtrl;
				(frm as DataViewForm).LogMessage += PrintLogMessage;
			}
			
			_activatedChild = Form_TaskOrderList;
		}
		
		public Form _activatedChild = null;
		public Form ActivatedChild{ get{ return _activatedChild; }}
		public FormTaskProcessList Form_TaskProcList = null;
		public FormTaskOrderList Form_TaskOrderList = null;
		public FormTaskRegist Form_TaskProcReg = null;
		public FormBarcodeList Form_Barcode = null;
		
		void PrintLogMessage(object sender, string msg){
			label_Notice.Text = msg;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			LoadConfig();
			Form_TaskProcList.Show();
			Form_TaskOrderList.Show();
			Form_TaskProcReg.Show();
			Form_Barcode.Show();
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
			Form_TaskOrderList.PrinterAbility = (ViewCtrl.DBManager.Config["Other", "Printer"] == "true");
			
			this.Text = "일화 스텐레스 - 공정현황등록 ver. " + Util.AppVersion + " (" + Util.BuildDate.ToString("yyyy-MM-dd HH:mm") + ")";
			
		}
		
		void Button_OtherProdEnterClick(object sender, EventArgs e)
		{
			ViewCtrl.Barcode.PrintOther();
		}
		
		void Button_RepublishClick(object sender, EventArgs e)
		{
			_activatedChild = ActiveMdiChild;
			_activatedChild.WindowState = FormWindowState.Minimized;
			Form_Barcode.Show();
			Form_Barcode.WindowState = FormWindowState.Maximized;
		}
	}
}
