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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox_BaudRate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_ComNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBox_SpecCheckInterlock = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox_Printer = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox_BaudRate);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox_ComNumber);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox2.Location = new System.Drawing.Point(12, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 131);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Barcode Printer";
			// 
			// textBox_BaudRate
			// 
			this.textBox_BaudRate.Location = new System.Drawing.Point(145, 80);
			this.textBox_BaudRate.Name = "textBox_BaudRate";
			this.textBox_BaudRate.Size = new System.Drawing.Size(209, 35);
			this.textBox_BaudRate.TabIndex = 6;
			this.textBox_BaudRate.Text = "9600";
			this.textBox_BaudRate.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(20, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Baud Rate";
			// 
			// textBox_ComNumber
			// 
			this.textBox_ComNumber.Location = new System.Drawing.Point(145, 39);
			this.textBox_ComNumber.Name = "textBox_ComNumber";
			this.textBox_ComNumber.Size = new System.Drawing.Size(209, 35);
			this.textBox_ComNumber.TabIndex = 4;
			this.textBox_ComNumber.Text = "2";
			this.textBox_ComNumber.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Com Num";
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
			this.groupBox3.Controls.Add(this.comboBox_SpecCheckInterlock);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.comboBox_Printer);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox3.Location = new System.Drawing.Point(12, 241);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(400, 123);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Other";
			this.groupBox3.Visible = false;
			// 
			// comboBox_SpecCheckInterlock
			// 
			this.comboBox_SpecCheckInterlock.FormattingEnabled = true;
			this.comboBox_SpecCheckInterlock.Items.AddRange(new object[] {
									"예",
									"아니오"});
			this.comboBox_SpecCheckInterlock.Location = new System.Drawing.Point(233, 73);
			this.comboBox_SpecCheckInterlock.Name = "comboBox_SpecCheckInterlock";
			this.comboBox_SpecCheckInterlock.Size = new System.Drawing.Size(121, 32);
			this.comboBox_SpecCheckInterlock.TabIndex = 3;
			this.comboBox_SpecCheckInterlock.Text = "예";
			this.comboBox_SpecCheckInterlock.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SpecCheckInterlockSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mat. Input Check";
			// 
			// comboBox_Printer
			// 
			this.comboBox_Printer.FormattingEnabled = true;
			this.comboBox_Printer.Items.AddRange(new object[] {
									"예",
									"아니오"});
			this.comboBox_Printer.Location = new System.Drawing.Point(233, 33);
			this.comboBox_Printer.Name = "comboBox_Printer";
			this.comboBox_Printer.Size = new System.Drawing.Size(121, 32);
			this.comboBox_Printer.TabIndex = 1;
			this.comboBox_Printer.Text = "예";
			this.comboBox_Printer.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PrinterSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Printer";
			// 
			// FormConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 421);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormConfig";
			this.Text = "FormConfig";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_SpecCheckInterlock;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_Printer;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_ComNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_BaudRate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_IP;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
