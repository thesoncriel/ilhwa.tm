/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-23
 * Time: 오전 7:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of TaskProcessView.
	/// </summary>
	public partial class TaskProcessView : DataViewUserControl, IDataViewList
	{
		private bool _labelMode = false;

		public TaskProcessView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			LabelMode = false;
		}
		
		public override IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set { 
				base.ViewData = value; 
				
				if (value == null) return;
				
				if (value.Parent.FirstChild != value){
					label_InsertedMaterialCount.Text = "";
					return;
				}
				
				if (value["ProcessCode"] == "1A"){
					label_InsertedMaterialCount.Text = "횟수: " + 
						value["InsertedMaterialCount"] + " | 최근 투입: " +
						value["InsertedMaterialCode"];
				}
				else{
					label_InsertedMaterialCount.Text = "횟수: " + 
						value["InsertedProductCount"] + " | 최근 투입: " +
						value["InsertedProductCode"];
				}
			}
		}
		
		public bool LabelMode{
			get{
				return _labelMode;
			}
			set{
				_labelMode = value;
				
				foreach(System.Windows.Forms.Control ctrl in Controls){
					if (ctrl is Button) {
						ctrl.Visible = (value == false);
						continue;
					}
					
					ctrl.Font = new Font(ctrl.Font, 
					                     ((value) ? FontStyle.Bold: FontStyle.Regular)
					                    );
					ctrl.ForeColor = (value == true)? Color.White : Color.Black;
					ctrl.BackColor = (value == true)? Color.FromArgb(0x38, 0x5c, 0x6b) : Color.White;
				}
			}
		}
		
		private void Button_ProcessDetailClick(object sender, EventArgs e)
		{
			OnItemSelected(this, ViewData);
		}
	}
}
