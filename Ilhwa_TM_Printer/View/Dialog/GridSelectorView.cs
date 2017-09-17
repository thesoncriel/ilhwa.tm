/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오후 4:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Theson.Common;

namespace Artn.Ilhwa.View.Common
{
	/// <summary>
	/// Description of GridSelectorViewList.
	/// </summary>
	public partial class GridSelectorView : UserControl, IMemberClearable
	{
		private DataRow[] _data = null;
		private int _visibleRowCount = 0;
		private int _currRowNum = 0;
		private bool _keyValuePair = true;
		
		public event StringTransEventHandler OnItemSelected = null;
		private void OnItemSelected_Proc(object sender, string key, string value){
			if (OnItemSelected != null) OnItemSelected(sender, key, value);
		}
		
		public GridSelectorView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		public void SetData(DataRow[] data){
			_data = data;
			_currRowNum = 0;
			
			MoveNext();
		}
		
		public void MoveNext(){
			DataRow[] rows = _data;
			int iCnt = 0;
			string sCode, sName;
			
			if (_data.Length == 0) SetVisibleCount(0);
			else{
				if (_currRowNum >= rows.Length) return;
				
				for(int i = 0; i < tableLayoutPanel.Controls.Count; i++){
//					if (_keyValuePair == true){
//						tableLayoutPanel.Controls["button" + (i+1)].Text =
//							rows[_currRowNum][0].ToString() + "\r\n" +
//							rows[_currRowNum][1].ToString();
//					}
//					else{
//						tableLayoutPanel.Controls["button" + (i+1)].Text = rows[_currRowNum][0].ToString();
//					}
					sCode = rows[_currRowNum][0].ToString();
					sName = rows[_currRowNum][1].ToString();
					if (sCode != sName){
						tableLayoutPanel.Controls["button" + (i+1)].Text = sCode + "\r\n" + sName;
					}
					else{
						tableLayoutPanel.Controls["button" + (i+1)].Text = sCode;
					}
					
					_currRowNum++;
					iCnt++;
					
					if (_currRowNum >= rows.Length) break;
				}
				
				SetVisibleCount(iCnt);
			}
		}
		
		public void MovePrev(){
			_currRowNum = _currRowNum - tableLayoutPanel.Controls.Count - _visibleRowCount;
			
			if (_currRowNum < 0) _currRowNum = 0;
			
			MoveNext();
		}
		
		protected void SetVisibleCount(int rowCount){
			int i = 0;
			
			for(; i < rowCount; i++){
				tableLayoutPanel.Controls["button" + (i+1)].Visible = true;
			}
			
			for(; i < tableLayoutPanel.Controls.Count; i++){
				tableLayoutPanel.Controls["button" + (i+1)].Visible = false;
			}
			
			_visibleRowCount = rowCount;
		}
		
		public bool KeyValuePair{
			get{
				return _keyValuePair;
			}
			set{
				_keyValuePair = value;
			}
		}
		
		public void MemberClear(){
			_data = null;
			OnItemSelected = null;
		}
		
		void ButtonClick(object sender, EventArgs e)
		{
			string[] saKeyVal = null;
			
			saKeyVal = (sender as Button).Text.Split(new string[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
			
			if(saKeyVal.Length > 1){
				OnItemSelected_Proc(this, saKeyVal[0], saKeyVal[1]);
			}
			else{
				OnItemSelected_Proc(this, saKeyVal[0], saKeyVal[0]);
			}
		}
	}
}
