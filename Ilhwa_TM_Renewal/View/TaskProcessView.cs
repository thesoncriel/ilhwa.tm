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
	public partial class TaskProcessView : DataViewUserControl
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
				
				button_ProcessDetail.Text = value["ProcessCodeKor"];
				button_ProcessDetail.Enabled = (value["Status"] != "E"); // 12차 수정 진행 - 공정완료(E)면 버튼 비활성화 기능 추가 - 121019 by jhson
				// 12차 수정 진행 - 공정 선택 화면 변경 요청으로 삭제 함 - 121019 by jhson
//				if (value["IsFirstProc"] == "false"){
//					label_InsertedMaterialCount.Text = "";
//					return;
//				}
//				if (value["ProcessCode"] == "1A"){
//					label_InsertedMaterialCount.Text = AppendMatData(value["InsertedMaterialCount"], value["InsertedMaterialCode"]);
//				}
//				else{
//					label_InsertedMaterialCount.Text = AppendMatData(value["InsertedProductCount"], value["InsertedProductCode"]);
//				}
			}
		}
		
		protected string AppendMatData(string count, string code){
			return "횟수: " + count + " | 최근 투입: " + code;
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
