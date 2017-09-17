/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-23
 * Time: 오전 7:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of TaskProcessListView.
	/// </summary>
	public partial class TaskProcessViewList : DataViewUserControl, IDataViewList
	{
		private List<TaskProcessView> _procViewList = new List<TaskProcessView>();

		public TaskProcessViewList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			Controls.Remove(taskProcessView2);
			Controls.Remove(taskProcessView3);
			AddRow(7);
		}
		
		public void CreateRows(){
			if (ViewData == null) return;
			
			SetData(ViewCtrl.TaskProcess.CreateModelList(ViewData));
		}

		protected void AddRow(){
			TaskProcessView tpView = new TaskProcessView();
			tpView.Top = (Controls.Count * (tpView.Height - 1)) + taskProcessView_Label.Top;
			tpView.Left = taskProcessView_Label.Left;
			tpView.ItemSelected += OnItemSelected;
			tpView.LogMessage += OnLogMessage;
			
			Controls.Add(tpView);
			_procViewList.Add(tpView);
		}
		protected void AddRow(int count){
			for(int i = 0; i < count; i++){
				AddRow();
			}
		}
		protected void ListItemAllVisible(bool visible){
			foreach(System.Windows.Forms.Control ctrl in Controls){
				if (ctrl == taskProcessView_Label) continue;
				
				ctrl.Visible = visible;
			}
		}
		
		public void SetData(DataTable data){
			SetData(ViewCtrl.TaskProcess.CreateModelList(ViewData, data));
		}
		
		public void SetData(List<IMultiColumnRecordable> viewDataList){
			ListItemAllVisible(false);
			
			for(int i = 0; i < viewDataList.Count; i++){
				_procViewList[i].Visible = true;
				_procViewList[i].ViewData = viewDataList[i];
			}
		}
	}
}
