/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-23
 * Time: 오전 7:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class TaskProcessView
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
			this.label_None = new System.Windows.Forms.Label();
			this.label_StatusKor = new System.Windows.Forms.Label();
			this.label_ProductionQuantity = new System.Windows.Forms.Label();
			this.label_WasteQuantity = new System.Windows.Forms.Label();
			this.label_BadQuantity = new System.Windows.Forms.Label();
			this.button_ProcessDetail = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_None
			// 
			this.label_None.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_None.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_None.Location = new System.Drawing.Point(0, 0);
			this.label_None.Name = "label_None";
			this.label_None.Size = new System.Drawing.Size(225, 55);
			this.label_None.TabIndex = 1;
			this.label_None.Text = "실적등록 공정선택";
			this.label_None.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_StatusKor
			// 
			this.label_StatusKor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_StatusKor.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_StatusKor.Location = new System.Drawing.Point(224, 0);
			this.label_StatusKor.Name = "label_StatusKor";
			this.label_StatusKor.Size = new System.Drawing.Size(200, 55);
			this.label_StatusKor.TabIndex = 2;
			this.label_StatusKor.Text = "상태";
			this.label_StatusKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_ProductionQuantity
			// 
			this.label_ProductionQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_ProductionQuantity.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ProductionQuantity.Location = new System.Drawing.Point(423, 0);
			this.label_ProductionQuantity.Name = "label_ProductionQuantity";
			this.label_ProductionQuantity.Size = new System.Drawing.Size(200, 55);
			this.label_ProductionQuantity.TabIndex = 4;
			this.label_ProductionQuantity.Text = "생산수량";
			this.label_ProductionQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_WasteQuantity
			// 
			this.label_WasteQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_WasteQuantity.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_WasteQuantity.Location = new System.Drawing.Point(622, 0);
			this.label_WasteQuantity.Name = "label_WasteQuantity";
			this.label_WasteQuantity.Size = new System.Drawing.Size(200, 55);
			this.label_WasteQuantity.TabIndex = 5;
			this.label_WasteQuantity.Text = "폐철수량";
			this.label_WasteQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_BadQuantity
			// 
			this.label_BadQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_BadQuantity.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_BadQuantity.Location = new System.Drawing.Point(821, 0);
			this.label_BadQuantity.Name = "label_BadQuantity";
			this.label_BadQuantity.Size = new System.Drawing.Size(200, 55);
			this.label_BadQuantity.TabIndex = 6;
			this.label_BadQuantity.Text = "불량수량";
			this.label_BadQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_ProcessDetail
			// 
			this.button_ProcessDetail.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_ProcessDetail.Location = new System.Drawing.Point(3, 5);
			this.button_ProcessDetail.Name = "button_ProcessDetail";
			this.button_ProcessDetail.Size = new System.Drawing.Size(218, 45);
			this.button_ProcessDetail.TabIndex = 9;
			this.button_ProcessDetail.Text = "입력";
			this.button_ProcessDetail.UseVisualStyleBackColor = true;
			this.button_ProcessDetail.Click += new System.EventHandler(this.Button_ProcessDetailClick);
			// 
			// TaskProcessView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button_ProcessDetail);
			this.Controls.Add(this.label_BadQuantity);
			this.Controls.Add(this.label_WasteQuantity);
			this.Controls.Add(this.label_ProductionQuantity);
			this.Controls.Add(this.label_StatusKor);
			this.Controls.Add(this.label_None);
			this.Name = "TaskProcessView";
			this.Size = new System.Drawing.Size(1024, 55);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_ProcessDetail;
		private System.Windows.Forms.Label label_BadQuantity;
		private System.Windows.Forms.Label label_WasteQuantity;
		private System.Windows.Forms.Label label_ProductionQuantity;
		private System.Windows.Forms.Label label_StatusKor;
		private System.Windows.Forms.Label label_None;
	}
}
