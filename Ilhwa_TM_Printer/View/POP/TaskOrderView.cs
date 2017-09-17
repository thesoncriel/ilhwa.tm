/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View.Pop
{
	/// <summary>
	/// Description of TaskOrderView.
	/// </summary>
	public partial class TaskOrderView : DataViewUserControl
	{
		private bool _labelMode = false;
		
		public event EventHandler LabelAllChecked;
		protected void OnLabelAllChecked(object sender, EventArgs e){
			if(LabelAllChecked != null) LabelAllChecked(sender, e);
		}
		
		public TaskOrderView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			LabelMode = false;
			
			foreach(System.Windows.Forms.Control ctrl in Controls){
				if (ctrl.Name.ToLower().Contains("check") == true) continue;
				ctrl.Click += TaskOrderViewClick;
			}
		}
		
		public override IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set { 
				base.ViewData = value;
				if (value == null) return;
				label_Customer.Tag = value["UseTypeCode"]; // 재고생산지시일 경우 작업지시 출력 시 거래처란에 '재고'로 표현 하기 - by jhson 121115
				//label_LengthPop.Text = label_LengthPop.Text.Replace("/", "\r\n");
			}
		}
		
		public override Color BackColor {
			get { return base.BackColor; }
			set { 
				foreach(System.Windows.Forms.Control ctrl in Controls){
					ctrl.BackColor = value;
				}
				base.BackColor = value;
			}
		}
		
		public bool LabelMode{
			get{
				return _labelMode;
			}
			set{
				_labelMode = value;
				
				foreach(System.Windows.Forms.Control ctrl in Controls){
					if (ctrl.Name.ToLower().Contains("check") == true) continue;
					ctrl.Font = new Font(ctrl.Font, 
					                     ((value) ? FontStyle.Regular: FontStyle.Regular)
					                    );
					//ctrl.ForeColor = (value == true)? Color.White : Color.Black;
					ctrl.BackColor = (value == true)? Color.FromArgb(0xcc, 0xcc, 0xcc) : Color.White;
					checkBox_AllCheck.Visible = value;
					checkBox_AllCheck.BackColor = Color.FromArgb(0xcc, 0xcc, 0xcc);
					checkBox_Check.Visible = (value == false);
				}
				base.BackColor = (value == true)? Color.FromArgb(0xcc, 0xcc, 0xcc) : Color.White;
			}
		}
		
		private void TaskOrderViewClick(object sender, EventArgs e)
		{
			OnItemSelected(this, ViewData);
		}

		
		// CheckBox List 기능 추가 - 12.08.27 jhson
		public bool Checked{
			get{
				return checkBox_Check.Checked;
			}
			set{
				checkBox_Check.Checked = value;
			}
		}
		
		public List<Control> GetControlList(){
			List<Control> list = new List<Control>();
			foreach(System.Windows.Forms.Control ctrl in Controls){
				list.Add(ctrl);
			}
			return list;
		}
	}
}
