/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-09-26
 * Time: 오후 1:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Dialog
{
	partial class FormSearchOption
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker_OrderDateFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_OrderDateTo = new System.Windows.Forms.DateTimePicker();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_Length = new System.Windows.Forms.TextBox();
			this.textBox_Thickness = new System.Windows.Forms.TextBox();
			this.textBox_EquipCode = new System.Windows.Forms.TextBox();
			this.textBox_OuterDiameter = new System.Windows.Forms.TextBox();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.textBox_Qual = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox_Status = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox_ODName = new System.Windows.Forms.TextBox();
			this.textBox_ProdCode = new System.Windows.Forms.TextBox();
			this.textBox_Quantity = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(26, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "날짜";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(26, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "호기별";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(26, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "외경";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(26, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "길이";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(26, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "두께";
			// 
			// dateTimePicker_OrderDateFrom
			// 
			this.dateTimePicker_OrderDateFrom.CalendarFont = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker_OrderDateFrom.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker_OrderDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_OrderDateFrom.Location = new System.Drawing.Point(120, 24);
			this.dateTimePicker_OrderDateFrom.Name = "dateTimePicker_OrderDateFrom";
			this.dateTimePicker_OrderDateFrom.Size = new System.Drawing.Size(178, 35);
			this.dateTimePicker_OrderDateFrom.TabIndex = 42;
			this.dateTimePicker_OrderDateFrom.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_OrderDateFrom.ValueChanged += new System.EventHandler(this.DateTimePicker_OrderDateValueChanged);
			// 
			// dateTimePicker_OrderDateTo
			// 
			this.dateTimePicker_OrderDateTo.CalendarFont = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker_OrderDateTo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker_OrderDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_OrderDateTo.Location = new System.Drawing.Point(304, 24);
			this.dateTimePicker_OrderDateTo.Name = "dateTimePicker_OrderDateTo";
			this.dateTimePicker_OrderDateTo.Size = new System.Drawing.Size(178, 35);
			this.dateTimePicker_OrderDateTo.TabIndex = 43;
			this.dateTimePicker_OrderDateTo.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_OrderDateTo.ValueChanged += new System.EventHandler(this.DateTimePicker_OrderDateValueChanged);
			// 
			// button_Search
			// 
			this.button_Search.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_Search.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Search.Location = new System.Drawing.Point(188, 329);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(143, 68);
			this.button_Search.TabIndex = 44;
			this.button_Search.Text = "검색";
			this.button_Search.UseVisualStyleBackColor = true;
			// 
			// textBox_Length
			// 
			this.textBox_Length.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_Length.Location = new System.Drawing.Point(120, 148);
			this.textBox_Length.Name = "textBox_Length";
			this.textBox_Length.Size = new System.Drawing.Size(178, 38);
			this.textBox_Length.TabIndex = 45;
			this.textBox_Length.Text = "0";
			this.textBox_Length.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_Length.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_Thickness
			// 
			this.textBox_Thickness.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_Thickness.Location = new System.Drawing.Point(120, 192);
			this.textBox_Thickness.Name = "textBox_Thickness";
			this.textBox_Thickness.Size = new System.Drawing.Size(178, 38);
			this.textBox_Thickness.TabIndex = 46;
			this.textBox_Thickness.Text = "0";
			this.textBox_Thickness.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_Thickness.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_EquipCode
			// 
			this.textBox_EquipCode.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_EquipCode.Location = new System.Drawing.Point(120, 63);
			this.textBox_EquipCode.Name = "textBox_EquipCode";
			this.textBox_EquipCode.Size = new System.Drawing.Size(178, 38);
			this.textBox_EquipCode.TabIndex = 47;
			this.textBox_EquipCode.Click += new System.EventHandler(this.TextBox_EquipCodeClick);
			this.textBox_EquipCode.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_OuterDiameter
			// 
			this.textBox_OuterDiameter.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_OuterDiameter.Location = new System.Drawing.Point(120, 107);
			this.textBox_OuterDiameter.Name = "textBox_OuterDiameter";
			this.textBox_OuterDiameter.Size = new System.Drawing.Size(178, 38);
			this.textBox_OuterDiameter.TabIndex = 48;
			this.textBox_OuterDiameter.Text = "0";
			this.textBox_OuterDiameter.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_OuterDiameter.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(339, 329);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(143, 68);
			this.button_Cancel.TabIndex = 49;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// textBox_Qual
			// 
			this.textBox_Qual.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_Qual.Location = new System.Drawing.Point(120, 236);
			this.textBox_Qual.Name = "textBox_Qual";
			this.textBox_Qual.Size = new System.Drawing.Size(178, 38);
			this.textBox_Qual.TabIndex = 51;
			this.textBox_Qual.Text = "0";
			this.textBox_Qual.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_Qual.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(26, 243);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 50;
			this.label6.Text = "강종";
			// 
			// comboBox_Status
			// 
			this.comboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Status.Font = new System.Drawing.Font("굴림", 20F);
			this.comboBox_Status.FormattingEnabled = true;
			this.comboBox_Status.Items.AddRange(new object[] {
									"모두",
									"지시대기",
									"생산중",
									"생산중지",
									"지시취소",
									"주문취소",
									"생산완료"});
			this.comboBox_Status.Location = new System.Drawing.Point(120, 280);
			this.comboBox_Status.Name = "comboBox_Status";
			this.comboBox_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox_Status.Size = new System.Drawing.Size(178, 35);
			this.comboBox_Status.TabIndex = 52;
			this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.ComboBox_StatusSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(26, 287);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 23);
			this.label7.TabIndex = 53;
			this.label7.Text = "공정상태";
			// 
			// textBox_ODName
			// 
			this.textBox_ODName.BackColor = System.Drawing.Color.White;
			this.textBox_ODName.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_ODName.Location = new System.Drawing.Point(120, 107);
			this.textBox_ODName.Name = "textBox_ODName";
			this.textBox_ODName.Size = new System.Drawing.Size(178, 38);
			this.textBox_ODName.TabIndex = 54;
			this.textBox_ODName.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_ODName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_ProdCode
			// 
			this.textBox_ProdCode.BackColor = System.Drawing.Color.White;
			this.textBox_ProdCode.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_ProdCode.Location = new System.Drawing.Point(120, 63);
			this.textBox_ProdCode.Name = "textBox_ProdCode";
			this.textBox_ProdCode.Size = new System.Drawing.Size(178, 38);
			this.textBox_ProdCode.TabIndex = 55;
			this.textBox_ProdCode.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_ProdCode.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_Quantity
			// 
			this.textBox_Quantity.BackColor = System.Drawing.Color.White;
			this.textBox_Quantity.Font = new System.Drawing.Font("굴림", 20F);
			this.textBox_Quantity.Location = new System.Drawing.Point(120, 236);
			this.textBox_Quantity.Name = "textBox_Quantity";
			this.textBox_Quantity.Size = new System.Drawing.Size(178, 38);
			this.textBox_Quantity.TabIndex = 56;
			this.textBox_Quantity.Text = "1";
			this.textBox_Quantity.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_Quantity.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// FormSearchOption
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 409);
			this.Controls.Add(this.textBox_Quantity);
			this.Controls.Add(this.textBox_ProdCode);
			this.Controls.Add(this.textBox_ODName);
			this.Controls.Add(this.comboBox_Status);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_Qual);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.textBox_OuterDiameter);
			this.Controls.Add(this.textBox_EquipCode);
			this.Controls.Add(this.textBox_Thickness);
			this.Controls.Add(this.textBox_Length);
			this.Controls.Add(this.button_Search);
			this.Controls.Add(this.dateTimePicker_OrderDateTo);
			this.Controls.Add(this.dateTimePicker_OrderDateFrom);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormSearchOption";
			this.Text = "FormSearchOption";
			this.Load += new System.EventHandler(this.FormSearchOptionLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox_Quantity;
		private System.Windows.Forms.TextBox textBox_ProdCode;
		private System.Windows.Forms.TextBox textBox_ODName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox_Status;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_Qual;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.TextBox textBox_OuterDiameter;
		private System.Windows.Forms.TextBox textBox_EquipCode;
		private System.Windows.Forms.TextBox textBox_Thickness;
		private System.Windows.Forms.TextBox textBox_Length;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.DateTimePicker dateTimePicker_OrderDateFrom;
		private System.Windows.Forms.DateTimePicker dateTimePicker_OrderDateTo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
