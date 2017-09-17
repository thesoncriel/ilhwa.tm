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

namespace Artn.Ilhwa.View.TasRegistPart
{
	/// <summary>
	/// Description of FormEquipChange.
	/// </summary>
	public partial class FormEquipChange : Form
	{
		public const int MOVE_PAGE_NUM = 8;
		private int _currPos = 0;
		private bool _next = false;
		
		public FormEquipChange()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		// 기준정보로 불러올 것. (딱 한번만 수행 하자.)
		public void SetData(DataTable data){
			ListViewItem item = null;
			listView_NextEquipCode.Items.Clear();
			
			foreach(DataRow row in data.Rows){
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
	}
}
