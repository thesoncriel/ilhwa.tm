/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-23
 * Time: 오후 4:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Pop
{
	partial class FormTaskOrderList
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
			this.taskOrderViewList = new Artn.Ilhwa.View.Pop.TaskOrderViewList();
			this.taskOrderSearchView = new Artn.Ilhwa.View.POP.TaskOrderSearchView();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// taskOrderViewList
			// 
			this.taskOrderViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.taskOrderViewList.AutoScroll = true;
			this.taskOrderViewList.Location = new System.Drawing.Point(0, 128);
			this.taskOrderViewList.Name = "taskOrderViewList";
			this.taskOrderViewList.Size = new System.Drawing.Size(1227, 426);
			this.taskOrderViewList.TabIndex = 0;
			this.taskOrderViewList.ViewData = null;
			this.taskOrderViewList.LogMessage += new Theson.Common.LogEventHandler(this.TaskOrderViewListLogMessage);
			// 
			// taskOrderSearchView
			// 
			this.taskOrderSearchView.Dock = System.Windows.Forms.DockStyle.Top;
			this.taskOrderSearchView.Location = new System.Drawing.Point(0, 0);
			this.taskOrderSearchView.Name = "taskOrderSearchView";
			this.taskOrderSearchView.Size = new System.Drawing.Size(1227, 131);
			this.taskOrderSearchView.TabIndex = 1;
			this.taskOrderSearchView.ViewData = null;
			this.taskOrderSearchView.SearchClick += new System.EventHandler(this.TaskOrderSearchViewSearchClick);
			this.taskOrderSearchView.PrintClick += new System.EventHandler(this.TaskOrderSearchViewPrintClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1089, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 50);
			this.button1.TabIndex = 2;
			this.button1.Text = "생산 재고 현황";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormTaskOrderList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1227, 554);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.taskOrderViewList);
			this.Controls.Add(this.taskOrderSearchView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormTaskOrderList";
			this.Text = "FormTaskOrderList";
			this.Activated += new System.EventHandler(this.FormTaskOrderListActivated);
			this.Load += new System.EventHandler(this.FormTaskOrderListLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private Artn.Ilhwa.View.POP.TaskOrderSearchView taskOrderSearchView;
		private Artn.Ilhwa.View.Pop.TaskOrderViewList taskOrderViewList;
	}
}
