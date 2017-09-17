/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class TaskOrderView
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
			this.label_OrderNo = new System.Windows.Forms.Label();
			this.label_OrderDate = new System.Windows.Forms.Label();
			this.label_OrderProgram = new System.Windows.Forms.Label();
			this.label_Customer = new System.Windows.Forms.Label();
			this.label_UseType = new System.Windows.Forms.Label();
			this.label_Significant = new System.Windows.Forms.Label();
			this.label_ProdName = new System.Windows.Forms.Label();
			this.label_OuterDiameter = new System.Windows.Forms.Label();
			this.label_ODName = new System.Windows.Forms.Label();
			this.label_Thickness = new System.Windows.Forms.Label();
			this.label_Remark = new System.Windows.Forms.Label();
			this.label_PlanLength = new System.Windows.Forms.Label();
			this.label_OrderLength = new System.Windows.Forms.Label();
			this.label_OrderQuantity = new System.Windows.Forms.Label();
			this.label_PlanQuantity = new System.Windows.Forms.Label();
			this.label_Weight = new System.Windows.Forms.Label();
			this.label_EquipCode = new System.Windows.Forms.Label();
			this.label_ProcessSeqKor = new System.Windows.Forms.Label();
			this.label_DeliveryDate = new System.Windows.Forms.Label();
			this.label_StatusKor = new System.Windows.Forms.Label();
			this.label_Check = new System.Windows.Forms.Label();
			this.checkBox_CheckAll = new System.Windows.Forms.CheckBox();
			this.checkBox_Check = new System.Windows.Forms.CheckBox();
			this.label_Qual = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_OrderNo
			// 
			this.label_OrderNo.BackColor = System.Drawing.Color.Transparent;
			this.label_OrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OrderNo.Location = new System.Drawing.Point(40, 0);
			this.label_OrderNo.Name = "label_OrderNo";
			this.label_OrderNo.Size = new System.Drawing.Size(100, 35);
			this.label_OrderNo.TabIndex = 0;
			this.label_OrderNo.Text = "지시번호";
			this.label_OrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderDate
			// 
			this.label_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OrderDate.Location = new System.Drawing.Point(40, 34);
			this.label_OrderDate.Name = "label_OrderDate";
			this.label_OrderDate.Size = new System.Drawing.Size(100, 35);
			this.label_OrderDate.TabIndex = 1;
			this.label_OrderDate.Text = "지시일자";
			this.label_OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderProgram
			// 
			this.label_OrderProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OrderProgram.Location = new System.Drawing.Point(139, 0);
			this.label_OrderProgram.Name = "label_OrderProgram";
			this.label_OrderProgram.Size = new System.Drawing.Size(50, 35);
			this.label_OrderProgram.TabIndex = 2;
			this.label_OrderProgram.Text = "구분";
			this.label_OrderProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Customer
			// 
			this.label_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Customer.Location = new System.Drawing.Point(139, 34);
			this.label_Customer.Name = "label_Customer";
			this.label_Customer.Size = new System.Drawing.Size(158, 35);
			this.label_Customer.TabIndex = 3;
			this.label_Customer.Text = "거래처";
			this.label_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_UseType
			// 
			this.label_UseType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_UseType.Location = new System.Drawing.Point(188, 0);
			this.label_UseType.Name = "label_UseType";
			this.label_UseType.Size = new System.Drawing.Size(50, 35);
			this.label_UseType.TabIndex = 4;
			this.label_UseType.Text = "용도";
			this.label_UseType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Significant
			// 
			this.label_Significant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Significant.Location = new System.Drawing.Point(237, 0);
			this.label_Significant.Name = "label_Significant";
			this.label_Significant.Size = new System.Drawing.Size(60, 35);
			this.label_Significant.TabIndex = 5;
			this.label_Significant.Text = "특이사항";
			this.label_Significant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_ProdName
			// 
			this.label_ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_ProdName.Location = new System.Drawing.Point(296, 0);
			this.label_ProdName.Name = "label_ProdName";
			this.label_ProdName.Size = new System.Drawing.Size(100, 35);
			this.label_ProdName.TabIndex = 6;
			this.label_ProdName.Text = "SPEC";
			this.label_ProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OuterDiameter
			// 
			this.label_OuterDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OuterDiameter.Location = new System.Drawing.Point(395, 0);
			this.label_OuterDiameter.Name = "label_OuterDiameter";
			this.label_OuterDiameter.Size = new System.Drawing.Size(50, 35);
			this.label_OuterDiameter.TabIndex = 7;
			this.label_OuterDiameter.Text = "외경";
			this.label_OuterDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_ODName
			// 
			this.label_ODName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_ODName.Location = new System.Drawing.Point(444, 0);
			this.label_ODName.Name = "label_ODName";
			this.label_ODName.Size = new System.Drawing.Size(100, 35);
			this.label_ODName.TabIndex = 8;
			this.label_ODName.Text = "호칭경";
			this.label_ODName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Thickness
			// 
			this.label_Thickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Thickness.Location = new System.Drawing.Point(543, 0);
			this.label_Thickness.Name = "label_Thickness";
			this.label_Thickness.Size = new System.Drawing.Size(50, 35);
			this.label_Thickness.TabIndex = 9;
			this.label_Thickness.Text = "두께";
			this.label_Thickness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Remark
			// 
			this.label_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Remark.Location = new System.Drawing.Point(296, 34);
			this.label_Remark.Name = "label_Remark";
			this.label_Remark.Size = new System.Drawing.Size(297, 35);
			this.label_Remark.TabIndex = 10;
			this.label_Remark.Text = "비고";
			this.label_Remark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_PlanLength
			// 
			this.label_PlanLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_PlanLength.Location = new System.Drawing.Point(592, 0);
			this.label_PlanLength.Name = "label_PlanLength";
			this.label_PlanLength.Size = new System.Drawing.Size(60, 35);
			this.label_PlanLength.TabIndex = 11;
			this.label_PlanLength.Text = "주문길이";
			this.label_PlanLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderLength
			// 
			this.label_OrderLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OrderLength.Location = new System.Drawing.Point(592, 34);
			this.label_OrderLength.Name = "label_OrderLength";
			this.label_OrderLength.Size = new System.Drawing.Size(60, 35);
			this.label_OrderLength.TabIndex = 12;
			this.label_OrderLength.Text = "지시길이";
			this.label_OrderLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderQuantity
			// 
			this.label_OrderQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OrderQuantity.Location = new System.Drawing.Point(651, 34);
			this.label_OrderQuantity.Name = "label_OrderQuantity";
			this.label_OrderQuantity.Size = new System.Drawing.Size(60, 35);
			this.label_OrderQuantity.TabIndex = 14;
			this.label_OrderQuantity.Text = "지시수량";
			this.label_OrderQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_PlanQuantity
			// 
			this.label_PlanQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_PlanQuantity.Location = new System.Drawing.Point(651, 0);
			this.label_PlanQuantity.Name = "label_PlanQuantity";
			this.label_PlanQuantity.Size = new System.Drawing.Size(60, 35);
			this.label_PlanQuantity.TabIndex = 13;
			this.label_PlanQuantity.Text = "주문수량";
			this.label_PlanQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Weight
			// 
			this.label_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Weight.Location = new System.Drawing.Point(710, 0);
			this.label_Weight.Name = "label_Weight";
			this.label_Weight.Size = new System.Drawing.Size(50, 35);
			this.label_Weight.TabIndex = 15;
			this.label_Weight.Text = "중량";
			this.label_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_EquipCode
			// 
			this.label_EquipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_EquipCode.Location = new System.Drawing.Point(759, 0);
			this.label_EquipCode.Name = "label_EquipCode";
			this.label_EquipCode.Size = new System.Drawing.Size(60, 35);
			this.label_EquipCode.TabIndex = 16;
			this.label_EquipCode.Text = "조관기";
			this.label_EquipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_ProcessSeqKor
			// 
			this.label_ProcessSeqKor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_ProcessSeqKor.Location = new System.Drawing.Point(710, 34);
			this.label_ProcessSeqKor.Name = "label_ProcessSeqKor";
			this.label_ProcessSeqKor.Size = new System.Drawing.Size(208, 35);
			this.label_ProcessSeqKor.TabIndex = 17;
			this.label_ProcessSeqKor.Text = "처리공정";
			this.label_ProcessSeqKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_DeliveryDate
			// 
			this.label_DeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_DeliveryDate.Location = new System.Drawing.Point(818, 0);
			this.label_DeliveryDate.Name = "label_DeliveryDate";
			this.label_DeliveryDate.Size = new System.Drawing.Size(100, 35);
			this.label_DeliveryDate.TabIndex = 18;
			this.label_DeliveryDate.Text = "납기예정";
			this.label_DeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_StatusKor
			// 
			this.label_StatusKor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_StatusKor.Location = new System.Drawing.Point(917, 0);
			this.label_StatusKor.Name = "label_StatusKor";
			this.label_StatusKor.Size = new System.Drawing.Size(75, 69);
			this.label_StatusKor.TabIndex = 19;
			this.label_StatusKor.Text = "상태";
			this.label_StatusKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Check
			// 
			this.label_Check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Check.Location = new System.Drawing.Point(1, 0);
			this.label_Check.Name = "label_Check";
			this.label_Check.Size = new System.Drawing.Size(40, 69);
			this.label_Check.TabIndex = 21;
			this.label_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox_CheckAll
			// 
			this.checkBox_CheckAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.checkBox_CheckAll.Location = new System.Drawing.Point(2, 9);
			this.checkBox_CheckAll.Name = "checkBox_CheckAll";
			this.checkBox_CheckAll.Size = new System.Drawing.Size(38, 51);
			this.checkBox_CheckAll.TabIndex = 22;
			this.checkBox_CheckAll.Text = "출력 체크";
			this.checkBox_CheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox_CheckAll.UseVisualStyleBackColor = true;
			this.checkBox_CheckAll.CheckedChanged += new System.EventHandler(this.CheckBox_CheckAllCheckedChanged);
			// 
			// checkBox_Check
			// 
			this.checkBox_Check.Location = new System.Drawing.Point(14, 22);
			this.checkBox_Check.Name = "checkBox_Check";
			this.checkBox_Check.Size = new System.Drawing.Size(20, 24);
			this.checkBox_Check.TabIndex = 23;
			this.checkBox_Check.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox_Check.UseVisualStyleBackColor = true;
			// 
			// label_Qual
			// 
			this.label_Qual.Location = new System.Drawing.Point(917, 42);
			this.label_Qual.Name = "label_Qual";
			this.label_Qual.Size = new System.Drawing.Size(56, 18);
			this.label_Qual.TabIndex = 24;
			this.label_Qual.Text = "label1";
			this.label_Qual.Visible = false;
			// 
			// TaskOrderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label_Qual);
			this.Controls.Add(this.checkBox_Check);
			this.Controls.Add(this.checkBox_CheckAll);
			this.Controls.Add(this.label_Check);
			this.Controls.Add(this.label_StatusKor);
			this.Controls.Add(this.label_DeliveryDate);
			this.Controls.Add(this.label_ProcessSeqKor);
			this.Controls.Add(this.label_EquipCode);
			this.Controls.Add(this.label_Weight);
			this.Controls.Add(this.label_OrderQuantity);
			this.Controls.Add(this.label_PlanQuantity);
			this.Controls.Add(this.label_OrderLength);
			this.Controls.Add(this.label_PlanLength);
			this.Controls.Add(this.label_Remark);
			this.Controls.Add(this.label_Thickness);
			this.Controls.Add(this.label_ODName);
			this.Controls.Add(this.label_OuterDiameter);
			this.Controls.Add(this.label_ProdName);
			this.Controls.Add(this.label_Significant);
			this.Controls.Add(this.label_UseType);
			this.Controls.Add(this.label_Customer);
			this.Controls.Add(this.label_OrderProgram);
			this.Controls.Add(this.label_OrderDate);
			this.Controls.Add(this.label_OrderNo);
			this.Name = "TaskOrderView";
			this.Size = new System.Drawing.Size(993, 70);
			this.Click += new System.EventHandler(this.TaskOrderViewClick);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_Qual;
		private System.Windows.Forms.CheckBox checkBox_Check;
		private System.Windows.Forms.Label label_Check;
		private System.Windows.Forms.CheckBox checkBox_CheckAll;
		private System.Windows.Forms.Label label_StatusKor;
		private System.Windows.Forms.Label label_DeliveryDate;
		private System.Windows.Forms.Label label_ProcessSeqKor;
		private System.Windows.Forms.Label label_EquipCode;
		private System.Windows.Forms.Label label_Weight;
		private System.Windows.Forms.Label label_PlanQuantity;
		private System.Windows.Forms.Label label_OrderQuantity;
		private System.Windows.Forms.Label label_OrderLength;
		private System.Windows.Forms.Label label_PlanLength;
		private System.Windows.Forms.Label label_Remark;
		private System.Windows.Forms.Label label_Thickness;
		private System.Windows.Forms.Label label_ODName;
		private System.Windows.Forms.Label label_OuterDiameter;
		private System.Windows.Forms.Label label_ProdName;
		private System.Windows.Forms.Label label_Significant;
		private System.Windows.Forms.Label label_UseType;
		private System.Windows.Forms.Label label_Customer;
		private System.Windows.Forms.Label label_OrderProgram;
		private System.Windows.Forms.Label label_OrderDate;
		private System.Windows.Forms.Label label_OrderNo;
	}
}
