/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-22
 * Time: 오후 8:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Pop
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
			this.label_PlanODName = new System.Windows.Forms.Label();
			this.label_PlanThickness = new System.Windows.Forms.Label();
			this.label_Remark = new System.Windows.Forms.Label();
			this.label_LengthPop = new System.Windows.Forms.Label();
			this.label_QuantityPop = new System.Windows.Forms.Label();
			this.label_WeightPop = new System.Windows.Forms.Label();
			this.label_EquipCode = new System.Windows.Forms.Label();
			this.label_ProcessSeqKor = new System.Windows.Forms.Label();
			this.label_DeliveryDate = new System.Windows.Forms.Label();
			this.checkBox_Check = new System.Windows.Forms.CheckBox();
			this.label_Customer = new System.Windows.Forms.Label();
			this.label_OrderDate = new System.Windows.Forms.Label();
			this.label_PoDate = new System.Windows.Forms.Label();
			this.label_PublishedKor = new System.Windows.Forms.Label();
			this.checkBox_AllCheck = new System.Windows.Forms.CheckBox();
			this.label_PlanProdName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_OrderNo
			// 
			this.label_OrderNo.BackColor = System.Drawing.Color.Transparent;
			this.label_OrderNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_OrderNo.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OrderNo.Location = new System.Drawing.Point(26, 0);
			this.label_OrderNo.Name = "label_OrderNo";
			this.label_OrderNo.Size = new System.Drawing.Size(127, 25);
			this.label_OrderNo.TabIndex = 0;
			this.label_OrderNo.Text = "지시번호/지시일";
			this.label_OrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_PlanODName
			// 
			this.label_PlanODName.BackColor = System.Drawing.Color.Transparent;
			this.label_PlanODName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_PlanODName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PlanODName.Location = new System.Drawing.Point(626, 0);
			this.label_PlanODName.Name = "label_PlanODName";
			this.label_PlanODName.Size = new System.Drawing.Size(103, 25);
			this.label_PlanODName.TabIndex = 8;
			this.label_PlanODName.Text = "호칭경";
			this.label_PlanODName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_PlanThickness
			// 
			this.label_PlanThickness.BackColor = System.Drawing.Color.Transparent;
			this.label_PlanThickness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_PlanThickness.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PlanThickness.Location = new System.Drawing.Point(714, 0);
			this.label_PlanThickness.Name = "label_PlanThickness";
			this.label_PlanThickness.Size = new System.Drawing.Size(51, 25);
			this.label_PlanThickness.TabIndex = 9;
			this.label_PlanThickness.Text = "두께";
			this.label_PlanThickness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Remark
			// 
			this.label_Remark.BackColor = System.Drawing.Color.Transparent;
			this.label_Remark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_Remark.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Remark.Location = new System.Drawing.Point(86, 24);
			this.label_Remark.Name = "label_Remark";
			this.label_Remark.Size = new System.Drawing.Size(855, 25);
			this.label_Remark.TabIndex = 10;
			this.label_Remark.Text = "비고";
			this.label_Remark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_LengthPop
			// 
			this.label_LengthPop.BackColor = System.Drawing.Color.Transparent;
			this.label_LengthPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_LengthPop.Font = new System.Drawing.Font("굴림", 11.25F);
			this.label_LengthPop.Location = new System.Drawing.Point(756, 0);
			this.label_LengthPop.Name = "label_LengthPop";
			this.label_LengthPop.Size = new System.Drawing.Size(122, 25);
			this.label_LengthPop.TabIndex = 11;
			this.label_LengthPop.Text = "길이(주문/지시)";
			this.label_LengthPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_QuantityPop
			// 
			this.label_QuantityPop.BackColor = System.Drawing.Color.Transparent;
			this.label_QuantityPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_QuantityPop.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_QuantityPop.Location = new System.Drawing.Point(870, 0);
			this.label_QuantityPop.Name = "label_QuantityPop";
			this.label_QuantityPop.Size = new System.Drawing.Size(123, 25);
			this.label_QuantityPop.TabIndex = 14;
			this.label_QuantityPop.Text = "수량(주문/지시)";
			this.label_QuantityPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_WeightPop
			// 
			this.label_WeightPop.BackColor = System.Drawing.Color.Transparent;
			this.label_WeightPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_WeightPop.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_WeightPop.Location = new System.Drawing.Point(1042, 0);
			this.label_WeightPop.Name = "label_WeightPop";
			this.label_WeightPop.Size = new System.Drawing.Size(49, 25);
			this.label_WeightPop.TabIndex = 15;
			this.label_WeightPop.Text = "중량";
			this.label_WeightPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_EquipCode
			// 
			this.label_EquipCode.BackColor = System.Drawing.Color.Transparent;
			this.label_EquipCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_EquipCode.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_EquipCode.Location = new System.Drawing.Point(149, 0);
			this.label_EquipCode.Name = "label_EquipCode";
			this.label_EquipCode.Size = new System.Drawing.Size(44, 25);
			this.label_EquipCode.TabIndex = 16;
			this.label_EquipCode.Text = "호기";
			this.label_EquipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_ProcessSeqKor
			// 
			this.label_ProcessSeqKor.BackColor = System.Drawing.Color.Transparent;
			this.label_ProcessSeqKor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_ProcessSeqKor.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ProcessSeqKor.Location = new System.Drawing.Point(830, 24);
			this.label_ProcessSeqKor.Name = "label_ProcessSeqKor";
			this.label_ProcessSeqKor.Size = new System.Drawing.Size(337, 25);
			this.label_ProcessSeqKor.TabIndex = 17;
			this.label_ProcessSeqKor.Text = "공정";
			this.label_ProcessSeqKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_DeliveryDate
			// 
			this.label_DeliveryDate.BackColor = System.Drawing.Color.Transparent;
			this.label_DeliveryDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_DeliveryDate.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_DeliveryDate.Location = new System.Drawing.Point(996, 0);
			this.label_DeliveryDate.Name = "label_DeliveryDate";
			this.label_DeliveryDate.Size = new System.Drawing.Size(50, 25);
			this.label_DeliveryDate.TabIndex = 18;
			this.label_DeliveryDate.Text = "납기";
			this.label_DeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox_Check
			// 
			this.checkBox_Check.BackColor = System.Drawing.Color.Transparent;
			this.checkBox_Check.Location = new System.Drawing.Point(7, 13);
			this.checkBox_Check.Name = "checkBox_Check";
			this.checkBox_Check.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Check.TabIndex = 23;
			this.checkBox_Check.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox_Check.UseVisualStyleBackColor = false;
			// 
			// label_Customer
			// 
			this.label_Customer.BackColor = System.Drawing.Color.Transparent;
			this.label_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_Customer.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Customer.Location = new System.Drawing.Point(196, 0);
			this.label_Customer.Name = "label_Customer";
			this.label_Customer.Size = new System.Drawing.Size(167, 25);
			this.label_Customer.TabIndex = 3;
			this.label_Customer.Text = "거래처";
			this.label_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderDate
			// 
			this.label_OrderDate.BackColor = System.Drawing.Color.Transparent;
			this.label_OrderDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_OrderDate.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OrderDate.Location = new System.Drawing.Point(357, 0);
			this.label_OrderDate.Name = "label_OrderDate";
			this.label_OrderDate.Size = new System.Drawing.Size(101, 25);
			this.label_OrderDate.TabIndex = 1;
			this.label_OrderDate.Text = "생산제조일자";
			this.label_OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_PoDate
			// 
			this.label_PoDate.BackColor = System.Drawing.Color.Transparent;
			this.label_PoDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_PoDate.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PoDate.Location = new System.Drawing.Point(26, 24);
			this.label_PoDate.Name = "label_PoDate";
			this.label_PoDate.Size = new System.Drawing.Size(94, 25);
			this.label_PoDate.TabIndex = 24;
			this.label_PoDate.Text = "생산제조일자";
			this.label_PoDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_PublishedKor
			// 
			this.label_PublishedKor.BackColor = System.Drawing.Color.Transparent;
			this.label_PublishedKor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_PublishedKor.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PublishedKor.Location = new System.Drawing.Point(1093, 0);
			this.label_PublishedKor.Name = "label_PublishedKor";
			this.label_PublishedKor.Size = new System.Drawing.Size(72, 24);
			this.label_PublishedKor.TabIndex = 25;
			this.label_PublishedKor.Text = "발행확인";
			this.label_PublishedKor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox_AllCheck
			// 
			this.checkBox_AllCheck.BackColor = System.Drawing.Color.Transparent;
			this.checkBox_AllCheck.Location = new System.Drawing.Point(7, 0);
			this.checkBox_AllCheck.Name = "checkBox_AllCheck";
			this.checkBox_AllCheck.Size = new System.Drawing.Size(16, 24);
			this.checkBox_AllCheck.TabIndex = 26;
			this.checkBox_AllCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox_AllCheck.UseVisualStyleBackColor = false;
			this.checkBox_AllCheck.CheckedChanged += new System.EventHandler(this.OnLabelAllChecked);
			// 
			// label_PlanProdName
			// 
			this.label_PlanProdName.BackColor = System.Drawing.Color.Transparent;
			this.label_PlanProdName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label_PlanProdName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PlanProdName.Location = new System.Drawing.Point(453, -1);
			this.label_PlanProdName.Name = "label_PlanProdName";
			this.label_PlanProdName.Size = new System.Drawing.Size(144, 25);
			this.label_PlanProdName.TabIndex = 27;
			this.label_PlanProdName.Text = "SPEC";
			this.label_PlanProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TaskOrderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.label_PlanProdName);
			this.Controls.Add(this.label_LengthPop);
			this.Controls.Add(this.checkBox_AllCheck);
			this.Controls.Add(this.label_PublishedKor);
			this.Controls.Add(this.label_PoDate);
			this.Controls.Add(this.checkBox_Check);
			this.Controls.Add(this.label_ProcessSeqKor);
			this.Controls.Add(this.label_EquipCode);
			this.Controls.Add(this.label_WeightPop);
			this.Controls.Add(this.label_QuantityPop);
			this.Controls.Add(this.label_Remark);
			this.Controls.Add(this.label_PlanThickness);
			this.Controls.Add(this.label_PlanODName);
			this.Controls.Add(this.label_Customer);
			this.Controls.Add(this.label_OrderDate);
			this.Controls.Add(this.label_OrderNo);
			this.Controls.Add(this.label_DeliveryDate);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "TaskOrderView";
			this.Size = new System.Drawing.Size(1166, 50);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_PlanProdName;
		private System.Windows.Forms.CheckBox checkBox_AllCheck;
		private System.Windows.Forms.Label label_PublishedKor;
		private System.Windows.Forms.Label label_PoDate;
		private System.Windows.Forms.CheckBox checkBox_Check;
		private System.Windows.Forms.Label label_DeliveryDate;
		private System.Windows.Forms.Label label_ProcessSeqKor;
		private System.Windows.Forms.Label label_EquipCode;
		private System.Windows.Forms.Label label_WeightPop;
		private System.Windows.Forms.Label label_QuantityPop;
		private System.Windows.Forms.Label label_LengthPop;
		private System.Windows.Forms.Label label_Remark;
		private System.Windows.Forms.Label label_PlanThickness;
		private System.Windows.Forms.Label label_PlanODName;
		private System.Windows.Forms.Label label_Customer;
		private System.Windows.Forms.Label label_OrderDate;
		private System.Windows.Forms.Label label_OrderNo;
	}
}
