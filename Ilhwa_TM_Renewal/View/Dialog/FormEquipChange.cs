/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오후 12:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Theson.Common;

namespace Artn.Ilhwa.View.TasRegistPart
{
	/// <summary>
	/// Description of FormEquipChange.
	/// </summary>
	public partial class FormEquipChange : Form, IMemberClearable
	{
		public const int MOVE_PAGE_NUM = 8;
		private int _currPos = 0;
		private bool _next = false;
		private DataTable _data = null;
		
		public FormEquipChange()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		// 기준정보로 불러올 것. (딱 한번만 수행 하자.)
		public void SetData(DataTable data){
			_data = data;
			SetData(_data.Select("Eq_Code like 'C%'"));
		}
		public void SetData(DataRow[] data){
			ListViewItem item = null;
			listView_NextEquipCode.Items.Clear();
			
			foreach(DataRow row in data){
				item = new ListViewItem((row[0].ToString()));
				item.SubItems.Add(row[1].ToString());
				listView_NextEquipCode.Items.Add(item);
			}
		}
		
		public void SetCurrEquipCode(string equipCode){
			label_CurrEquipCode.Text = equipCode;
		}
		
		public string GetSelectedEquipCode(){
			return listView_NextEquipCode.SelectedItems[0].Text;
		}
		
		void Button_MovePrevClick(object sender, EventArgs e)
		{
			if(_next == true){
				_currPos -= 7;
				_next = false;
			}
			
			_currPos -= MOVE_PAGE_NUM;
			
			if (_currPos < 0) _currPos = 0;
			listView_NextEquipCode.EnsureVisible(_currPos);
		}
		
		void Button_MoveNextClick(object sender, EventArgs e)
		{
			if (_next == false) {
				_currPos += 7;
				_next = true;
			}
			
			_currPos += MOVE_PAGE_NUM;
			
			if (_currPos >= listView_NextEquipCode.Items.Count) 
				_currPos = listView_NextEquipCode.Items.Count - 1;
			
			listView_NextEquipCode.EnsureVisible(_currPos);
		}
		
		void RadioButton_TypeCheckedChanged(object sender, EventArgs e)
		{
			RadioButton chkbox = sender as RadioButton;
			string sName = chkbox.Name.Replace("radioButton_Type", "");
			if (sName == "A"){
				SetData(_data.Select("Eq_Code like 'C%'"));
			}
			else{
				SetData(_data.Select("Eq_Code not like 'C%'"));
			}
		}
		
		public void MemberClear()
		{
			_data = null;
		}
	}
}
