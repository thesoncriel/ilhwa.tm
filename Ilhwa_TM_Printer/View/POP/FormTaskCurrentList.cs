/*
 * Created by SharpDevelop.
 * User: shkang
 * Date: 2013-06-04
 * Time: 오후 2:58
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

namespace Artn.Ilhwa.View.POP
{
	/// <summary>
	/// Description of FormTaskCurrentList.
	/// </summary>
	public partial class FormTaskCurrentList : DataViewForm
	{
		TaskCurrentController TCC = new TaskCurrentController();
		private String sDate = DateTime.Now.ToString("yyyy-MM-dd");

		public FormTaskCurrentList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void SearchBtnClick(object sender, EventArgs e)
		{
//			string[] saKey = {
//				"@p_OuterDiameterFrom"
//			};
//			string[] saKeyTo = {
//				"@p_OuterDiameterTo"
//			};
//			string[] saKeyStr = {
//				"@p_Spec",
//				"@p_Quality"
//			};
//			foreach(string key in saKey){
//				if (ViewData[key] == "" || ViewData[key].Contains("전체"))ViewData[key] = "0";
//			}
//			foreach(string key in saKeyTo){
//				if (ViewData[key] == "" || ViewData[key].Contains("전체")) ViewData[key] = "1000";
//			}
//			foreach(string key in saKeyStr){
//				if (ViewData[key].Contains("전체")) ViewData[key] = "";
//			}
			
			//TCC.InsertData();
			(sender as Button).Enabled = false;//버튼 사용 안되게 바꿈
			DataSet data = ViewCtrl.DBManager.ExecuteQuery("table_insert task_current_insert","@p_Date", sDate);
			DataTable table = data.Tables["table_insert task_current_insert"];
			this.SearchResultGrid.DataSource = table;
			
			data = ViewCtrl.DBManager.ExecuteQuery("table_select task_current_select","", "");
			table = data.Tables[0];
			this.SearchResultGrid.DataSource = table;
			foreach(DataGridViewColumn column in SearchResultGrid.Columns){
			column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
			OnLogMessage(this, "검색이 완료 되었습니다.");	
			(sender as Button).Enabled = true;
			//this.dataGrid1.
		}
		
		void GotoBackBtnClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			((MainForm)this.MdiParent).Form_TaskOrderList.Show();
			((MainForm)this.MdiParent).Form_TaskOrderList.Refresh();
			((MainForm)this.MdiParent).Form_TaskOrderList.WindowState = FormWindowState.Maximized;
		}
	}
}
