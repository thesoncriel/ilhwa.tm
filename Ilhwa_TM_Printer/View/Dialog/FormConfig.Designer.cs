/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-31
 * Time: 오전 6:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class FormConfig
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_IP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBox_PrinterPreview = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox_IP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 86);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Database Server";
			// 
			// textBox_IP
			// 
			this.textBox_IP.Location = new System.Drawing.Point(145, 33);
			this.textBox_IP.Name = "textBox_IP";
			this.textBox_IP.Size = new System.Drawing.Size(209, 35);
			this.textBox_IP.TabIndex = 2;
			this.textBox_IP.Text = "000.000.000.000";
			this.textBox_IP.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP";
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_OK.Location = new System.Drawing.Point(5, 370);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(150, 46);
			this.button_OK.TabIndex = 2;
			this.button_OK.Text = "OK";
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(262, 370);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(150, 46);
			this.button_Cancel.TabIndex = 3;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox_PrinterPreview);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox3.Location = new System.Drawing.Point(12, 104);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(400, 123);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Other";
			// 
			// comboBox_PrinterPreview
			// 
			this.comboBox_PrinterPreview.FormattingEnabled = true;
			this.comboBox_PrinterPreview.Items.AddRange(new object[] {
									"예",
									"아니오"});
			this.comboBox_PrinterPreview.Location = new System.Drawing.Point(233, 33);
			this.comboBox_PrinterPreview.Name = "comboBox_PrinterPreview";
			this.comboBox_PrinterPreview.Size = new System.Drawing.Size(121, 32);
			this.comboBox_PrinterPreview.TabIndex = 1;
			this.comboBox_PrinterPreview.Text = "예";
			this.comboBox_PrinterPreview.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PrinterPreviewSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "출력 시 미리보기";
			// 
			// FormConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 421);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormConfig";
			this.Text = "FormConfig";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_PrinterPreview;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_IP;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
