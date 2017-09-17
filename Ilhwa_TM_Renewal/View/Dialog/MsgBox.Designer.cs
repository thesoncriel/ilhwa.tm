/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-02
 * Time: 오전 9:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Dialog
{
	partial class MsgBox
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
			this.label_Title = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.label_Msg = new System.Windows.Forms.Label();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Title
			// 
			this.label_Title.BackColor = System.Drawing.Color.Aquamarine;
			this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_Title.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Title.Location = new System.Drawing.Point(0, 0);
			this.label_Title.Name = "label_Title";
			this.label_Title.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.label_Title.Size = new System.Drawing.Size(433, 45);
			this.label_Title.TabIndex = 0;
			this.label_Title.Text = "제목";
			this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_OK.Location = new System.Drawing.Point(144, 210);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(138, 64);
			this.button_OK.TabIndex = 1;
			this.button_OK.Text = "확인";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// label_Msg
			// 
			this.label_Msg.BackColor = System.Drawing.Color.Transparent;
			this.label_Msg.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Msg.Location = new System.Drawing.Point(117, 61);
			this.label_Msg.Name = "label_Msg";
			this.label_Msg.Size = new System.Drawing.Size(304, 106);
			this.label_Msg.TabIndex = 2;
			this.label_Msg.Text = "내용";
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(283, 210);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(138, 64);
			this.button_Cancel.TabIndex = 3;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// MsgBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(433, 286);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.label_Msg);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.label_Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MsgBox";
			this.Text = "Message";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Label label_Msg;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Label label_Title;
	}
}
