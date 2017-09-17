/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Pop
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
			this.taskOrderView_Label = new Artn.Ilhwa.View.Pop.TaskOrderView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel_TaskOrder = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// taskOrderView_Label
			// 
			this.taskOrderView_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.taskOrderView_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.taskOrderView_Label.Checked = false;
			this.taskOrderView_Label.Dock = System.Windows.Forms.DockStyle.Top;
			this.taskOrderView_Label.LabelMode = true;
			this.taskOrderView_Label.Location = new System.Drawing.Point(0, 0);
			this.taskOrderView_Label.Margin = new System.Windows.Forms.Padding(0);
			this.taskOrderView_Label.Name = "taskOrderView_Label";
			this.taskOrderView_Label.Size = new System.Drawing.Size(1240, 27);
			this.taskOrderView_Label.TabIndex = 0;
			this.taskOrderView_Label.ViewData = null;
			this.taskOrderView_Label.LabelAllChecked += new System.EventHandler(this.LabelAllChecked);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.flowLayoutPanel_TaskOrder);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1240, 486);
			this.panel1.TabIndex = 2;
			// 
			// flowLayoutPanel_TaskOrder
			// 
			this.flowLayoutPanel_TaskOrder.AutoSize = true;
			this.flowLayoutPanel_TaskOrder.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel_TaskOrder.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel_TaskOrder.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel_TaskOrder.Name = "flowLayoutPanel_TaskOrder";
			this.flowLayoutPanel_TaskOrder.Size = new System.Drawing.Size(1240, 0);
			this.flowLayoutPanel_TaskOrder.TabIndex = 2;
			// 
			// TaskOrderViewList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.taskOrderView_Label);
			this.Name = "TaskOrderViewList";
			this.Size = new System.Drawing.Size(1240, 513);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_TaskOrder;
		private Artn.Ilhwa.View.Pop.TaskOrderView taskOrderView_Label;
		
	}
}
