/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:18
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
	/// Description of FindMaterialsViewPart.
	/// </summary>
	public partial class TaskOrderViewPart : DataViewUserControl
	{
		public TaskOrderViewPart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public override Theson.Common.IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set {
				if(value == null) return;
				
				base.ViewData = value;
				label_EquipCode.Text = value["EquipCode"];
				ViewCtrl.BindingViewData(panel_Left, value as IMultiColumnRecordable);
				ViewCtrl.BindingViewData(panel_Right, value as IMultiColumnRecordable);
			}
		}
		
		void Button_EquipChangeClick(object sender, EventArgs e)
		{
			if(ViewCtrl.TaskRegist.ChangeEquip(ViewData) == true){
				label_EquipCode.Text = ViewData["EquipCode"];
			}
		}
		
		void Button_WorkerChangeClick(object sender, EventArgs e)
		{
			if (ViewCtrl.TaskRegist.ChangeWorker(ViewData) == true){
				label_Worker.Text = ViewData["Worker"];
			}
		}
	}
}
