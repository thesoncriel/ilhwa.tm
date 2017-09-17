/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-23
 * Time: 오전 9:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
{
	partial class FormTaskProcessList
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
			this.label1 = new System.Windows.Forms.Label();
			this.label_OrderNo = new System.Windows.Forms.Label();
			this.button_GotoTaskOrderList = new System.Windows.Forms.Button();
			this.taskOrderView_Label = new Artn.Ilhwa.View.TaskOrderView();
			this.taskOrderView_Data = new Artn.Ilhwa.View.TaskOrderView();
			this.taskProcessViewList = new Artn.Ilhwa.View.TaskProcessViewList();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "작업지시번호 :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_OrderNo
			// 
			this.label_OrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_OrderNo.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_OrderNo.Location = new System.Drawing.Point(146, 9);
			this.label_OrderNo.Name = "label_OrderNo";
			this.label_OrderNo.Size = new System.Drawing.Size(254, 50);
			this.label_OrderNo.TabIndex = 1;
			this.label_OrderNo.Text = "12807028";
			this.label_OrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_GotoTaskOrderList
			// 
			this.button_GotoTaskOrderList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_GotoTaskOrderList.Location = new System.Drawing.Point(846, 11);
			this.button_GotoTaskOrderList.Name = "button_GotoTaskOrderList";
			this.button_GotoTaskOrderList.Size = new System.Drawing.Size(150, 50);
			this.button_GotoTaskOrderList.TabIndex = 2;
			this.button_GotoTaskOrderList.Text = "작업조회";
			this.button_GotoTaskOrderList.UseVisualStyleBackColor = true;
			this.button_GotoTaskOrderList.Click += new System.EventHandler(this.Button_GotoTaskOrderListClick);
			// 
			// taskOrderView_Label
			// 
			this.taskOrderView_Label.Checked = false;
			this.taskOrderView_Label.CheckingAbility = true;
			this.taskOrderView_Label.ForeColor = System.Drawing.Color.White;
			this.taskOrderView_Label.LabelMode = true;
			this.taskOrderView_Label.Location = new System.Drawing.Point(2, 67);
			this.taskOrderView_Label.Name = "taskOrderView_Label";
			this.taskOrderView_Label.Size = new System.Drawing.Size(1024, 70);
			this.taskOrderView_Label.TabIndex = 3;
			this.taskOrderView_Label.ViewData = null;
			// 
			// taskOrderView_Data
			// 
			this.taskOrderView_Data.Checked = false;
			this.taskOrderView_Data.CheckingAbility = true;
			this.taskOrderView_Data.LabelMode = false;
			this.taskOrderView_Data.Location = new System.Drawing.Point(2, 135);
			this.taskOrderView_Data.Name = "taskOrderView_Data";
			this.taskOrderView_Data.Size = new System.Drawing.Size(1024, 70);
			this.taskOrderView_Data.TabIndex = 4;
			this.taskOrderView_Data.ViewData = null;
			// 
			// taskProcessViewList
			// 
			this.taskProcessViewList.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.taskProcessViewList.Location = new System.Drawing.Point(-2, 206);
			this.taskProcessViewList.Name = "taskProcessViewList";
			this.taskProcessViewList.Size = new System.Drawing.Size(1024, 365);
			this.taskProcessViewList.TabIndex = 5;
			this.taskProcessViewList.ViewData = null;
			this.taskProcessViewList.LogMessage += new Theson.Common.LogEventHandler(this.TaskProcessViewListLogMessage);
			this.taskProcessViewList.ItemSelected += new Artn.Ilhwa.View.DataViewEventHandler(this.TaskProcessViewListItemSelected);
			// 
			// FormTaskProcessList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 550);
			this.ControlBox = false;
			this.Controls.Add(this.taskProcessViewList);
			this.Controls.Add(this.taskOrderView_Data);
			this.Controls.Add(this.taskOrderView_Label);
			this.Controls.Add(this.button_GotoTaskOrderList);
			this.Controls.Add(this.label_OrderNo);
			this.Controls.Add(this.label1);
			this.Name = "FormTaskProcessList";
			this.Text = "TaskProcessListForm";
			this.ResumeLayout(false);
		}
		private Artn.Ilhwa.View.TaskProcessViewList taskProcessViewList;
		private Artn.Ilhwa.View.TaskOrderView taskOrderView_Data;
		private Artn.Ilhwa.View.TaskOrderView taskOrderView_Label;
		private System.Windows.Forms.Label label_OrderNo;
		private System.Windows.Forms.Button button_GotoTaskOrderList;
		private System.Windows.Forms.Label label1;
	}
}
