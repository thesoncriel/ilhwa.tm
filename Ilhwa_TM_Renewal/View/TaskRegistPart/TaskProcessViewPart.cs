/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Controller;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of TaskProcessViewPart.
	/// </summary>
	public partial class TaskProcessViewPart : DataViewUserControl
	{
		public event EventHandler AddProdClick = null;
		protected void OnAddProdClick(object sender, EventArgs e){
			if (AddProdClick != null) AddProdClick(sender, e);
		}
		
		public event EventHandler WasteInsertClick = null;
		protected void OnWasteInsertClick(object sender, EventArgs e){
			if (WasteInsertClick != null) WasteInsertClick(sender, e);
		}
		
		public event EventHandler BadInsertClick = null;
		protected void OnBadInsertClick(object sender, EventArgs e){
			if (BadInsertClick != null) BadInsertClick(sender, e);
		}
		
		public TaskProcessViewPart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public override Theson.Common.IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set {
				if (value == null) return;
				
				ViewCtrl.BindingViewData(panel_Left, value);
				ViewCtrl.BindingViewData(panel_Right, value);

				base.ViewData = value;
				button_BadInsert.Visible = (value["ProcessCode"].StartsWith("2") == true);
				button_ProductAdd.Visible = (value["IsLastProc"] == "false");
			}
		}
		
		void Button_AddProdClick(object sender, EventArgs e)
		{
			OnAddProdClick(this, e);
		}
		
		void Button_WasteInsertClick(object sender, EventArgs e)
		{
			WasteInsertClick(this, e);
		}
		
		void Button_BadInsertClick(object sender, EventArgs e)
		{
			BadInsertClick(this, e);
		}
	}
}
