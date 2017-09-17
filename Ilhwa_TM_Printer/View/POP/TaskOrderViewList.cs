/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View.Pop
{
	/// <summary>
	/// Description of TaskOrderViewList.
	/// </summary>
	public partial class TaskOrderViewList : DataViewUserControl
	{
		private List<TaskOrderView> _dataViewList = new List<TaskOrderView>();
		private DataTable _data = null;
		private int _currRowNum = 0;
		private int _visibleRowCount = 0;

		public TaskOrderViewList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//panel_ViewList.Controls.Remove(taskOrderView2);
			AddRows(8);
		}
		
		public void AddRows(int rowCount){
			Clear();
			for(int i = 0; i < rowCount; i++){
				TaskOrderView toView = new TaskOrderView();
				//toView.Top = (panel_ViewList.Controls.Count * (toView.Height - 1));
				//toView.Left = 2;
				toView.ItemSelected += OnItemSelected;
				toView.LogMessage += OnLogMessage;
				//toView.Dock = DockStyle.Left & DockStyle.Top;
				flowLayoutPanel_TaskOrder.Controls.Add(toView);
				if(((i + 1) % 2) == 0) toView.BackColor = Color.LightYellow;
				
				_dataViewList.Add(toView);
			}
		}
		
		public void SetVisibleCount(int rowCount){
			int i = 0;
			
			for(; i < rowCount; i++){
				_dataViewList[i].Visible = true;
			}
			
			for(; i < _dataViewList.Count; i++){
				_dataViewList[i].Visible = false;
			}
			
			_visibleRowCount = rowCount;
		}
		
		public void Clear(){ 
			flowLayoutPanel_TaskOrder.Controls.Clear();
			_dataViewList.Clear();
		}
		
		public void SetData(DataTable data){
			if (data == null) return;
			
			_data = data;
			_currRowNum = 0;
			Clear();
			MoveNext();
			OnLogMessage(this, "검색이 완료 되었습니다: " + _dataViewList.Count + " 건");
		}
		
		public void MoveNext(){
			DataRowCollection rows = _data.Rows;
			int iCnt = 0;
			
			if (_data.Rows.Count == 0) SetVisibleCount(0);
			else{
				if (_currRowNum >= rows.Count) return;
				
				AddRows(rows.Count);
				for(int i = 0; i < _dataViewList.Count; i++){
					
					_dataViewList[i].ViewData = ViewCtrl.TaskOrder.CreateModel(rows[_currRowNum]);
					_currRowNum++;
					iCnt++;
					
					if (_currRowNum >= rows.Count) break;
				}
				
				SetVisibleCount(iCnt);
			}
		}
		
		public void MovePrev(){
			_currRowNum = _currRowNum - _dataViewList.Count - _visibleRowCount;
			
			if (_currRowNum < 0) _currRowNum = 0;
			
			MoveNext();
		}

		// CheckBox List 기능 추가 - 12.08.27 jhson
		protected void LabelAllChecked(object sender, EventArgs e){
			bool bChecked = (sender as CheckBox).Checked;
			
			foreach(TaskOrderView view in _dataViewList){
				view.Checked = bChecked;
			}
		}
		
		public List<IMultiColumnRecordable> GetSelectedList(){
			List<IMultiColumnRecordable> dataList = new List<IMultiColumnRecordable>();
			
			foreach(TaskOrderView view in _dataViewList){
				if(view.Checked == true){
					dataList.Add(view.ViewData);
				}
			}
			
			return dataList;
		}
		
		public List<TaskOrderView> GetSelectedViewList(){
			List<TaskOrderView> list = new List<TaskOrderView>();
			
			foreach(TaskOrderView view in _dataViewList){
				if(view.Checked == true){
					list.Add(view);
				}
			}
			return list;
		}
		
		public int GetViewCount(){ return _dataViewList.Count; }
	}
}
