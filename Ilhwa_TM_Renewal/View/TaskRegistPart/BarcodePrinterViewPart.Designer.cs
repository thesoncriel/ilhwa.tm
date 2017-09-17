/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-09-05
 * Time: 오후 4:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.TasRegistPart
{
	partial class BarcodePrinterViewPart
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_PrintProdQty = new System.Windows.Forms.Label();
			this.label_PrintRemainQty = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(3, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "주문포장 완료수량 :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(3, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "재고포장 완료수량 :";
			// 
			// label_PrintProdQty
			// 
			this.label_PrintProdQty.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PrintProdQty.Location = new System.Drawing.Point(192, 40);
			this.label_PrintProdQty.Name = "label_PrintProdQty";
			this.label_PrintProdQty.Size = new System.Drawing.Size(99, 42);
			this.label_PrintProdQty.TabIndex = 2;
			this.label_PrintProdQty.Text = "9999";
			this.label_PrintProdQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_PrintRemainQty
			// 
			this.label_PrintRemainQty.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PrintRemainQty.Location = new System.Drawing.Point(192, 111);
			this.label_PrintRemainQty.Name = "label_PrintRemainQty";
			this.label_PrintRemainQty.Size = new System.Drawing.Size(99, 42);
			this.label_PrintRemainQty.TabIndex = 3;
			this.label_PrintRemainQty.Text = "9999";
			this.label_PrintRemainQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(286, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 42);
			this.label4.TabIndex = 4;
			this.label4.Text = "EA";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(286, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 42);
			this.label5.TabIndex = 5;
			this.label5.Text = "EA";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BarcodePrinterViewPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label_PrintRemainQty);
			this.Controls.Add(this.label_PrintProdQty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "BarcodePrinterViewPart";
			this.Size = new System.Drawing.Size(353, 200);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_PrintRemainQty;
		private System.Windows.Forms.Label label_PrintProdQty;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
