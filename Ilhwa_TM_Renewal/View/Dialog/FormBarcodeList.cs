/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-11-29
 * Time: 오후 9:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View.Dialog
{
	/// <summary>
	/// Description of FormBarcodeList.
	/// </summary>
	public partial class FormBarcodeList : DataViewForm
	{
		public const int MOVE_PAGE_NUM = 8;
		private int _currPos = 0;
		private bool _next = false;
		private List<IMultiColumnRecordable> _matList = new List<IMultiColumnRecordable>();
		
		public FormBarcodeList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Clear();
		}
		
		public void SetData(List<IMultiColumnRecordable> data){
			Clear();
			_matList = data;
			
			foreach(IMultiColumnRecordable matData in _matList){
				AddData(matData);
			}
		}
		public void AddData(params string[] colData){
			ListViewItem item = new ListViewItem(colData);
			item.Font = new Font(new FontFamily("굴림"), 12, FontStyle.Bold, GraphicsUnit.Point);
			
			listView_BarcodeList.Items.Add(item);
		}
		public void AddData(IMultiColumnRecordable data){
			AddData(
				data["ProductCode"],
				data["Customer"],
				data["ProdName"],
				data["ODName"],
				data["OuterDiameter"],
				data["Thickness"],
				data["Length"],
				data["TotalQuantity"],
				data["Quantity"]
			);
		}
		public void Clear(){
			listView_BarcodeList.Items.Clear();
			_matList.Clear();
		}
		public void SelectAll(bool selected){
			foreach(ListViewItem item in listView_BarcodeList.Items){
				item.Checked = selected;
			}
		}
		
		void Button_MovePrevClick(object sender, EventArgs e)
		{
			if(_next == true){
				_currPos -= 7;
				_next = false;
			}
			
			_currPos -= MOVE_PAGE_NUM;
			
			if (_currPos < 0) _currPos = 0;
			listView_BarcodeList.EnsureVisible(_currPos);
		}
		
		void Button_MoveNextClick(object sender, EventArgs e)
		{
			if (_next == false) {
				_currPos += 7;
				_next = true;
			}
			
			_currPos += MOVE_PAGE_NUM;
			
			if (_currPos >= listView_BarcodeList.Items.Count){
				_currPos = listView_BarcodeList.Items.Count - 1;
			}
			
			if (_currPos < 0) return;
			
			listView_BarcodeList.EnsureVisible(_currPos);
		}
		
		void Button_SelectAllClick(object sender, EventArgs e)
		{
			SelectAll(true);
		}
		
		void Button_DeselectAllClick(object sender, EventArgs e)
		{
			SelectAll(false);
		}
		
		void Button_PrintClick(object sender, EventArgs e)
		{
			List<IMultiColumnRecordable> selectedData = new List<IMultiColumnRecordable>();

			foreach(int index in listView_BarcodeList.CheckedIndices){
				selectedData.Add(_matList[index]);
			}
			
			ViewCtrl.Barcode.PrintRepublish(selectedData);
		}
		
		void FormBarcodeListLoad(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
		
		void Button_CloseClick(object sender, EventArgs e)
		{
			Form frm = (MdiParent as MainForm).ActivatedChild;
			this.WindowState = FormWindowState.Minimized;
			frm.Show();
			frm.WindowState = FormWindowState.Maximized;
		}
		
		void Button_SearchClick(object sender, EventArgs e)
		{
			FormSearchOption frm = new FormSearchOption();
			frm.ViewCtrl = this.ViewCtrl;
			frm.Transform = SearchType.BarcodeList;
			
			if (frm.ShowDialog() == DialogResult.OK){
				SetData(ViewCtrl.Barcode.FindBarcodeList(frm.ViewData));
			}
			
			frm.MemberClear();
			OnLogMessage(this, "바코드 검색이 완료 되었습니다.");
		}
	}
}
