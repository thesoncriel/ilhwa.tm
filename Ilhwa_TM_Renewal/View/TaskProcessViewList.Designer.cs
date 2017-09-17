/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-23
 * Time: 오전 7:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class TaskProcessViewList
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
			this.taskProcessView_Label = new Artn.Ilhwa.View.TaskProcessView();
			this.taskProcessView2 = new Artn.Ilhwa.View.TaskProcessView();
			this.taskProcessView3 = new Artn.Ilhwa.View.TaskProcessView();
			this.SuspendLayout();
			// 
			// taskProcessView_Label
			// 
			this.taskProcessView_Label.LabelMode = true;
			this.taskProcessView_Label.Location = new System.Drawing.Point(2, 2);
			this.taskProcessView_Label.Name = "taskProcessView_Label";
			this.taskProcessView_Label.Size = new System.Drawing.Size(1018, 55);
			this.taskProcessView_Label.TabIndex = 0;
			this.taskProcessView_Label.ViewData = null;
			// 
			// taskProcessView2
			// 
			this.taskProcessView2.LabelMode = false;
			this.taskProcessView2.Location = new System.Drawing.Point(2, 57);
			this.taskProcessView2.Name = "taskProcessView2";
			this.taskProcessView2.Size = new System.Drawing.Size(1024, 55);
			this.taskProcessView2.TabIndex = 1;
			this.taskProcessView2.ViewData = null;
			// 
			// taskProcessView3
			// 
			this.taskProcessView3.LabelMode = false;
			this.taskProcessView3.Location = new System.Drawing.Point(2, 111);
			this.taskProcessView3.Name = "taskProcessView3";
			this.taskProcessView3.Size = new System.Drawing.Size(1024, 55);
			this.taskProcessView3.TabIndex = 2;
			this.taskProcessView3.ViewData = null;
			// 
			// TaskProcessViewList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.taskProcessView3);
			this.Controls.Add(this.taskProcessView2);
			this.Controls.Add(this.taskProcessView_Label);
			this.Name = "TaskProcessViewList";
			this.Size = new System.Drawing.Size(1024, 349);
			this.ResumeLayout(false);
		}
		private Artn.Ilhwa.View.TaskProcessView taskProcessView3;
		private Artn.Ilhwa.View.TaskProcessView taskProcessView2;
		private Artn.Ilhwa.View.TaskProcessView taskProcessView_Label;
	}
}
