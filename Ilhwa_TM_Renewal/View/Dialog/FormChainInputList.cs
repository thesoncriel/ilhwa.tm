/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-11-22
 * Time: 오후 2:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View.Dialog
{
	/// <summary>
	/// Description of FormChainInputList.
	/// </summary>
	public partial class FormChainInputList : DataViewForm, IMemberClearable
	{
		public const int MOVE_PAGE_NUM = 8;
		private int _currPos = 0;
		private bool _next = false;
		private List<IMultiColumnRecordable> _matList = new List<IMultiColumnRecordable>();
		
		public FormChainInputList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

			listView_InputList.Items.Clear();
		}

		public override IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set { 
				base.ViewData = value;
				label_TotalQuantity.Text = "0";
			}
		}
		
		public IMultiColumnRecordable FindMaterials(TaskProcess taskProc, string key, string value)
		{
			return ViewCtrl.TaskRegist.SearchMaterial(taskProc, key, value);
		}
		
		public void AddData(IMultiColumnRecordable data){
			if (data == null) return;
			if (IsContainsItem(data) == true) return;
			if (ViewCtrl.TaskRegist.CheckMaterialSpec(ViewData, data) == false) return;
			
			ListViewItem item = new ListViewItem(data["Barcode"]);
			item.Font = new Font(new FontFamily("굴림"), 12);
			item.SubItems.Add(data["Quantity"]);

			listView_InputList.Items.Add(item);
			_matList.Add(data);
			
			label_TotalQuantity.Text = (Int32.Parse(label_TotalQuantity.Text) + Int32.Parse(data["Quantity"])).ToString();
		}
		
		public void FillDataToDataViewList(IDataViewList dvList){
			dvList.SetData(_matList);
			
			foreach(IMultiColumnRecordable matData in _matList){
				ViewCtrl.TaskRegist.InsertMaterial(matData);
			}
		}
		
		public bool IsContainsItem(IMultiColumnRecordable data){
			bool bRet = false;
			
			foreach(IMultiColumnRecordable matData in _matList){
				if (matData["Barcode"] == data["Barcode"]){
					bRet = true;
					break;
				}
			}
			
			if (bRet == true){
				MsgBox.Show("오류", "해당 자재는 이미 목록에 포함 되어 있습니다.");
			}
			return bRet;
		}
		
		void Button_MovePrevClick(object sender, EventArgs e)
		{
			if(_next == true){
				_currPos -= 7;
				_next = false;
			}
			
			_currPos -= MOVE_PAGE_NUM;
			
			if (_currPos < 0) _currPos = 0;
			listView_InputList.EnsureVisible(_currPos);
		}
		
		void Button_MoveNextClick(object sender, EventArgs e)
		{
			if (_next == false) {
				_currPos += 7;
				_next = true;
			}
			
			_currPos += MOVE_PAGE_NUM;
			
			if (_currPos >= listView_InputList.Items.Count) 
				_currPos = listView_InputList.Items.Count - 1;
			
			listView_InputList.EnsureVisible(_currPos);
		}
		
		void TextBox_InputBarcodeTextChanged(object sender, EventArgs e)
		{
			string sValue = textBox_InputBarcode.Text;
			if (sValue == "") return;
			if (sValue.Length < 24) return;
			
			if (sValue.Contains("\r\n") == true){
				sValue = sValue.Substring(0, sValue.IndexOf("\r\n"));
				textBox_InputBarcode.Text = sValue;
				return;
			}
			
			AddData(FindMaterials(ViewData as TaskProcess, "MaterialProdInfo", textBox_InputBarcode.Text));
			textBox_InputBarcode.Text = "";
			//textBox_InputBarcode.SelectAll();
			textBox_InputBarcode.Focus();
		}
		
		void Button_OKClick(object sender, EventArgs e)
		{
			if (MsgBox.ShowDialog("확인", "이 내용대로 자재를 투입 하시겠습니까?") != DialogResult.OK){
				this.DialogResult = DialogResult.None;
			}
		}
		
		void TextBox_InputBarcodeClick(object sender, EventArgs e)
		{
			(sender as TextBox).SelectAll();
		}
	}
}
