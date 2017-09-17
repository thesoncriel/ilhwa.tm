/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class FindMaterialsViewPart
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
			this.button_FindBarcode = new System.Windows.Forms.Button();
			this.label0 = new System.Windows.Forms.Label();
			this.textBox_Barcode = new System.Windows.Forms.TextBox();
			this.label_Value3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_Value2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label_Value1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label_Value4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label_Value5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label_Value6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label_Value7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_FindBarcode
			// 
			this.button_FindBarcode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_FindBarcode.Location = new System.Drawing.Point(267, 30);
			this.button_FindBarcode.Name = "button_FindBarcode";
			this.button_FindBarcode.Size = new System.Drawing.Size(76, 39);
			this.button_FindBarcode.TabIndex = 32;
			this.button_FindBarcode.Text = "...";
			this.button_FindBarcode.UseVisualStyleBackColor = true;
			this.button_FindBarcode.Click += new System.EventHandler(this.Button_FindBarcodeClick);
			// 
			// label0
			// 
			this.label0.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label0.Location = new System.Drawing.Point(3, 10);
			this.label0.Name = "label0";
			this.label0.Size = new System.Drawing.Size(98, 17);
			this.label0.TabIndex = 31;
			this.label0.Text = "스캘프 코드";
			// 
			// textBox_Barcode
			// 
			this.textBox_Barcode.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Barcode.Location = new System.Drawing.Point(3, 30);
			this.textBox_Barcode.Name = "textBox_Barcode";
			this.textBox_Barcode.Size = new System.Drawing.Size(258, 39);
			this.textBox_Barcode.TabIndex = 33;
			this.textBox_Barcode.Click += new System.EventHandler(this.TextBox_BarcodeClick);
			this.textBox_Barcode.TextChanged += new System.EventHandler(this.TextBox_BarcodeTextChanged);
			// 
			// label_Value3
			// 
			this.label_Value3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value3.Location = new System.Drawing.Point(101, 115);
			this.label_Value3.Name = "label_Value3";
			this.label_Value3.Size = new System.Drawing.Size(160, 16);
			this.label_Value3.TabIndex = 41;
			this.label_Value3.Text = "11223344";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(3, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 16);
			this.label4.TabIndex = 40;
			this.label4.Text = "강종 :";
			// 
			// label_Value2
			// 
			this.label_Value2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value2.Location = new System.Drawing.Point(101, 99);
			this.label_Value2.Name = "label_Value2";
			this.label_Value2.Size = new System.Drawing.Size(160, 16);
			this.label_Value2.TabIndex = 39;
			this.label_Value2.Text = "11223344";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(3, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 16);
			this.label3.TabIndex = 38;
			this.label3.Text = "두께 :";
			// 
			// label_Value1
			// 
			this.label_Value1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value1.Location = new System.Drawing.Point(101, 83);
			this.label_Value1.Name = "label_Value1";
			this.label_Value1.Size = new System.Drawing.Size(160, 16);
			this.label_Value1.TabIndex = 37;
			this.label_Value1.Text = "11223344";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(3, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 16);
			this.label2.TabIndex = 36;
			this.label2.Text = "중량 :";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(3, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 34;
			this.label1.Text = "스캘프 번호 :";
			// 
			// label_Value4
			// 
			this.label_Value4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value4.Location = new System.Drawing.Point(101, 131);
			this.label_Value4.Name = "label_Value4";
			this.label_Value4.Size = new System.Drawing.Size(160, 16);
			this.label_Value4.TabIndex = 43;
			this.label_Value4.Text = "11223344";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(3, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 16);
			this.label5.TabIndex = 42;
			this.label5.Text = "폭 :";
			// 
			// label_Value5
			// 
			this.label_Value5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value5.Location = new System.Drawing.Point(101, 147);
			this.label_Value5.Name = "label_Value5";
			this.label_Value5.Size = new System.Drawing.Size(160, 16);
			this.label_Value5.TabIndex = 45;
			this.label_Value5.Text = "11223344";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(3, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 16);
			this.label6.TabIndex = 44;
			this.label6.Text = "외경 :";
			// 
			// label_Value6
			// 
			this.label_Value6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value6.Location = new System.Drawing.Point(101, 163);
			this.label_Value6.Name = "label_Value6";
			this.label_Value6.Size = new System.Drawing.Size(160, 16);
			this.label_Value6.TabIndex = 47;
			this.label_Value6.Text = "11223344";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(3, 179);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 16);
			this.label7.TabIndex = 46;
			this.label7.Text = "입고일 :";
			// 
			// label_Value7
			// 
			this.label_Value7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Value7.Location = new System.Drawing.Point(101, 179);
			this.label_Value7.Name = "label_Value7";
			this.label_Value7.Size = new System.Drawing.Size(160, 16);
			this.label_Value7.TabIndex = 48;
			this.label_Value7.Text = "11223344";
			// 
			// FindMaterialsViewPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label_Value7);
			this.Controls.Add(this.label_Value6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label_Value5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label_Value4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label_Value3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label_Value2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label_Value1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_Barcode);
			this.Controls.Add(this.button_FindBarcode);
			this.Controls.Add(this.label0);
			this.Name = "FindMaterialsViewPart";
			this.Size = new System.Drawing.Size(353, 200);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label_Value7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label_Value6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label_Value5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_Value4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_Value1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_Value2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_Value3;
		private System.Windows.Forms.TextBox textBox_Barcode;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Button button_FindBarcode;
	}
}
