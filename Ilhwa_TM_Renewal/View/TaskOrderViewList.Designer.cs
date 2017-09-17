/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class TaskOrderViewList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.taskOrderView_Label = new Artn.Ilhwa.View.TaskOrderView();
			this.panel_ViewList = new System.Windows.Forms.Panel();
			this.taskOrderView2 = new Artn.Ilhwa.View.TaskOrderView();
			this.panel_ViewList.SuspendLayout();
			this.SuspendLayout();
			// 
			// taskOrderView_Label
			// 
			this.taskOrderView_Label.Checked = false;
			this.taskOrderView_Label.LabelMode = true;
			this.taskOrderView_Label.Location = new System.Drawing.Point(2, 2);
			this.taskOrderView_Label.Name = "taskOrderView_Label";
			this.taskOrderView_Label.Size = new System.Drawing.Size(993, 70);
			this.taskOrderView_Label.TabIndex = 0;
			this.taskOrderView_Label.ViewData = null;
			this.taskOrderView_Label.LabelAllChecked += new System.EventHandler(this.LabelAllChecked);
			// 
			// panel_ViewList
			// 
			this.panel_ViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panel_ViewList.AutoScroll = true;
			this.panel_ViewList.Controls.Add(this.taskOrderView2);
			this.panel_ViewList.Location = new System.Drawing.Point(0, 71);
			this.panel_ViewList.Name = "panel_ViewList";
			this.panel_ViewList.Size = new System.Drawing.Size(1004, 442);
			this.panel_ViewList.TabIndex = 2;
			// 
			// taskOrderView2
			// 
			this.taskOrderView2.AutoScroll = true;
			this.taskOrderView2.Checked = false;
			this.taskOrderView2.LabelMode = false;
			this.taskOrderView2.Location = new System.Drawing.Point(2, 0);
			this.taskOrderView2.Name = "taskOrderView2";
			this.taskOrderView2.Size = new System.Drawing.Size(993, 70);
			this.taskOrderView2.TabIndex = 2;
			this.taskOrderView2.ViewData = null;
			// 
			// TaskOrderViewList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_ViewList);
			this.Controls.Add(this.taskOrderView_Label);
			this.Name = "TaskOrderViewList";
			this.Size = new System.Drawing.Size(1004, 513);
			this.panel_ViewList.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel_ViewList;
		private Artn.Ilhwa.View.TaskOrderView taskOrderView2;
		private Artn.Ilhwa.View.TaskOrderView taskOrderView_Label;
	}
}
