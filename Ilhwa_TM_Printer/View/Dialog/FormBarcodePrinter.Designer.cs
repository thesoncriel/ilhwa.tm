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
			this.textBox_ODName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_Thickness = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_PlanLength = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_Quantity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_BunchCount = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button_PrintManual = new System.Windows.Forms.Button();
			this.button_ThkNumPad = new System.Windows.Forms.Button();
			this.button_ODNumPad = new System.Windows.Forms.Button();
			this.textBox_Worker = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_ProdName = new System.Windows.Forms.TextBox();
			this.textBox_OuterDiameter = new System.Windows.Forms.TextBox();
			this.textBox_CustomerCode = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button_Print
			// 
			this.button_Print.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_Print.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Print.Location = new System.Drawing.Point(12, 430);
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
			this.button_Cancel.Location = new System.Drawing.Point(264, 430);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(120, 58);
			this.button_Cancel.TabIndex = 1;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "거래처";
			// 
			// textBox_Customer
			// 
			this.textBox_Customer.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Customer.Location = new System.Drawing.Point(12, 35);
			this.textBox_Customer.Name = "textBox_Customer";
			this.textBox_Customer.Size = new System.Drawing.Size(371, 39);
			this.textBox_Customer.TabIndex = 3;
			this.textBox_Customer.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// textBox_ProdCode
			// 
			this.textBox_ProdCode.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_ProdCode.Location = new System.Drawing.Point(12, 103);
			this.textBox_ProdCode.Name = "textBox_ProdCode";
			this.textBox_ProdCode.Size = new System.Drawing.Size(182, 39);
			this.textBox_ProdCode.TabIndex = 5;
			this.textBox_ProdCode.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "SPEC";
			// 
			// textBox_ODName
			// 
			this.textBox_ODName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_ODName.Location = new System.Drawing.Point(12, 171);
			this.textBox_ODName.Name = "textBox_ODName";
			this.textBox_ODName.Size = new System.Drawing.Size(291, 39);
			this.textBox_ODName.TabIndex = 7;
			this.textBox_ODName.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(12, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "호칭경";
			// 
			// textBox_Thickness
			// 
			this.textBox_Thickness.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Thickness.Location = new System.Drawing.Point(12, 239);
			this.textBox_Thickness.Name = "textBox_Thickness";
			this.textBox_Thickness.Size = new System.Drawing.Size(291, 39);
			this.textBox_Thickness.TabIndex = 9;
			this.textBox_Thickness.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(12, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "두께";
			// 
			// textBox_PlanLength
			// 
			this.textBox_PlanLength.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_PlanLength.Location = new System.Drawing.Point(12, 307);
			this.textBox_PlanLength.Name = "textBox_PlanLength";
			this.textBox_PlanLength.Size = new System.Drawing.Size(371, 39);
			this.textBox_PlanLength.TabIndex = 11;
			this.textBox_PlanLength.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(12, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "길이";
			// 
			// textBox_Quantity
			// 
			this.textBox_Quantity.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Quantity.Location = new System.Drawing.Point(12, 375);
			this.textBox_Quantity.Name = "textBox_Quantity";
			this.textBox_Quantity.Size = new System.Drawing.Size(182, 39);
			this.textBox_Quantity.TabIndex = 13;
			this.textBox_Quantity.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(12, 349);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "포장 묶음당 수량";
			// 
			// textBox_BunchCount
			// 
			this.textBox_BunchCount.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_BunchCount.Location = new System.Drawing.Point(201, 375);
			this.textBox_BunchCount.Name = "textBox_BunchCount";
			this.textBox_BunchCount.Size = new System.Drawing.Size(182, 39);
			this.textBox_BunchCount.TabIndex = 15;
			this.textBox_BunchCount.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(197, 349);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(200, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "포장지 수량 (묶음수)";
			// 
			// button_PrintManual
			// 
			this.button_PrintManual.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button_PrintManual.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_PrintManual.Location = new System.Drawing.Point(138, 430);
			this.button_PrintManual.Name = "button_PrintManual";
			this.button_PrintManual.Size = new System.Drawing.Size(120, 58);
			this.button_PrintManual.TabIndex = 16;
			this.button_PrintManual.Text = "수동발행";
			this.button_PrintManual.UseVisualStyleBackColor = true;
			this.button_PrintManual.Click += new System.EventHandler(this.Button_PrintManualClick);
			// 
			// button_ThkNumPad
			// 
			this.button_ThkNumPad.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_ThkNumPad.Location = new System.Drawing.Point(309, 239);
			this.button_ThkNumPad.Name = "button_ThkNumPad";
			this.button_ThkNumPad.Size = new System.Drawing.Size(75, 39);
			this.button_ThkNumPad.TabIndex = 17;
			this.button_ThkNumPad.Text = "...";
			this.button_ThkNumPad.UseVisualStyleBackColor = true;
			this.button_ThkNumPad.Click += new System.EventHandler(this.Button_ThkNumPadClick);
			// 
			// button_ODNumPad
			// 
			this.button_ODNumPad.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_ODNumPad.Location = new System.Drawing.Point(309, 171);
			this.button_ODNumPad.Name = "button_ODNumPad";
			this.button_ODNumPad.Size = new System.Drawing.Size(75, 39);
			this.button_ODNumPad.TabIndex = 18;
			this.button_ODNumPad.Text = "...";
			this.button_ODNumPad.UseVisualStyleBackColor = true;
			this.button_ODNumPad.Click += new System.EventHandler(this.Button_ODNumPadClick);
			// 
			// textBox_Worker
			// 
			this.textBox_Worker.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Worker.Location = new System.Drawing.Point(203, 103);
			this.textBox_Worker.Name = "textBox_Worker";
			this.textBox_Worker.Size = new System.Drawing.Size(180, 39);
			this.textBox_Worker.TabIndex = 20;
			this.textBox_Worker.Click += new System.EventHandler(this.TextBox_Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(203, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "작업자";
			// 
			// textBox_ProdName
			// 
			this.textBox_ProdName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_ProdName.Location = new System.Drawing.Point(103, 147);
			this.textBox_ProdName.Name = "textBox_ProdName";
			this.textBox_ProdName.Size = new System.Drawing.Size(182, 22);
			this.textBox_ProdName.TabIndex = 21;
			this.textBox_ProdName.Visible = false;
			// 
			// textBox_OuterDiameter
			// 
			this.textBox_OuterDiameter.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_OuterDiameter.Location = new System.Drawing.Point(103, 216);
			this.textBox_OuterDiameter.Name = "textBox_OuterDiameter";
			this.textBox_OuterDiameter.Size = new System.Drawing.Size(182, 22);
			this.textBox_OuterDiameter.TabIndex = 22;
			this.textBox_OuterDiameter.Visible = false;
			// 
			// textBox_CustomerCode
			// 
			this.textBox_CustomerCode.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_CustomerCode.Location = new System.Drawing.Point(162, 11);
			this.textBox_CustomerCode.Name = "textBox_CustomerCode";
			this.textBox_CustomerCode.Size = new System.Drawing.Size(182, 22);
			this.textBox_CustomerCode.TabIndex = 23;
			this.textBox_CustomerCode.Visible = false;
			// 
			// FormBarcodePrinter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 498);
			this.Controls.Add(this.textBox_CustomerCode);
			this.Controls.Add(this.textBox_OuterDiameter);
			this.Controls.Add(this.textBox_ProdName);
			this.Controls.Add(this.textBox_Worker);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button_ODNumPad);
			this.Controls.Add(this.button_ThkNumPad);
			this.Controls.Add(this.button_PrintManual);
			this.Controls.Add(this.textBox_BunchCount);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_Quantity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox_PlanLength);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_Thickness);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_ODName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_ProdCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_Customer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_Print);
			this.Name = "FormBarcodePrinter";
			this.Text = "FormBarcodePrinter";
			this.Load += new System.EventHandler(this.FormBarcodePrinterLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox_CustomerCode;
		private System.Windows.Forms.TextBox textBox_OuterDiameter;
		private System.Windows.Forms.TextBox textBox_ProdName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_Worker;
		private System.Windows.Forms.Button button_ODNumPad;
		private System.Windows.Forms.Button button_ThkNumPad;
		private System.Windows.Forms.Button button_PrintManual;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_BunchCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_Quantity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_PlanLength;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_Thickness;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_ODName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_ProdCode;
		private System.Windows.Forms.TextBox textBox_Customer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_Print;
	}
}
