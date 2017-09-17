/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View
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
		
		public override Color BackColor {
			get { return base.BackColor; }
			set { 
				foreach(System.Windows.Forms.Control ctrl in Controls){
					ctrl.BackColor = value;
				}
			}
		}
		public override IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set { 
				base.ViewData = value;
				if (value != null && value["Qual"] == "201") BackColor = Color.Tomato;
				else if (value != null) BackColor = Color.White;
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
					                     ((value) ? FontStyle.Bold: FontStyle.Regular)
					                    );
					ctrl.ForeColor = (value == true)? Color.White : Color.Black;
					ctrl.BackColor = (value == true)? Color.FromArgb(0x38, 0x5c, 0x6b) : Color.White;
				}
				
				// CheckBox List 기능 추가 - 12.08.27 jhson
				checkBox_CheckAll.Visible = value;// CheckBox List 기능 추가 - 12.08.27 jhson
				checkBox_Check.Visible = !value;
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
		
		public bool CheckingAbility{
			get{
				return checkBox_Check.Visible || checkBox_CheckAll.Visible;
			}
			set{
				checkBox_Check.Visible = (LabelMode == false);
				checkBox_CheckAll.Visible = LabelMode;
				
				if (value == true){

				}
				else{
					checkBox_Check.Visible = value;
					checkBox_CheckAll.Visible = value;
				}
			}
		}
		
		void CheckBox_CheckAllCheckedChanged(object sender, EventArgs e)
		{
			if (CheckingAbility == false) return;
			
			OnLabelAllChecked(sender, e);
		}
	}
}
