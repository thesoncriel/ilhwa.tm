/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오후 4:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Common
{
	partial class FormGridSelector
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
			this.textBox_SelectInfo = new System.Windows.Forms.TextBox();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.button_MoveNext = new System.Windows.Forms.Button();
			this.button_MovePrev = new System.Windows.Forms.Button();
			this.gridSelectorView = new Artn.Ilhwa.View.Common.GridSelectorView();
			this.textBox_Length = new System.Windows.Forms.TextBox();
			this.button_NumPad = new System.Windows.Forms.Button();
			this.label_Length = new System.Windows.Forms.Label();
			this.button_MovePrev10 = new System.Windows.Forms.Button();
			this.button_MoveNext10 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_SelectInfo
			// 
			this.textBox_SelectInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_SelectInfo.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_SelectInfo.Location = new System.Drawing.Point(12, 12);
			this.textBox_SelectInfo.Multiline = true;
			this.textBox_SelectInfo.Name = "textBox_SelectInfo";
			this.textBox_SelectInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_SelectInfo.Size = new System.Drawing.Size(247, 78);
			this.textBox_SelectInfo.TabIndex = 0;
			this.textBox_SelectInfo.Text = "코일기스\tx2\r\n비드\tx2";
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_OK.Location = new System.Drawing.Point(265, 12);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(112, 78);
			this.button_OK.TabIndex = 1;
			this.button_OK.Text = "확인";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(383, 12);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(112, 78);
			this.button_Cancel.TabIndex = 2;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// button_MoveNext
			// 
			this.button_MoveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_MoveNext.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext.Location = new System.Drawing.Point(665, 12);
			this.button_MoveNext.Name = "button_MoveNext";
			this.button_MoveNext.Size = new System.Drawing.Size(112, 78);
			this.button_MoveNext.TabIndex = 3;
			this.button_MoveNext.Text = "▼";
			this.button_MoveNext.UseVisualStyleBackColor = true;
			this.button_MoveNext.Click += new System.EventHandler(this.Button_MoveNextClick);
			// 
			// button_MovePrev
			// 
			this.button_MovePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_MovePrev.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev.Location = new System.Drawing.Point(547, 12);
			this.button_MovePrev.Name = "button_MovePrev";
			this.button_MovePrev.Size = new System.Drawing.Size(112, 78);
			this.button_MovePrev.TabIndex = 4;
			this.button_MovePrev.Text = "▲";
			this.button_MovePrev.UseVisualStyleBackColor = true;
			this.button_MovePrev.Click += new System.EventHandler(this.Button_MovePrevClick);
			// 
			// gridSelectorView
			// 
			this.gridSelectorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gridSelectorView.KeyValuePair = true;
			this.gridSelectorView.Location = new System.Drawing.Point(0, 146);
			this.gridSelectorView.Name = "gridSelectorView";
			this.gridSelectorView.Size = new System.Drawing.Size(791, 389);
			this.gridSelectorView.TabIndex = 5;
			// 
			// textBox_Length
			// 
			this.textBox_Length.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Length.Location = new System.Drawing.Point(196, 96);
			this.textBox_Length.Name = "textBox_Length";
			this.textBox_Length.Size = new System.Drawing.Size(156, 44);
			this.textBox_Length.TabIndex = 6;
			this.textBox_Length.Text = "0";
			this.textBox_Length.Visible = false;
			this.textBox_Length.Click += new System.EventHandler(this.TextBox_CodeClick);
			// 
			// button_NumPad
			// 
			this.button_NumPad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_NumPad.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_NumPad.Location = new System.Drawing.Point(358, 96);
			this.button_NumPad.Name = "button_NumPad";
			this.button_NumPad.Size = new System.Drawing.Size(79, 44);
			this.button_NumPad.TabIndex = 7;
			this.button_NumPad.Text = "...";
			this.button_NumPad.UseVisualStyleBackColor = true;
			this.button_NumPad.Visible = false;
			this.button_NumPad.Click += new System.EventHandler(this.Button_NumPadClick);
			// 
			// label_Length
			// 
			this.label_Length.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Length.Location = new System.Drawing.Point(11, 106);
			this.label_Length.Name = "label_Length";
			this.label_Length.Size = new System.Drawing.Size(179, 23);
			this.label_Length.TabIndex = 8;
			this.label_Length.Text = "폐철길이 (mm)";
			// 
			// button_MovePrev10
			// 
			this.button_MovePrev10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_MovePrev10.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev10.Location = new System.Drawing.Point(547, 94);
			this.button_MovePrev10.Name = "button_MovePrev10";
			this.button_MovePrev10.Size = new System.Drawing.Size(112, 48);
			this.button_MovePrev10.TabIndex = 9;
			this.button_MovePrev10.Text = "10 ▲";
			this.button_MovePrev10.UseVisualStyleBackColor = true;
			this.button_MovePrev10.Click += new System.EventHandler(this.Button_MovePrev10Click);
			// 
			// button_MoveNext10
			// 
			this.button_MoveNext10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_MoveNext10.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext10.Location = new System.Drawing.Point(665, 95);
			this.button_MoveNext10.Name = "button_MoveNext10";
			this.button_MoveNext10.Size = new System.Drawing.Size(112, 48);
			this.button_MoveNext10.TabIndex = 10;
			this.button_MoveNext10.Text = "10 ▼";
			this.button_MoveNext10.UseVisualStyleBackColor = true;
			this.button_MoveNext10.Click += new System.EventHandler(this.Button_MoveNext10Click);
			// 
			// FormGridSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 538);
			this.Controls.Add(this.button_MoveNext10);
			this.Controls.Add(this.button_MovePrev10);
			this.Controls.Add(this.label_Length);
			this.Controls.Add(this.button_NumPad);
			this.Controls.Add(this.textBox_Length);
			this.Controls.Add(this.gridSelectorView);
			this.Controls.Add(this.button_MovePrev);
			this.Controls.Add(this.button_MoveNext);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.textBox_SelectInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormGridSelector";
			this.Text = "FormGridSelector";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button_MoveNext10;
		private System.Windows.Forms.Button button_MovePrev10;
		private System.Windows.Forms.Label label_Length;
		private System.Windows.Forms.Button button_NumPad;
		private System.Windows.Forms.TextBox textBox_Length;
		private Artn.Ilhwa.View.Common.GridSelectorView gridSelectorView;
		private System.Windows.Forms.Button button_MovePrev;
		private System.Windows.Forms.Button button_MoveNext;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.TextBox textBox_SelectInfo;
	}
}
