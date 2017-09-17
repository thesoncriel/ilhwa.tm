/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-25
 * Time: 오후 2:16
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
using Artn.Ilhwa.View.Dialog;
using Theson.Common;

namespace Artn.Ilhwa.View.TasRegistPart
{
	/// <summary>
	/// Description of InsertMaterialsViewPart.
	/// </summary>
	public partial class InputStatusListViewPart : DataViewUserControl, IDataViewList
	{
		public const int MOVE_PAGE_NUM = 2;
		private int _currPos = 0;
		private bool _next = false;
		private IMultiColumnRecordable _viewData = null;
		private int _selectedIndex = -1;
		
		private List<IMultiColumnRecordable> _materials = new List<IMultiColumnRecordable>();
		
		public event EventHandler InputListClick = null;
		protected void OnInputListClick(object sender, EventArgs e){
			if (InputListClick != null) InputListClick(sender, e);
		}

		public InputStatusListViewPart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public override IMultiColumnRecordable ViewData {
			get { return _viewData; }
			set { _viewData = value; }
		}
		
		public void SetData(DataTable data){
			DataRowCollection rows = data.Rows;
			
			IMultiColumnRecordable matData = null;
			
			_selectedIndex = -1;
			listView_InsertStatus.Items.Clear();
			_materials.Clear();
			label_Column1.Text = data.Columns[0].Caption;
			label_Column2.Text = data.Columns[1].Caption;
			label_Column3.Text = data.Columns[2].Caption;

			foreach(DataRow row in rows){
				AddData(row[0].ToString(),
				        row[1].ToString(),
				        row[2].ToString());
				
				matData = ViewCtrl.TaskRegist.CreateModel(row);
				ViewData.AddChild(matData);
				_materials.Insert(0, matData);
			}
		}
		public void SetData(List<IMultiColumnRecordable> dataList)
		{
			foreach(IMultiColumnRecordable data in dataList){
				AddData(data);
			}
		}
		// 12차 수정 진행 - 가장 최근에 투입된 자재를 이용하기에 삭제(외부 비공개) - 121019 by jhson
		protected IMultiColumnRecordable GetSelectedItem(){
			try{
				IMultiColumnRecordable data = _materials[_selectedIndex];
				return data;
			}
			catch(ArgumentOutOfRangeException){
				return null;
			}
		}
		// 12차 수정 진행 - 가장 최근에 투입된 자재를 이용하기에 삭제(외부 비공개) - 121019 by jhson
		protected bool IsSelectedItem(){
			return (GetSelectedItem() != null);
		}
		
		public bool ContainsBarcode(string barcode){
			foreach(IMultiColumnRecordable data in _materials){
				if(data["Barcode"] == barcode) return true;
			}
			return false;
		}
		
		public void AddData(IMultiColumnRecordable data){
			_materials.Insert(0, data);
			ViewData.AddChild(data);
			AddData(data["matCol1"], data["matCol2"], data["matCol3"]);
		}
		
		public void AddData(params string[] colData){
			ListViewItem item = new ListViewItem((listView_InsertStatus.Items.Count + 1).ToString());
			item.Font = new Font(new FontFamily("굴림"), 12);
			item.SubItems.Add(colData[0]);
			for(int i = 1; i < colData.Length; i++){
				try{
					item.SubItems.Add(string.Format("{0:0.#}", Double.Parse(colData[i])));
				}catch(FormatException){
					item.SubItems.Add(colData[i]);
				}
			}
			
			listView_InsertStatus.Items.Insert(0, item);
		}
		
		public int GetItemCount(){ return _materials.Count; }
		
		public bool HasContainsCode(IMultiColumnRecordable matData){
			foreach(IMultiColumnRecordable mat in _materials){
				if(matData["Barcode"] == mat["Barcode"]) return true;
			}
			return false;
		}
		// 12차 수정 진행 - 가장 최근에 투입된 자재 정보를 가져 온다. - 121019 by jhson
		public IMultiColumnRecordable GetLastInsertedItem(){
			if (this._materials.Count < 1) return null;
			
			return _materials[0];
		}

		void Button_MovePrevClick(object sender, EventArgs e)
		{
			if(_next == true){
				_currPos -= 1;
				_next = false;
			}
			
			_currPos -= MOVE_PAGE_NUM;
			
			if (_currPos < 0) _currPos = 0;
			listView_InsertStatus.EnsureVisible(_currPos);
		}
		
		void Button_MoveNextClick(object sender, EventArgs e)
		{
			if (_next == false) {
				_currPos += 1;
				_next = true;
			}
			
			_currPos += MOVE_PAGE_NUM;
			
			if (_currPos >= listView_InsertStatus.Items.Count) 
				_currPos = listView_InsertStatus.Items.Count - 1;
			
			if (_currPos < 0) return;
			
			listView_InsertStatus.EnsureVisible(_currPos);
		}
		
		void ListView_InsertStatusSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListView_InsertStatusItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected == true) _selectedIndex = e.ItemIndex;
		}
		
		void ListView_InsertStatusMouseUp(object sender, MouseEventArgs e)
		{
			OnInputListClick(this, new EventArgs());
		}
	}
}
