///*
// * Created by SharpDevelop.
// * User: shakng
// * Date: 2013-06-04
// * Time: 오후 1:07
// * 
// * To change this template use Tools | Options | Coding | Edit Standard Headers.
// */
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;
//
//using Artn.Ilhwa.Model;
//using Artn.Ilhwa.View.Common;
//using Theson.Common;
//
//namespace Artn.Ilhwa.View.POP
//{
//	/// <summary>
//	/// Description of TaskCurrentViewList.
//	/// </summary>
//	public partial class TaskCurrentViewList : DataViewUserControl
//	{
//		private List<TaskCurrentView> _dataViewList = new List<TaskCurrentView>();
//		private DataTable _data = null;
//		private int _currRowNum = 0;
//		private int _visibleRowCount = 0;
//
//		public TaskCurrentViewList()
//		{
//			//
//			// The InitializeComponent() call is required for Windows Forms designer support.
//			//
//			InitializeComponent();
//
//			//panel_ViewList.Controls.Remove(taskOrderView2);
//			AddRows(8);
//		}
//		
//		public void AddRows(int rowCount){
//			Clear();
//			for(int i = 0; i < rowCount; i++){
//				TaskCurrentView tcView = new TaskCurrentView();
//				tcView.ItemSelected += OnItemSelected;
//				tcView.LogMessage += OnLogMessage;
//				flowLayoutPanel_TaskCurrent.Controls.Add(tcView);
//				if(((i + 1) % 2) == 0) tcView.BackColor = Color.LightYellow;
//				
//				_dataViewList.Add(tcView);
//			}
//		}
//		
//		public void SetVisibleCount(int rowCount){
//			int i = 0;
//			
//			for(; i < rowCount; i++){
//				_dataViewList[i].Visible = true;
//			}
//			
//			for(; i < _dataViewList.Count; i++){
//				_dataViewList[i].Visible = false;
//			}
//			
//			_visibleRowCount = rowCount;
//		}
//		
//		public void Clear(){ 
//			flowLayoutPanel_TaskCurrent.Controls.Clear();
//			_dataViewList.Clear();
//		}
//		
//		public void SetData(DataTable data){
//			if (data == null) return;
//			
//			_data = data;
//			_currRowNum = 0;
//			Clear();
//			MoveNext();
//			OnLogMessage(this, "검색이 완료 되었습니다: " + _dataViewList.Count + " 건");
//		}
//		
//		public void MoveNext(){
//			DataRowCollection rows = _data.Rows;
//			int iCnt = 0;
//			
//			if (_data.Rows.Count == 0) SetVisibleCount(0);
//			else{
//				if (_currRowNum >= rows.Count) return;
//				
//				AddRows(rows.Count);
//				for(int i = 0; i < _dataViewList.Count; i++){
//					
//					_dataViewList[i].ViewData = ViewCtrl.TaskCurrent.CreateModel(rows[_currRowNum]);
//					_currRowNum++;
//					iCnt++;
//					
//					if (_currRowNum >= rows.Count) break;
//				}
//				
//				SetVisibleCount(iCnt);
//			}
//		}
//		
//		public void MovePrev(){
//			_currRowNum = _currRowNum - _dataViewList.Count - _visibleRowCount;
//			
//			if (_currRowNum < 0) _currRowNum = 0;
//			
//			MoveNext();
//		}
//
//		public List<IMultiColumnRecordable> GetSelectedList(){
//			List<IMultiColumnRecordable> dataList = new List<IMultiColumnRecordable>();
//			
//			foreach(TaskCurrentView view in _dataViewList){
//				if(view.Checked == true){
//					dataList.Add(view.ViewData);
//				}
//			}
//			
//			return dataList;
//		}
//		
//		public List<TaskCurrentView> GetSelectedViewList(){
//			List<TaskCurrentView> list = new List<TaskCurrentView>();
//			
//			foreach(TaskCurrentView view in _dataViewList){
//				if(view.Checked == true){
//					list.Add(view);
//				}
//			}
//			return list;
//		}
//		
//		public int GetViewCount(){ return _dataViewList.Count; }
//
//	}
//}
