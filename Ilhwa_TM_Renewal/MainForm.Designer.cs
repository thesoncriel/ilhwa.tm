﻿/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-20
 * Time: 오후 4:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa
{
	partial class MainForm
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
			this.panel_Bottom = new System.Windows.Forms.Panel();
			this.button_Republish = new System.Windows.Forms.Button();
			this.button_Config = new System.Windows.Forms.Button();
			this.button_OtherProdEnter = new System.Windows.Forms.Button();
			this.label_Notice = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel_Bottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Bottom
			// 
			this.panel_Bottom.Controls.Add(this.button_Republish);
			this.panel_Bottom.Controls.Add(this.button_Config);
			this.panel_Bottom.Controls.Add(this.button_OtherProdEnter);
			this.panel_Bottom.Controls.Add(this.label_Notice);
			this.panel_Bottom.Controls.Add(this.label1);
			this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_Bottom.Location = new System.Drawing.Point(0, 718);
			this.panel_Bottom.Name = "panel_Bottom";
			this.panel_Bottom.Size = new System.Drawing.Size(1024, 50);
			this.panel_Bottom.TabIndex = 2;
			// 
			// button_Republish
			// 
			this.button_Republish.Location = new System.Drawing.Point(851, 0);
			this.button_Republish.Name = "button_Republish";
			this.button_Republish.Size = new System.Drawing.Size(87, 47);
			this.button_Republish.TabIndex = 4;
			this.button_Republish.Text = "재발행";
			this.button_Republish.UseVisualStyleBackColor = true;
			this.button_Republish.Click += new System.EventHandler(this.Button_RepublishClick);
			// 
			// button_Config
			// 
			this.button_Config.Location = new System.Drawing.Point(940, 0);
			this.button_Config.Name = "button_Config";
			this.button_Config.Size = new System.Drawing.Size(81, 47);
			this.button_Config.TabIndex = 3;
			this.button_Config.Text = "설정";
			this.button_Config.UseVisualStyleBackColor = true;
			this.button_Config.Click += new System.EventHandler(this.Button_ConfigClick);
			// 
			// button_OtherProdEnter
			// 
			this.button_OtherProdEnter.Location = new System.Drawing.Point(764, 0);
			this.button_OtherProdEnter.Name = "button_OtherProdEnter";
			this.button_OtherProdEnter.Size = new System.Drawing.Size(85, 47);
			this.button_OtherProdEnter.TabIndex = 2;
			this.button_OtherProdEnter.Text = "외주입고";
			this.button_OtherProdEnter.UseVisualStyleBackColor = true;
			this.button_OtherProdEnter.Click += new System.EventHandler(this.Button_OtherProdEnterClick);
			// 
			// label_Notice
			// 
			this.label_Notice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Notice.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Notice.Location = new System.Drawing.Point(61, 0);
			this.label_Notice.Name = "label_Notice";
			this.label_Notice.Size = new System.Drawing.Size(703, 47);
			this.label_Notice.TabIndex = 1;
			this.label_Notice.Text = "알림";
			this.label_Notice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "알림";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.panel_Bottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.Text = "Ilhwa_TM_Renewal";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel_Bottom.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_Republish;
		private System.Windows.Forms.Button button_OtherProdEnter;
		private System.Windows.Forms.Button button_Config;
		private System.Windows.Forms.Label label_Notice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel_Bottom;
	}
}
