using Artn.Ilhwa.Model;
/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-26
 * Time: 오전 9:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.TasRegistPart
{
	partial class TaskMaterialsViewPart
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
			this.label_ViewTitle = new System.Windows.Forms.Label();
			this.panel_Right = new System.Windows.Forms.Panel();
			this.button_PrintRemain = new System.Windows.Forms.Button();
			this.button_PrintProduct = new System.Windows.Forms.Button();
			this.barcodePrinterViewPart = new Artn.Ilhwa.View.TasRegistPart.BarcodePrinterViewPart();
			this.label_RemainingLabel = new System.Windows.Forms.Label();
			this.label_Remaining = new System.Windows.Forms.Label();
			this.inputStatusListViewPart = new Artn.Ilhwa.View.TasRegistPart.InputStatusListViewPart();
			this.findMaterialsViewPart = new Artn.Ilhwa.View.FindMaterialsViewPart();
			this.button_RegistRemaining = new System.Windows.Forms.Button();
			this.button_AddMaterial = new System.Windows.Forms.Button();
			this.panel_Left.SuspendLayout();
			this.panel_Right.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Left
			// 
			this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Left.Controls.Add(this.label_ViewTitle);
			this.panel_Left.Location = new System.Drawing.Point(0, 0);
			this.panel_Left.Name = "panel_Left";
			this.panel_Left.Size = new System.Drawing.Size(150, 220);
			this.panel_Left.TabIndex = 4;
			// 
			// label_ViewTitle
			// 
			this.label_ViewTitle.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_ViewTitle.Location = new System.Drawing.Point(13, 10);
			this.label_ViewTitle.Name = "label_ViewTitle";
			this.label_ViewTitle.Size = new System.Drawing.Size(122, 48);
			this.label_ViewTitle.TabIndex = 0;
			this.label_ViewTitle.Text = "자재투입";
			this.label_ViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel_Right
			// 
			this.panel_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Right.Controls.Add(this.button_PrintRemain);
			this.panel_Right.Controls.Add(this.button_PrintProduct);
			this.panel_Right.Controls.Add(this.barcodePrinterViewPart);
			this.panel_Right.Controls.Add(this.label_RemainingLabel);
			this.panel_Right.Controls.Add(this.label_Remaining);
			this.panel_Right.Controls.Add(this.inputStatusListViewPart);
			this.panel_Right.Controls.Add(this.findMaterialsViewPart);
			this.panel_Right.Controls.Add(this.button_RegistRemaining);
			this.panel_Right.Controls.Add(this.button_AddMaterial);
			this.panel_Right.Location = new System.Drawing.Point(149, 0);
			this.panel_Right.Name = "panel_Right";
			this.panel_Right.Size = new System.Drawing.Size(870, 220);
			this.panel_Right.TabIndex = 5;
			// 
			// button_PrintRemain
			// 
			this.button_PrintRemain.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_PrintRemain.Location = new System.Drawing.Point(369, 120);
			this.button_PrintRemain.Name = "button_PrintRemain";
			this.button_PrintRemain.Size = new System.Drawing.Size(130, 80);
			this.button_PrintRemain.TabIndex = 40;
			this.button_PrintRemain.Text = "재고포장";
			this.button_PrintRemain.UseVisualStyleBackColor = true;
			this.button_PrintRemain.Click += new System.EventHandler(this.OnPrintRemainingClick);
			// 
			// button_PrintProduct
			// 
			this.button_PrintProduct.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_PrintProduct.Location = new System.Drawing.Point(369, 11);
			this.button_PrintProduct.Name = "button_PrintProduct";
			this.button_PrintProduct.Size = new System.Drawing.Size(130, 80);
			this.button_PrintProduct.TabIndex = 39;
			this.button_PrintProduct.Text = "주문포장";
			this.button_PrintProduct.UseVisualStyleBackColor = true;
			this.button_PrintProduct.Click += new System.EventHandler(this.OnPrintProductClick);
			// 
			// barcodePrinterViewPart
			// 
			this.barcodePrinterViewPart.Location = new System.Drawing.Point(10, 8);
			this.barcodePrinterViewPart.Name = "barcodePrinterViewPart";
			this.barcodePrinterViewPart.PrintProdQty = 0;
			this.barcodePrinterViewPart.PrintRemainQty = 0;
			this.barcodePrinterViewPart.Size = new System.Drawing.Size(353, 200);
			this.barcodePrinterViewPart.TabIndex = 38;
			this.barcodePrinterViewPart.ViewData = null;
			// 
			// label_RemainingLabel
			// 
			this.label_RemainingLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_RemainingLabel.Location = new System.Drawing.Point(551, 187);
			this.label_RemainingLabel.Name = "label_RemainingLabel";
			this.label_RemainingLabel.Size = new System.Drawing.Size(141, 23);
			this.label_RemainingLabel.TabIndex = 37;
			this.label_RemainingLabel.Text = "예상 잔량";
			this.label_RemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_Remaining
			// 
			this.label_Remaining.BackColor = System.Drawing.Color.Transparent;
			this.label_Remaining.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Remaining.Location = new System.Drawing.Point(694, 179);
			this.label_Remaining.Name = "label_Remaining";
			this.label_Remaining.Size = new System.Drawing.Size(115, 37);
			this.label_Remaining.TabIndex = 36;
			this.label_Remaining.Text = "999";
			this.label_Remaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// inputStatusListViewPart
			// 
			this.inputStatusListViewPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inputStatusListViewPart.Location = new System.Drawing.Point(505, 10);
			this.inputStatusListViewPart.Name = "inputStatusListViewPart";
			this.inputStatusListViewPart.Size = new System.Drawing.Size(360, 166);
			this.inputStatusListViewPart.TabIndex = 35;
			this.inputStatusListViewPart.ViewData = null;
			this.inputStatusListViewPart.InputListClick += new System.EventHandler(this.OnChainInputClick);
			// 
			// findMaterialsViewPart
			// 
			this.findMaterialsViewPart.Location = new System.Drawing.Point(10, 0);
			this.findMaterialsViewPart.Name = "findMaterialsViewPart";
			this.findMaterialsViewPart.Size = new System.Drawing.Size(353, 200);
			this.findMaterialsViewPart.TabIndex = 34;
			this.findMaterialsViewPart.TransformType = Artn.Ilhwa.Model.TaskType.MaterialProdInfo;
			this.findMaterialsViewPart.ViewData = null;
			this.findMaterialsViewPart.CodeChanged += new Theson.Common.StringTransEventHandler(this.FindMaterialsViewPartCodeChanged);
			this.findMaterialsViewPart.LogMessage += new Theson.Common.LogEventHandler(this.OnLogMessage);
			// 
			// button_RegistRemaining
			// 
			this.button_RegistRemaining.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_RegistRemaining.Location = new System.Drawing.Point(369, 120);
			this.button_RegistRemaining.Name = "button_RegistRemaining";
			this.button_RegistRemaining.Size = new System.Drawing.Size(130, 80);
			this.button_RegistRemaining.TabIndex = 33;
			this.button_RegistRemaining.Text = "잔량등록";
			this.button_RegistRemaining.UseVisualStyleBackColor = true;
			this.button_RegistRemaining.Click += new System.EventHandler(this.Button_RegistRemainingClick);
			// 
			// button_AddMaterial
			// 
			this.button_AddMaterial.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_AddMaterial.Location = new System.Drawing.Point(369, 10);
			this.button_AddMaterial.Name = "button_AddMaterial";
			this.button_AddMaterial.Size = new System.Drawing.Size(130, 80);
			this.button_AddMaterial.TabIndex = 31;
			this.button_AddMaterial.Text = "자재등록";
			this.button_AddMaterial.UseVisualStyleBackColor = true;
			this.button_AddMaterial.Click += new System.EventHandler(this.Button_AddMaterialClick);
			// 
			// TaskMaterialsViewPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_Left);
			this.Controls.Add(this.panel_Right);
			this.Name = "TaskMaterialsViewPart";
			this.Size = new System.Drawing.Size(1024, 220);
			this.panel_Left.ResumeLayout(false);
			this.panel_Right.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_PrintRemain;
		private System.Windows.Forms.Button button_PrintProduct;
		private Artn.Ilhwa.View.TasRegistPart.BarcodePrinterViewPart barcodePrinterViewPart;
		private System.Windows.Forms.Button button_AddMaterial;
		private System.Windows.Forms.Label label_Remaining;
		private System.Windows.Forms.Label label_RemainingLabel;
		private Artn.Ilhwa.View.TasRegistPart.InputStatusListViewPart inputStatusListViewPart;
		private Artn.Ilhwa.View.FindMaterialsViewPart findMaterialsViewPart;
		private System.Windows.Forms.Button button_RegistRemaining;
		private System.Windows.Forms.Panel panel_Right;
		private System.Windows.Forms.Label label_ViewTitle;
		private System.Windows.Forms.Panel panel_Left;
	}
}
