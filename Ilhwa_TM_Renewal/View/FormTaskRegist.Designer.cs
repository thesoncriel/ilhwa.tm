using Artn.Ilhwa.Model;
/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오전 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class FormTaskRegist
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
			this.taskOrderViewPart = new Artn.Ilhwa.View.TaskOrderViewPart();
			this.taskProcessViewPart = new Artn.Ilhwa.View.TaskProcessViewPart();
			this.taskMaterialsViewPart = new Artn.Ilhwa.View.TasRegistPart.TaskMaterialsViewPart();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button_GoToTaskOrderList = new System.Windows.Forms.Button();
			this.button_GoToTaskProcessList = new System.Windows.Forms.Button();
			this.button_ProcessComplete = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// taskOrderViewPart
			// 
			this.taskOrderViewPart.Location = new System.Drawing.Point(0, 64);
			this.taskOrderViewPart.Name = "taskOrderViewPart";
			this.taskOrderViewPart.Size = new System.Drawing.Size(1024, 160);
			this.taskOrderViewPart.TabIndex = 0;
			this.taskOrderViewPart.ViewData = null;
			this.taskOrderViewPart.LogMessage += new Theson.Common.LogEventHandler(this.ViewPartLogMessage);
			this.taskOrderViewPart.ViewDataChange += new Theson.Common.StringTransEventHandler(this.SubViewDataChange);
			// 
			// taskProcessViewPart
			// 
			this.taskProcessViewPart.Location = new System.Drawing.Point(0, 218);
			this.taskProcessViewPart.Name = "taskProcessViewPart";
			this.taskProcessViewPart.Size = new System.Drawing.Size(1024, 101);
			this.taskProcessViewPart.TabIndex = 1;
			this.taskProcessViewPart.ViewData = null;
			this.taskProcessViewPart.AddProdClick += new System.EventHandler(this.TaskProcessViewPartAddProdClick);
			this.taskProcessViewPart.WasteInsertClick += new System.EventHandler(this.TaskProcessViewPartWasteInsertClick);
			this.taskProcessViewPart.BadInsertClick += new System.EventHandler(this.TaskProcessViewPartBadInsertClick);
			this.taskProcessViewPart.LogMessage += new Theson.Common.LogEventHandler(this.ViewPartLogMessage);
			this.taskProcessViewPart.ViewDataChange += new Theson.Common.StringTransEventHandler(this.SubViewDataChange);
			// 
			// taskMaterialsViewPart
			// 
			this.taskMaterialsViewPart.BarcodeVisible = true;
			this.taskMaterialsViewPart.Location = new System.Drawing.Point(0, 317);
			this.taskMaterialsViewPart.MaterialManage = true;
			this.taskMaterialsViewPart.MaterialRemaining = 0D;
			this.taskMaterialsViewPart.Name = "taskMaterialsViewPart";
			this.taskMaterialsViewPart.PrintProdQty = 0;
			this.taskMaterialsViewPart.PrintRemainQty = 0;
			this.taskMaterialsViewPart.Size = new System.Drawing.Size(1024, 220);
			this.taskMaterialsViewPart.TabIndex = 2;
			this.taskMaterialsViewPart.TransformType = Artn.Ilhwa.Model.TaskType.MaterialProdInfo;
			this.taskMaterialsViewPart.ViewData = null;
			this.taskMaterialsViewPart.AddMaterialClick += new System.EventHandler(this.TaskMaterialsViewPartAddMaterialClick);
			this.taskMaterialsViewPart.RegistRemainingClick += new System.EventHandler(this.TaskMaterialsViewPartRegistRemainingClick);
			this.taskMaterialsViewPart.PrintProductClick += new System.EventHandler(this.TaskMaterialsViewPartBarcodePrintClick);
			this.taskMaterialsViewPart.PrintRemainingClick += new System.EventHandler(this.TaskMaterialsViewPartRegistRemainingClick);
			this.taskMaterialsViewPart.ChainInputClick += new System.EventHandler(this.TaskMaterialsViewPartChainInputClick);
			this.taskMaterialsViewPart.LogMessage += new Theson.Common.LogEventHandler(this.InputMaterialsViewPart1LogMessage);
			this.taskMaterialsViewPart.ViewDataChange += new Theson.Common.StringTransEventHandler(this.SubViewDataChange);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button_GoToTaskOrderList);
			this.panel2.Controls.Add(this.button_GoToTaskProcessList);
			this.panel2.Controls.Add(this.button_ProcessComplete);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1019, 65);
			this.panel2.TabIndex = 6;
			// 
			// button_GoToTaskOrderList
			// 
			this.button_GoToTaskOrderList.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_GoToTaskOrderList.Location = new System.Drawing.Point(716, 5);
			this.button_GoToTaskOrderList.Name = "button_GoToTaskOrderList";
			this.button_GoToTaskOrderList.Size = new System.Drawing.Size(130, 55);
			this.button_GoToTaskOrderList.TabIndex = 34;
			this.button_GoToTaskOrderList.Text = "작업조회";
			this.button_GoToTaskOrderList.UseVisualStyleBackColor = true;
			this.button_GoToTaskOrderList.Click += new System.EventHandler(this.Button_GoToScreenClick);
			// 
			// button_GoToTaskProcessList
			// 
			this.button_GoToTaskProcessList.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_GoToTaskProcessList.Location = new System.Drawing.Point(881, 5);
			this.button_GoToTaskProcessList.Name = "button_GoToTaskProcessList";
			this.button_GoToTaskProcessList.Size = new System.Drawing.Size(130, 55);
			this.button_GoToTaskProcessList.TabIndex = 33;
			this.button_GoToTaskProcessList.Text = "공정선택";
			this.button_GoToTaskProcessList.UseVisualStyleBackColor = true;
			this.button_GoToTaskProcessList.Click += new System.EventHandler(this.Button_GoToScreenClick);
			// 
			// button_ProcessComplete
			// 
			this.button_ProcessComplete.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_ProcessComplete.Location = new System.Drawing.Point(152, 3);
			this.button_ProcessComplete.Name = "button_ProcessComplete";
			this.button_ProcessComplete.Size = new System.Drawing.Size(130, 55);
			this.button_ProcessComplete.TabIndex = 32;
			this.button_ProcessComplete.Text = "공정완료";
			this.button_ProcessComplete.UseVisualStyleBackColor = true;
			this.button_ProcessComplete.Click += new System.EventHandler(this.Button_ProcessCompleteClick);
			// 
			// FormTaskRegist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 587);
			this.ControlBox = false;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.taskMaterialsViewPart);
			this.Controls.Add(this.taskProcessViewPart);
			this.Controls.Add(this.taskOrderViewPart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormTaskRegist";
			this.Text = "FormTaskProcessRegist";
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_GoToTaskOrderList;
		private System.Windows.Forms.Button button_ProcessComplete;
		private System.Windows.Forms.Button button_GoToTaskProcessList;
		private System.Windows.Forms.Panel panel2;
		private Artn.Ilhwa.View.TasRegistPart.TaskMaterialsViewPart taskMaterialsViewPart;
		private Artn.Ilhwa.View.TaskProcessViewPart taskProcessViewPart;
		private Artn.Ilhwa.View.TaskOrderViewPart taskOrderViewPart;
	}
}
