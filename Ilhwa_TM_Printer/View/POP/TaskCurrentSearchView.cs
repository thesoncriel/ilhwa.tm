/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-06-05
 * Time: 오후 1:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Controller;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View.POP
{
	/// <summary>
	/// Description of TaskCurrentSearchView.
	/// </summary>
	public partial class TaskCurrentSearchView : DataViewUserControl
	{
		private IMultiColumnRecordable _viewData = null;
		public event EventHandler SearchClick = null;
		protected void OnSearchClick(object sender, EventArgs e){
			if (SearchClick != null) SearchClick(sender, e);
		}
		
		public TaskCurrentSearchView()
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
		
		void TaskCurrentSearchLoad(object sender, EventArgs e)
		{
			try{
				ViewData = ViewCtrl.TaskCurrent.CreateModel(null);
				ViewCtrl.BindListData(comboBox_OuterDiameterFrom,
				                      DataViewBinder.TABLE_SEL_ODVALUE, true);
				ViewCtrl.BindListData(comboBox_OuterDiameterTo,
				                      DataViewBinder.TABLE_SEL_ODVALUE, true);
				ViewCtrl.BindListData(comboBox_Quality,
				                      DataViewBinder.TABLE_SEL_QUAL, true);
				ViewCtrl.BindListData(comboBox_Spec,
				                      DataViewBinder.TABLE_SEL_SPEC, true);
			}
			catch(Exception ex){}
			
		}
		
		void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox cmbBox = sender as ComboBox;
			string sName = cmbBox.Name.Replace("comboBox_", "@p_");
			ViewData[sName] = cmbBox.SelectedValue.ToString();
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
//			
//			DataSet data = ViewCtrl.DBManager.ExecuteQuery("table_select task_current_select",ViewData);
//			DataTable table = data.Tables[0];
//			this.SearchResultGrid.DataSource = table;
//			foreach(DataGridViewColumn column in SearchResultGrid.Columns){
//			column.SortMode = DataGridViewColumnSortMode.NotSortable;
//			}
//			OnLogMessage(this, "검색이 완료 되었습니다.");	
			string[] saKey = {
				"OuterDiameterFrom"
			};
			string[] saKeyTo = {
				"OuterDiameterTo"
			};
			string[] saKeyStr = {
				"Spec",
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
			OnSearchClick(this, e);
		}
	}
}
