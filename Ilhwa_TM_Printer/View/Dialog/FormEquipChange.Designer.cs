/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오후 12:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.TasRegistPart
{
	partial class FormEquipChange
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ddd");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("asdss");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("dfdfdf");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("aaa");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ㄴㄹㄴㄹㄴㄹ");
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_CurrEquipCode = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.listView_NextEquipCode = new System.Windows.Forms.ListView();
			this.columnHeader_Code = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Name = new System.Windows.Forms.ColumnHeader();
			this.button_MovePrev = new System.Windows.Forms.Button();
			this.button_MoveNext = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "지정설비";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "변경설비";
			// 
			// label_CurrEquipCode
			// 
			this.label_CurrEquipCode.BackColor = System.Drawing.Color.White;
			this.label_CurrEquipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_CurrEquipCode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_CurrEquipCode.Location = new System.Drawing.Point(12, 38);
			this.label_CurrEquipCode.Name = "label_CurrEquipCode";
			this.label_CurrEquipCode.Size = new System.Drawing.Size(200, 30);
			this.label_CurrEquipCode.TabIndex = 2;
			this.label_CurrEquipCode.Text = "CM13";
			this.label_CurrEquipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_OK.Location = new System.Drawing.Point(12, 399);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(90, 35);
			this.button_OK.TabIndex = 4;
			this.button_OK.Text = "확인";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(198, 399);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(94, 35);
			this.button_Cancel.TabIndex = 5;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// listView_NextEquipCode
			// 
			this.listView_NextEquipCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader_Code,
									this.columnHeader_Name});
			this.listView_NextEquipCode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listView_NextEquipCode.FullRowSelect = true;
			this.listView_NextEquipCode.GridLines = true;
			listViewItem1.StateImageIndex = 0;
			this.listView_NextEquipCode.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1,
									listViewItem2,
									listViewItem3,
									listViewItem4,
									listViewItem5});
			this.listView_NextEquipCode.Location = new System.Drawing.Point(12, 96);
			this.listView_NextEquipCode.MultiSelect = false;
			this.listView_NextEquipCode.Name = "listView_NextEquipCode";
			this.listView_NextEquipCode.Size = new System.Drawing.Size(458, 284);
			this.listView_NextEquipCode.TabIndex = 3;
			this.listView_NextEquipCode.UseCompatibleStateImageBehavior = false;
			this.listView_NextEquipCode.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader_Code
			// 
			this.columnHeader_Code.Text = "코드";
			this.columnHeader_Code.Width = 83;
			// 
			// columnHeader_Name
			// 
			this.columnHeader_Name.Text = "설비명";
			this.columnHeader_Name.Width = 369;
			// 
			// button_MovePrev
			// 
			this.button_MovePrev.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev.Location = new System.Drawing.Point(476, 96);
			this.button_MovePrev.Name = "button_MovePrev";
			this.button_MovePrev.Size = new System.Drawing.Size(51, 118);
			this.button_MovePrev.TabIndex = 6;
			this.button_MovePrev.Text = "▲";
			this.button_MovePrev.UseVisualStyleBackColor = true;
			this.button_MovePrev.Click += new System.EventHandler(this.Button_MovePrevClick);
			// 
			// button_MoveNext
			// 
			this.button_MoveNext.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext.Location = new System.Drawing.Point(476, 262);
			this.button_MoveNext.Name = "button_MoveNext";
			this.button_MoveNext.Size = new System.Drawing.Size(51, 118);
			this.button_MoveNext.TabIndex = 7;
			this.button_MoveNext.Text = "▼";
			this.button_MoveNext.UseVisualStyleBackColor = true;
			this.button_MoveNext.Click += new System.EventHandler(this.Button_MoveNextClick);
			// 
			// FormEquipChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 438);
			this.Controls.Add(this.button_MoveNext);
			this.Controls.Add(this.button_MovePrev);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.listView_NextEquipCode);
			this.Controls.Add(this.label_CurrEquipCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormEquipChange";
			this.Text = "FormEquipChange";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_MoveNext;
		private System.Windows.Forms.Button button_MovePrev;
		private System.Windows.Forms.ColumnHeader columnHeader_Name;
		private System.Windows.Forms.ColumnHeader columnHeader_Code;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.ListView listView_NextEquipCode;
		private System.Windows.Forms.Label label_CurrEquipCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
