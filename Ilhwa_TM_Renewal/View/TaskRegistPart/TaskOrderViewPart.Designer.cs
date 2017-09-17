/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class TaskOrderViewPart
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
			this.panel_Left = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label_OrderNo = new System.Windows.Forms.Label();
			this.panel_Right = new System.Windows.Forms.Panel();
			this.label_Qual = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label_Worker = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button_WorkerChange = new System.Windows.Forms.Button();
			this.button_EquipChange = new System.Windows.Forms.Button();
			this.label_Weight = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label_Thickness = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label_ODName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_OrderQuantity = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label_OrderLength = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label_PlanQuantity = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label_PlanLength = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label_EquipCode = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label_Remark = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label_OuterDiameter = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label_UseType = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label_Customer = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label_DeliveryDate = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel_Left.SuspendLayout();
			this.panel_Right.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Left
			// 
			this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Left.Controls.Add(this.label1);
			this.panel_Left.Controls.Add(this.label_OrderNo);
			this.panel_Left.Location = new System.Drawing.Point(0, 0);
			this.panel_Left.Name = "panel_Left";
			this.panel_Left.Size = new System.Drawing.Size(150, 155);
			this.panel_Left.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(13, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "작업지시";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderNo
			// 
			this.label_OrderNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OrderNo.Location = new System.Drawing.Point(2, 65);
			this.label_OrderNo.Name = "label_OrderNo";
			this.label_OrderNo.Size = new System.Drawing.Size(142, 32);
			this.label_OrderNo.TabIndex = 1;
			this.label_OrderNo.Text = "10A22033";
			this.label_OrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel_Right
			// 
			this.panel_Right.AutoSize = true;
			this.panel_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Right.Controls.Add(this.label_Qual);
			this.panel_Right.Controls.Add(this.label9);
			this.panel_Right.Controls.Add(this.label_Worker);
			this.panel_Right.Controls.Add(this.label3);
			this.panel_Right.Controls.Add(this.button_WorkerChange);
			this.panel_Right.Controls.Add(this.button_EquipChange);
			this.panel_Right.Controls.Add(this.label_Weight);
			this.panel_Right.Controls.Add(this.label5);
			this.panel_Right.Controls.Add(this.label_Thickness);
			this.panel_Right.Controls.Add(this.label7);
			this.panel_Right.Controls.Add(this.label_ODName);
			this.panel_Right.Controls.Add(this.label4);
			this.panel_Right.Controls.Add(this.label_OrderQuantity);
			this.panel_Right.Controls.Add(this.label18);
			this.panel_Right.Controls.Add(this.label_OrderLength);
			this.panel_Right.Controls.Add(this.label20);
			this.panel_Right.Controls.Add(this.label_PlanQuantity);
			this.panel_Right.Controls.Add(this.label22);
			this.panel_Right.Controls.Add(this.label_PlanLength);
			this.panel_Right.Controls.Add(this.label24);
			this.panel_Right.Controls.Add(this.label_EquipCode);
			this.panel_Right.Controls.Add(this.label26);
			this.panel_Right.Controls.Add(this.label_Remark);
			this.panel_Right.Controls.Add(this.label16);
			this.panel_Right.Controls.Add(this.label_OuterDiameter);
			this.panel_Right.Controls.Add(this.label14);
			this.panel_Right.Controls.Add(this.label_UseType);
			this.panel_Right.Controls.Add(this.label10);
			this.panel_Right.Controls.Add(this.label_Customer);
			this.panel_Right.Controls.Add(this.label8);
			this.panel_Right.Controls.Add(this.label_DeliveryDate);
			this.panel_Right.Controls.Add(this.label6);
			this.panel_Right.Location = new System.Drawing.Point(149, 0);
			this.panel_Right.Name = "panel_Right";
			this.panel_Right.Size = new System.Drawing.Size(870, 155);
			this.panel_Right.TabIndex = 1;
			// 
			// label_Qual
			// 
			this.label_Qual.AutoSize = true;
			this.label_Qual.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Qual.Location = new System.Drawing.Point(329, 42);
			this.label_Qual.Name = "label_Qual";
			this.label_Qual.Size = new System.Drawing.Size(31, 13);
			this.label_Qual.TabIndex = 38;
			this.label_Qual.Text = "304";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(253, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 16);
			this.label9.TabIndex = 37;
			this.label9.Text = "강종 :";
			// 
			// label_Worker
			// 
			this.label_Worker.AutoSize = true;
			this.label_Worker.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Worker.Location = new System.Drawing.Point(329, 26);
			this.label_Worker.Name = "label_Worker";
			this.label_Worker.Size = new System.Drawing.Size(63, 13);
			this.label_Worker.TabIndex = 36;
			this.label_Worker.Text = "슈퍼돌이";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(253, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 16);
			this.label3.TabIndex = 35;
			this.label3.Text = "작업자 :";
			// 
			// button_WorkerChange
			// 
			this.button_WorkerChange.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_WorkerChange.Location = new System.Drawing.Point(554, 42);
			this.button_WorkerChange.Name = "button_WorkerChange";
			this.button_WorkerChange.Size = new System.Drawing.Size(166, 55);
			this.button_WorkerChange.TabIndex = 34;
			this.button_WorkerChange.Text = "작업자 등록";
			this.button_WorkerChange.UseVisualStyleBackColor = true;
			this.button_WorkerChange.Click += new System.EventHandler(this.Button_WorkerChangeClick);
			// 
			// button_EquipChange
			// 
			this.button_EquipChange.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_EquipChange.Location = new System.Drawing.Point(726, 42);
			this.button_EquipChange.Name = "button_EquipChange";
			this.button_EquipChange.Size = new System.Drawing.Size(130, 55);
			this.button_EquipChange.TabIndex = 30;
			this.button_EquipChange.Text = "설비변경";
			this.button_EquipChange.UseVisualStyleBackColor = true;
			this.button_EquipChange.Click += new System.EventHandler(this.Button_EquipChangeClick);
			// 
			// label_Weight
			// 
			this.label_Weight.AutoSize = true;
			this.label_Weight.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Weight.Location = new System.Drawing.Point(83, 106);
			this.label_Weight.Name = "label_Weight";
			this.label_Weight.Size = new System.Drawing.Size(71, 13);
			this.label_Weight.TabIndex = 29;
			this.label_Weight.Text = "11223344";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(7, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 16);
			this.label5.TabIndex = 28;
			this.label5.Text = "중량 :";
			// 
			// label_Thickness
			// 
			this.label_Thickness.AutoSize = true;
			this.label_Thickness.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Thickness.Location = new System.Drawing.Point(83, 90);
			this.label_Thickness.Name = "label_Thickness";
			this.label_Thickness.Size = new System.Drawing.Size(71, 13);
			this.label_Thickness.TabIndex = 27;
			this.label_Thickness.Text = "11223344";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(7, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "두께 :";
			// 
			// label_ODName
			// 
			this.label_ODName.AutoSize = true;
			this.label_ODName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ODName.Location = new System.Drawing.Point(83, 74);
			this.label_ODName.Name = "label_ODName";
			this.label_ODName.Size = new System.Drawing.Size(71, 13);
			this.label_ODName.TabIndex = 25;
			this.label_ODName.Text = "11223344";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(7, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 16);
			this.label4.TabIndex = 24;
			this.label4.Text = "호칭경 :";
			// 
			// label_OrderQuantity
			// 
			this.label_OrderQuantity.AutoSize = true;
			this.label_OrderQuantity.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OrderQuantity.Location = new System.Drawing.Point(329, 106);
			this.label_OrderQuantity.Name = "label_OrderQuantity";
			this.label_OrderQuantity.Size = new System.Drawing.Size(71, 13);
			this.label_OrderQuantity.TabIndex = 23;
			this.label_OrderQuantity.Text = "11223344";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label18.Location = new System.Drawing.Point(253, 106);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(74, 16);
			this.label18.TabIndex = 22;
			this.label18.Text = "지시수량 :";
			// 
			// label_OrderLength
			// 
			this.label_OrderLength.AutoSize = true;
			this.label_OrderLength.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OrderLength.Location = new System.Drawing.Point(329, 90);
			this.label_OrderLength.Name = "label_OrderLength";
			this.label_OrderLength.Size = new System.Drawing.Size(71, 13);
			this.label_OrderLength.TabIndex = 21;
			this.label_OrderLength.Text = "11223344";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label20.Location = new System.Drawing.Point(253, 90);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(74, 16);
			this.label20.TabIndex = 20;
			this.label20.Text = "지시길이 :";
			// 
			// label_PlanQuantity
			// 
			this.label_PlanQuantity.AutoSize = true;
			this.label_PlanQuantity.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PlanQuantity.Location = new System.Drawing.Point(329, 74);
			this.label_PlanQuantity.Name = "label_PlanQuantity";
			this.label_PlanQuantity.Size = new System.Drawing.Size(71, 13);
			this.label_PlanQuantity.TabIndex = 19;
			this.label_PlanQuantity.Text = "11223344";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label22.Location = new System.Drawing.Point(253, 74);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(74, 16);
			this.label22.TabIndex = 18;
			this.label22.Text = "주문수량 :";
			// 
			// label_PlanLength
			// 
			this.label_PlanLength.AutoSize = true;
			this.label_PlanLength.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_PlanLength.Location = new System.Drawing.Point(329, 58);
			this.label_PlanLength.Name = "label_PlanLength";
			this.label_PlanLength.Size = new System.Drawing.Size(71, 13);
			this.label_PlanLength.TabIndex = 17;
			this.label_PlanLength.Text = "11223344";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label24.Location = new System.Drawing.Point(253, 58);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(74, 16);
			this.label24.TabIndex = 16;
			this.label24.Text = "주문길이 :";
			// 
			// label_EquipCode
			// 
			this.label_EquipCode.AutoSize = true;
			this.label_EquipCode.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_EquipCode.Location = new System.Drawing.Point(329, 10);
			this.label_EquipCode.Name = "label_EquipCode";
			this.label_EquipCode.Size = new System.Drawing.Size(71, 13);
			this.label_EquipCode.TabIndex = 15;
			this.label_EquipCode.Text = "11223344";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label26.Location = new System.Drawing.Point(253, 10);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(74, 16);
			this.label26.TabIndex = 14;
			this.label26.Text = "설비호기 :";
			// 
			// label_Remark
			// 
			this.label_Remark.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Remark.Location = new System.Drawing.Point(83, 133);
			this.label_Remark.Name = "label_Remark";
			this.label_Remark.Size = new System.Drawing.Size(563, 16);
			this.label_Remark.TabIndex = 13;
			this.label_Remark.Text = "blah.. blah.. blah.. blah.. blah.. blah..";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label16.Location = new System.Drawing.Point(7, 133);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 16);
			this.label16.TabIndex = 12;
			this.label16.Text = "비고 :";
			// 
			// label_OuterDiameter
			// 
			this.label_OuterDiameter.AutoSize = true;
			this.label_OuterDiameter.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OuterDiameter.Location = new System.Drawing.Point(83, 58);
			this.label_OuterDiameter.Name = "label_OuterDiameter";
			this.label_OuterDiameter.Size = new System.Drawing.Size(71, 13);
			this.label_OuterDiameter.TabIndex = 11;
			this.label_OuterDiameter.Text = "11223344";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label14.Location = new System.Drawing.Point(7, 58);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 16);
			this.label14.TabIndex = 10;
			this.label14.Text = "외경 :";
			// 
			// label_UseType
			// 
			this.label_UseType.AutoSize = true;
			this.label_UseType.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_UseType.Location = new System.Drawing.Point(83, 42);
			this.label_UseType.Name = "label_UseType";
			this.label_UseType.Size = new System.Drawing.Size(71, 13);
			this.label_UseType.TabIndex = 7;
			this.label_UseType.Text = "11223344";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(7, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "용도 :";
			// 
			// label_Customer
			// 
			this.label_Customer.AutoSize = true;
			this.label_Customer.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Customer.Location = new System.Drawing.Point(83, 26);
			this.label_Customer.Name = "label_Customer";
			this.label_Customer.Size = new System.Drawing.Size(71, 13);
			this.label_Customer.TabIndex = 5;
			this.label_Customer.Text = "11223344";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(7, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "거래처 :";
			// 
			// label_DeliveryDate
			// 
			this.label_DeliveryDate.AutoSize = true;
			this.label_DeliveryDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_DeliveryDate.Location = new System.Drawing.Point(83, 10);
			this.label_DeliveryDate.Name = "label_DeliveryDate";
			this.label_DeliveryDate.Size = new System.Drawing.Size(71, 13);
			this.label_DeliveryDate.TabIndex = 3;
			this.label_DeliveryDate.Text = "11223344";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(7, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "제조예정 :";
			// 
			// TaskOrderViewPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_Right);
			this.Controls.Add(this.panel_Left);
			this.Name = "TaskOrderViewPart";
			this.Size = new System.Drawing.Size(1024, 155);
			this.panel_Left.ResumeLayout(false);
			this.panel_Right.ResumeLayout(false);
			this.panel_Right.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button_WorkerChange;
		private System.Windows.Forms.Label label_Worker;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label_Qual;
		private System.Windows.Forms.Button button_EquipChange;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_ODName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label_Thickness;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_Weight;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label_EquipCode;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label_PlanLength;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label_PlanQuantity;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label_OrderLength;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label_OrderQuantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_OrderNo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label_DeliveryDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label_Customer;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label_UseType;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label_OuterDiameter;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label_Remark;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel_Right;
		private System.Windows.Forms.Panel panel_Left;
	}
}
