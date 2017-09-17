/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-06-05
 * Time: 오후 1:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.POP
{
	partial class TaskCurrentSearchView
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
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_OuterDiameterTo = new System.Windows.Forms.ComboBox();
			this.comboBox_OuterDiameterFrom = new System.Windows.Forms.ComboBox();
			this.label_OuterDiameter = new System.Windows.Forms.Label();
			this.comboBox_Spec = new System.Windows.Forms.ComboBox();
			this.label_Spec = new System.Windows.Forms.Label();
			this.comboBox_Quality = new System.Windows.Forms.ComboBox();
			this.label_Quality = new System.Windows.Forms.Label();
			this.label_LEN = new System.Windows.Forms.Label();
			this.checkBox_4M = new System.Windows.Forms.CheckBox();
			this.checkBox_6M = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(603, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 21);
			this.label4.TabIndex = 15;
			this.label4.Text = "~";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox_OuterDiameterTo
			// 
			this.comboBox_OuterDiameterTo.FormattingEnabled = true;
			this.comboBox_OuterDiameterTo.Location = new System.Drawing.Point(626, 13);
			this.comboBox_OuterDiameterTo.Name = "comboBox_OuterDiameterTo";
			this.comboBox_OuterDiameterTo.Size = new System.Drawing.Size(141, 20);
			this.comboBox_OuterDiameterTo.TabIndex = 14;
			this.comboBox_OuterDiameterTo.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// comboBox_OuterDiameterFrom
			// 
			this.comboBox_OuterDiameterFrom.FormattingEnabled = true;
			this.comboBox_OuterDiameterFrom.Location = new System.Drawing.Point(454, 13);
			this.comboBox_OuterDiameterFrom.Name = "comboBox_OuterDiameterFrom";
			this.comboBox_OuterDiameterFrom.Size = new System.Drawing.Size(141, 20);
			this.comboBox_OuterDiameterFrom.TabIndex = 13;
			this.comboBox_OuterDiameterFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label_OuterDiameter
			// 
			this.label_OuterDiameter.Location = new System.Drawing.Point(403, 13);
			this.label_OuterDiameter.Name = "label_OuterDiameter";
			this.label_OuterDiameter.Size = new System.Drawing.Size(57, 21);
			this.label_OuterDiameter.TabIndex = 12;
			this.label_OuterDiameter.Text = "외경 : ";
			this.label_OuterDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox_Spec
			// 
			this.comboBox_Spec.FormattingEnabled = true;
			this.comboBox_Spec.Location = new System.Drawing.Point(254, 14);
			this.comboBox_Spec.Name = "comboBox_Spec";
			this.comboBox_Spec.Size = new System.Drawing.Size(141, 20);
			this.comboBox_Spec.TabIndex = 11;
			this.comboBox_Spec.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label_Spec
			// 
			this.label_Spec.Location = new System.Drawing.Point(202, 14);
			this.label_Spec.Name = "label_Spec";
			this.label_Spec.Size = new System.Drawing.Size(57, 21);
			this.label_Spec.TabIndex = 10;
			this.label_Spec.Text = "SPEC : ";
			this.label_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox_Quality
			// 
			this.comboBox_Quality.FormattingEnabled = true;
			this.comboBox_Quality.Location = new System.Drawing.Point(75, 14);
			this.comboBox_Quality.Name = "comboBox_Quality";
			this.comboBox_Quality.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Quality.TabIndex = 9;
			this.comboBox_Quality.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label_Quality
			// 
			this.label_Quality.Location = new System.Drawing.Point(32, 14);
			this.label_Quality.Name = "label_Quality";
			this.label_Quality.Size = new System.Drawing.Size(46, 21);
			this.label_Quality.TabIndex = 8;
			this.label_Quality.Text = "강종 : ";
			this.label_Quality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_LEN
			// 
			this.label_LEN.Location = new System.Drawing.Point(793, 13);
			this.label_LEN.Name = "label_LEN";
			this.label_LEN.Size = new System.Drawing.Size(57, 21);
			this.label_LEN.TabIndex = 16;
			this.label_LEN.Text = "길이 : ";
			this.label_LEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox_4M
			// 
			this.checkBox_4M.Location = new System.Drawing.Point(857, 11);
			this.checkBox_4M.Name = "checkBox_4M";
			this.checkBox_4M.Size = new System.Drawing.Size(51, 24);
			this.checkBox_4M.TabIndex = 17;
			this.checkBox_4M.Text = "4M";
			this.checkBox_4M.UseVisualStyleBackColor = true;
			// 
			// checkBox_6M
			// 
			this.checkBox_6M.Location = new System.Drawing.Point(914, 10);
			this.checkBox_6M.Name = "checkBox_6M";
			this.checkBox_6M.Size = new System.Drawing.Size(51, 24);
			this.checkBox_6M.TabIndex = 18;
			this.checkBox_6M.Text = "6M";
			this.checkBox_6M.UseVisualStyleBackColor = true;
			// 
			// TaskCurrentSearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBox_6M);
			this.Controls.Add(this.checkBox_4M);
			this.Controls.Add(this.label_LEN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox_OuterDiameterTo);
			this.Controls.Add(this.comboBox_OuterDiameterFrom);
			this.Controls.Add(this.label_OuterDiameter);
			this.Controls.Add(this.comboBox_Spec);
			this.Controls.Add(this.label_Spec);
			this.Controls.Add(this.comboBox_Quality);
			this.Controls.Add(this.label_Quality);
			this.Name = "TaskCurrentSearchView";
			this.Size = new System.Drawing.Size(1100, 52);
			this.Load += new System.EventHandler(this.TaskCurrentSearchLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkBox_6M;
		private System.Windows.Forms.CheckBox checkBox_4M;
		private System.Windows.Forms.Label label_LEN;
		private System.Windows.Forms.Label label_Quality;
		private System.Windows.Forms.ComboBox comboBox_Quality;
		private System.Windows.Forms.Label label_Spec;
		private System.Windows.Forms.ComboBox comboBox_Spec;
		private System.Windows.Forms.Label label_OuterDiameter;
		private System.Windows.Forms.ComboBox comboBox_OuterDiameterFrom;
		private System.Windows.Forms.ComboBox comboBox_OuterDiameterTo;
		private System.Windows.Forms.Label label4;
	}
}
