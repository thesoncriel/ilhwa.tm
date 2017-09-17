/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-06
 * Time: 오전 4:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Dialog
{
	partial class FormProgressBar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.label_Content = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 34);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(324, 23);
			this.progressBar.TabIndex = 0;
			this.progressBar.Visible = false;
			// 
			// label_Content
			// 
			this.label_Content.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Content.Location = new System.Drawing.Point(12, 2);
			this.label_Content.Name = "label_Content";
			this.label_Content.Size = new System.Drawing.Size(324, 29);
			this.label_Content.TabIndex = 1;
			this.label_Content.Text = "label1";
			this.label_Content.Visible = false;
			// 
			// FormProgressBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 50);
			this.Controls.Add(this.label_Content);
			this.Controls.Add(this.progressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormProgressBar";
			this.Text = "FormProgressBar";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_Content;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}
