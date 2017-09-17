/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-31
 * Time: 오전 9:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Dialog
{
	partial class FormBarcodePrinter
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
			this.button_Print = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_Customer = new System.Windows.Forms.TextBox();
			this.textBox_ProdCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_OuterDiameter = new System.Windows.Forms.TextBox();
			this.labelODLabel = new System.Windows.Forms.Label();
			this.textBox_Thickness = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_PlanLength = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_Quantity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_BunchCount = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button_PrintManual = new System.Windows.Forms.Button();
			this.textBox_Worker = new System.Windows.Forms.TextBox();
			this.textBox_CustomerCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label_TotalQuantity = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox_Thickness = new System.Windows.Forms.ComboBox();
			this.comboBox_ODName = new System.Windows.Forms.ComboBox();
			this.comboBox_ProdName = new System.Windows.Forms.ComboBox();
			this.textBox_ODName = new System.Windows.Forms.TextBox();
			this.button_Bad = new System.Windows.Forms.Button();
			this.textBox_ProdName = new System.Windows.Forms.TextBox();
			this.label_PlanQuantity = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_Print
			// 
			this.button_Print.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_Print.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Print.Location = new System.Drawing.Point(311, 293);
			this.button_Print.Name = "button_Print";
			this.button_Print.Size = new System.Drawing.Size(120, 58);
			this.button_Print.TabIndex = 0;
			this.button_Print.Text = "발행";
			this.button_Print.UseVisualStyleBackColor = true;
			this.button_Print.Click += new System.EventHandler(this.Button_PrintClick);
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(563, 293);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(120, 58);
			this.button_Cancel.TabIndex = 1;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "거래처";
			// 
			// textBox_Customer
			// 
			this.textBox_Customer.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Customer.Location = new System.Drawing.Point(280, 9);
			this.textBox_Customer.Name = "textBox_Customer";
			this.textBox_Customer.Size = new System.Drawing.Size(182, 39);
			this.textBox_Customer.TabIndex = 3;
			this.textBox_Customer.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// textBox_ProdCode
			// 
			this.textBox_ProdCode.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_ProdCode.Location = new System.Drawing.Point(90, 54);
			this.textBox_ProdCode.Name = "textBox_ProdCode";
			this.textBox_ProdCode.Size = new System.Drawing.Size(182, 39);
			this.textBox_ProdCode.TabIndex = 5;
			this.textBox_ProdCode.Click += new System.EventHandler(this.TextBox_CodeClick);
			this.textBox_ProdCode.TextChanged += new System.EventHandler(this.TextBox_ProdCodeTextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "SPEC";
			// 
			// textBox_OuterDiameter
			// 
			this.textBox_OuterDiameter.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_OuterDiameter.Location = new System.Drawing.Point(90, 99);
			this.textBox_OuterDiameter.Name = "textBox_OuterDiameter";
			this.textBox_OuterDiameter.Size = new System.Drawing.Size(182, 39);
			this.textBox_OuterDiameter.TabIndex = 7;
			this.textBox_OuterDiameter.Click += new System.EventHandler(this.TextBox_CodeClick);
			this.textBox_OuterDiameter.TextChanged += new System.EventHandler(this.TextBox_textBox_OuterDiameterTextChanged);
			// 
			// labelODLabel
			// 
			this.labelODLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelODLabel.Location = new System.Drawing.Point(12, 107);
			this.labelODLabel.Name = "labelODLabel";
			this.labelODLabel.Size = new System.Drawing.Size(100, 23);
			this.labelODLabel.TabIndex = 6;
			this.labelODLabel.Text = "호칭경";
			// 
			// textBox_Thickness
			// 
			this.textBox_Thickness.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Thickness.Location = new System.Drawing.Point(90, 144);
			this.textBox_Thickness.Name = "textBox_Thickness";
			this.textBox_Thickness.Size = new System.Drawing.Size(182, 39);
			this.textBox_Thickness.TabIndex = 9;
			this.textBox_Thickness.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(12, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "두께";
			// 
			// textBox_PlanLength
			// 
			this.textBox_PlanLength.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_PlanLength.Location = new System.Drawing.Point(90, 189);
			this.textBox_PlanLength.Name = "textBox_PlanLength";
			this.textBox_PlanLength.Size = new System.Drawing.Size(182, 39);
			this.textBox_PlanLength.TabIndex = 11;
			this.textBox_PlanLength.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(12, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "길이";
			// 
			// textBox_Quantity
			// 
			this.textBox_Quantity.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Quantity.Location = new System.Drawing.Point(501, 61);
			this.textBox_Quantity.Name = "textBox_Quantity";
			this.textBox_Quantity.Size = new System.Drawing.Size(182, 39);
			this.textBox_Quantity.TabIndex = 13;
			this.textBox_Quantity.Text = "0";
			this.textBox_Quantity.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_Quantity.TextChanged += new System.EventHandler(this.TextBox_QuantityTextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(501, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "묶음 수량";
			// 
			// textBox_BunchCount
			// 
			this.textBox_BunchCount.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_BunchCount.Location = new System.Drawing.Point(501, 139);
			this.textBox_BunchCount.Name = "textBox_BunchCount";
			this.textBox_BunchCount.Size = new System.Drawing.Size(182, 39);
			this.textBox_BunchCount.TabIndex = 15;
			this.textBox_BunchCount.Text = "0";
			this.textBox_BunchCount.Click += new System.EventHandler(this.TextBox_Click);
			this.textBox_BunchCount.TextChanged += new System.EventHandler(this.TextBox_QuantityTextChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(497, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(175, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "발행 매수";
			// 
			// button_PrintManual
			// 
			this.button_PrintManual.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button_PrintManual.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_PrintManual.Location = new System.Drawing.Point(437, 293);
			this.button_PrintManual.Name = "button_PrintManual";
			this.button_PrintManual.Size = new System.Drawing.Size(120, 58);
			this.button_PrintManual.TabIndex = 16;
			this.button_PrintManual.Text = "수동발행";
			this.button_PrintManual.UseVisualStyleBackColor = true;
			this.button_PrintManual.Click += new System.EventHandler(this.Button_PrintManualClick);
			// 
			// textBox_Worker
			// 
			this.textBox_Worker.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Worker.Location = new System.Drawing.Point(90, 234);
			this.textBox_Worker.Name = "textBox_Worker";
			this.textBox_Worker.Size = new System.Drawing.Size(180, 39);
			this.textBox_Worker.TabIndex = 20;
			this.textBox_Worker.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// textBox_CustomerCode
			// 
			this.textBox_CustomerCode.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_CustomerCode.Location = new System.Drawing.Point(90, 9);
			this.textBox_CustomerCode.Name = "textBox_CustomerCode";
			this.textBox_CustomerCode.Size = new System.Drawing.Size(182, 39);
			this.textBox_CustomerCode.TabIndex = 23;
			this.textBox_CustomerCode.Click += new System.EventHandler(this.TextBox_CodeClick);
			this.textBox_CustomerCode.TextChanged += new System.EventHandler(this.TextBox_CustomerCodeTextChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(501, 201);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 23);
			this.label9.TabIndex = 24;
			this.label9.Text = "등록 수량 :";
			// 
			// label_TotalQuantity
			// 
			this.label_TotalQuantity.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_TotalQuantity.Location = new System.Drawing.Point(559, 239);
			this.label_TotalQuantity.Name = "label_TotalQuantity";
			this.label_TotalQuantity.Size = new System.Drawing.Size(91, 32);
			this.label_TotalQuantity.TabIndex = 25;
			this.label_TotalQuantity.Text = "0";
			this.label_TotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label11.Location = new System.Drawing.Point(645, 239);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 32);
			this.label11.TabIndex = 26;
			this.label11.Text = "EA";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(12, 239);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 27;
			this.label8.Text = "작업자";
			// 
			// comboBox_Thickness
			// 
			this.comboBox_Thickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Thickness.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.comboBox_Thickness.FormattingEnabled = true;
			this.comboBox_Thickness.Location = new System.Drawing.Point(280, 144);
			this.comboBox_Thickness.Name = "comboBox_Thickness";
			this.comboBox_Thickness.Size = new System.Drawing.Size(182, 35);
			this.comboBox_Thickness.TabIndex = 28;
			this.comboBox_Thickness.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ThicknessSelectedIndexChanged);
			// 
			// comboBox_ODName
			// 
			this.comboBox_ODName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ODName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.comboBox_ODName.FormattingEnabled = true;
			this.comboBox_ODName.Location = new System.Drawing.Point(280, 99);
			this.comboBox_ODName.Name = "comboBox_ODName";
			this.comboBox_ODName.Size = new System.Drawing.Size(182, 35);
			this.comboBox_ODName.TabIndex = 29;
			this.comboBox_ODName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ODNameSelectedIndexChanged);
			// 
			// comboBox_ProdName
			// 
			this.comboBox_ProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ProdName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.comboBox_ProdName.FormattingEnabled = true;
			this.comboBox_ProdName.Location = new System.Drawing.Point(280, 54);
			this.comboBox_ProdName.Name = "comboBox_ProdName";
			this.comboBox_ProdName.Size = new System.Drawing.Size(182, 35);
			this.comboBox_ProdName.TabIndex = 30;
			this.comboBox_ProdName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ProdNameSelectedIndexChanged);
			// 
			// textBox_ODName
			// 
			this.textBox_ODName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_ODName.Location = new System.Drawing.Point(90, 99);
			this.textBox_ODName.Name = "textBox_ODName";
			this.textBox_ODName.Size = new System.Drawing.Size(182, 39);
			this.textBox_ODName.TabIndex = 31;
			this.textBox_ODName.TextChanged += new System.EventHandler(this.TextBox_ODNameTextChanged);
			// 
			// button_Bad
			// 
			this.button_Bad.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.button_Bad.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Bad.Location = new System.Drawing.Point(12, 293);
			this.button_Bad.Name = "button_Bad";
			this.button_Bad.Size = new System.Drawing.Size(120, 58);
			this.button_Bad.TabIndex = 32;
			this.button_Bad.Text = "불량등록";
			this.button_Bad.UseVisualStyleBackColor = true;
			this.button_Bad.Click += new System.EventHandler(this.Button_BadClick);
			// 
			// textBox_ProdName
			// 
			this.textBox_ProdName.Location = new System.Drawing.Point(308, 211);
			this.textBox_ProdName.Name = "textBox_ProdName";
			this.textBox_ProdName.Size = new System.Drawing.Size(100, 21);
			this.textBox_ProdName.TabIndex = 33;
			this.textBox_ProdName.Visible = false;
			// 
			// label_PlanQuantity
			// 
			this.label_PlanQuantity.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PlanQuantity.Location = new System.Drawing.Point(501, 5);
			this.label_PlanQuantity.Name = "label_PlanQuantity";
			this.label_PlanQuantity.Size = new System.Drawing.Size(182, 23);
			this.label_PlanQuantity.TabIndex = 34;
			this.label_PlanQuantity.Text = "주문 수량 (100)";
			this.label_PlanQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormBarcodePrinter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 368);
			this.Controls.Add(this.label_PlanQuantity);
			this.Controls.Add(this.textBox_ProdName);
			this.Controls.Add(this.button_Bad);
			this.Controls.Add(this.textBox_ODName);
			this.Controls.Add(this.comboBox_ProdName);
			this.Controls.Add(this.comboBox_ODName);
			this.Controls.Add(this.comboBox_Thickness);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label_TotalQuantity);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox_CustomerCode);
			this.Controls.Add(this.textBox_Worker);
			this.Controls.Add(this.button_PrintManual);
			this.Controls.Add(this.textBox_BunchCount);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_Quantity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox_PlanLength);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_Thickness);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_OuterDiameter);
			this.Controls.Add(this.labelODLabel);
			this.Controls.Add(this.textBox_ProdCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_Customer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_Print);
			this.Controls.Add(this.label8);
			this.Name = "FormBarcodePrinter";
			this.Text = "FormBarcodePrinter";
			this.Load += new System.EventHandler(this.FormBarcodePrinterLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label_PlanQuantity;
		private System.Windows.Forms.TextBox textBox_ProdName;
		private System.Windows.Forms.Button button_Bad;
		private System.Windows.Forms.TextBox textBox_ODName;
		private System.Windows.Forms.ComboBox comboBox_ProdName;
		private System.Windows.Forms.ComboBox comboBox_ODName;
		private System.Windows.Forms.ComboBox comboBox_Thickness;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label_TotalQuantity;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_CustomerCode;
		private System.Windows.Forms.TextBox textBox_Worker;
		private System.Windows.Forms.Button button_PrintManual;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_BunchCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_Quantity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_PlanLength;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_Thickness;
		private System.Windows.Forms.Label labelODLabel;
		private System.Windows.Forms.TextBox textBox_OuterDiameter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_ProdCode;
		private System.Windows.Forms.TextBox textBox_Customer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_Print;
	}
}
