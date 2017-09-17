/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-23
 * Time: 오전 9:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of TaskProcessListForm.
	/// </summary>
	public partial class FormTaskProcessList : DataViewForm
	{		
		public FormTaskProcessList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void Button_GotoTaskOrderListClick(object sender, EventArgs e)
		{
			FormTaskOrderList frm = (MdiParent as MainForm).Form_TaskOrderList;
			taskOrderView_Data.ViewData.Clear();
			this.WindowState = FormWindowState.Minimized;
			frm.Show();
			frm.WindowState = FormWindowState.Maximized;
		}
		
		public override IMultiColumnRecordable ViewData {
			get {
				return taskOrderView_Data.ViewData;
			}
			set {
				taskOrderView_Data.ViewData = value;
				label_OrderNo.Text = value["OrderNo"];
				
				DataSet data = ViewCtrl.DBManager.ExecuteQuery(
					"table_select find_task_process", value);
				
				taskProcessViewList.ViewData = value;
				
				if (data.Tables[0].Rows.Count == 0){
					
					taskProcessViewList.CreateRows();
				}
				else{
					taskProcessViewList.SetData(data.Tables[0]);
				}
			}
		}
		
		public override void Refresh(){
			ViewData = ViewData;
		}
		
		void TaskProcessViewListItemSelected(object sender, IMultiColumnRecordable mcData)
		{
			FormTaskRegist frm = (MdiParent as MainForm).Form_TaskProcReg;
			frm.ViewData = mcData;
			this.WindowState = FormWindowState.Minimized;
			frm.Show();
			frm.Refresh();
			frm.WindowState = FormWindowState.Maximized;
		}
		
		void TaskProcessViewListLogMessage(object Sender, string msg)
		{
			OnLogMessage(Sender, msg);
		}
	}
}
