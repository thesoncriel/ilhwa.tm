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
	partial class TaskProcessViewPart
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
			this.label_ProcessCodeKor = new System.Windows.Forms.Label();
			this.panel_Left = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button_ProductAdd = new System.Windows.Forms.Button();
			this.panel_Right = new System.Windows.Forms.Panel();
			this.button_WasteInsert = new System.Windows.Forms.Button();
			this.button_BadInsert = new System.Windows.Forms.Button();
			this.label_BadQuantity = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label_WasteQuantity = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label_ProductionQuantity = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label_ReceivedQuantity = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel_Left.SuspendLayout();
			this.panel_Right.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_ProcessCodeKor
			// 
			this.label_ProcessCodeKor.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ProcessCodeKor.Location = new System.Drawing.Point(4, 35);
			this.label_ProcessCodeKor.Name = "label_ProcessCodeKor";
			this.label_ProcessCodeKor.Size = new System.Drawing.Size(139, 54);
			this.label_ProcessCodeKor.TabIndex = 1;
			this.label_ProcessCodeKor.Text = "조관PL";
			this.label_ProcessCodeKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel_Left
			// 
			this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Left.Controls.Add(this.label_ProcessCodeKor);
			this.panel_Left.Controls.Add(this.label1);
			this.panel_Left.Location = new System.Drawing.Point(0, 0);
			this.panel_Left.Name = "panel_Left";
			this.panel_Left.Size = new System.Drawing.Size(150, 100);
			this.panel_Left.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(15, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "실적관리";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_ProductAdd
			// 
			this.button_ProductAdd.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_ProductAdd.Location = new System.Drawing.Point(267, 19);
			this.button_ProductAdd.Name = "button_ProductAdd";
			this.button_ProductAdd.Size = new System.Drawing.Size(130, 55);
			this.button_ProductAdd.TabIndex = 30;
			this.button_ProductAdd.Text = "생산추가";
			this.button_ProductAdd.UseVisualStyleBackColor = true;
			this.button_ProductAdd.Click += new System.EventHandler(this.Button_AddProdClick);
			// 
			// panel_Right
			// 
			this.panel_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Right.Controls.Add(this.button_WasteInsert);
			this.panel_Right.Controls.Add(this.button_BadInsert);
			this.panel_Right.Controls.Add(this.button_ProductAdd);
			this.panel_Right.Controls.Add(this.label_BadQuantity);
			this.panel_Right.Controls.Add(this.label10);
			this.panel_Right.Controls.Add(this.label_WasteQuantity);
			this.panel_Right.Controls.Add(this.label8);
			this.panel_Right.Controls.Add(this.label_ProductionQuantity);
			this.panel_Right.Controls.Add(this.label6);
			this.panel_Right.Controls.Add(this.label_ReceivedQuantity);
			this.panel_Right.Controls.Add(this.label3);
			this.panel_Right.Location = new System.Drawing.Point(149, 0);
			this.panel_Right.Name = "panel_Right";
			this.panel_Right.Size = new System.Drawing.Size(870, 100);
			this.panel_Right.TabIndex = 3;
			// 
			// button_WasteInsert
			// 
			this.button_WasteInsert.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_WasteInsert.Location = new System.Drawing.Point(403, 19);
			this.button_WasteInsert.Name = "button_WasteInsert";
			this.button_WasteInsert.Size = new System.Drawing.Size(130, 55);
			this.button_WasteInsert.TabIndex = 32;
			this.button_WasteInsert.Text = "폐철등록";
			this.button_WasteInsert.UseVisualStyleBackColor = true;
			this.button_WasteInsert.Click += new System.EventHandler(this.Button_WasteInsertClick);
			// 
			// button_BadInsert
			// 
			this.button_BadInsert.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_BadInsert.Location = new System.Drawing.Point(539, 19);
			this.button_BadInsert.Name = "button_BadInsert";
			this.button_BadInsert.Size = new System.Drawing.Size(130, 55);
			this.button_BadInsert.TabIndex = 31;
			this.button_BadInsert.Text = "불량등록";
			this.button_BadInsert.UseVisualStyleBackColor = true;
			this.button_BadInsert.Click += new System.EventHandler(this.Button_BadInsertClick);
			// 
			// label_BadQuantity
			// 
			this.label_BadQuantity.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_BadQuantity.Location = new System.Drawing.Point(83, 70);
			this.label_BadQuantity.Name = "label_BadQuantity";
			this.label_BadQuantity.Size = new System.Drawing.Size(160, 16);
			this.label_BadQuantity.TabIndex = 7;
			this.label_BadQuantity.Text = "11223344";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(7, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "불량수량 :";
			// 
			// label_WasteQuantity
			// 
			this.label_WasteQuantity.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_WasteQuantity.Location = new System.Drawing.Point(83, 50);
			this.label_WasteQuantity.Name = "label_WasteQuantity";
			this.label_WasteQuantity.Size = new System.Drawing.Size(160, 16);
			this.label_WasteQuantity.TabIndex = 5;
			this.label_WasteQuantity.Text = "11223344";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(7, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "폐철수량 :";
			// 
			// label_ProductionQuantity
			// 
			this.label_ProductionQuantity.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ProductionQuantity.Location = new System.Drawing.Point(83, 30);
			this.label_ProductionQuantity.Name = "label_ProductionQuantity";
			this.label_ProductionQuantity.Size = new System.Drawing.Size(160, 16);
			this.label_ProductionQuantity.TabIndex = 3;
			this.label_ProductionQuantity.Text = "11223344";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(7, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "생산수량 :";
			// 
			// label_ReceivedQuantity
			// 
			this.label_ReceivedQuantity.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ReceivedQuantity.Location = new System.Drawing.Point(83, 10);
			this.label_ReceivedQuantity.Name = "label_ReceivedQuantity";
			this.label_ReceivedQuantity.Size = new System.Drawing.Size(160, 16);
			this.label_ReceivedQuantity.TabIndex = 1;
			this.label_ReceivedQuantity.Text = "11223344";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(7, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "받은수량 :";
			// 
			// TaskProcessViewPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_Left);
			this.Controls.Add(this.panel_Right);
			this.Name = "TaskProcessViewPart";
			this.Size = new System.Drawing.Size(1024, 100);
			this.panel_Left.ResumeLayout(false);
			this.panel_Right.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_BadInsert;
		private System.Windows.Forms.Button button_WasteInsert;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_ReceivedQuantity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label_ProductionQuantity;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label_WasteQuantity;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label_BadQuantity;
		private System.Windows.Forms.Panel panel_Right;
		private System.Windows.Forms.Button button_ProductAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel_Left;
		private System.Windows.Forms.Label label_ProcessCodeKor;
	}
}
