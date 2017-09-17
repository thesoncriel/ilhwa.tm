/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-11-22
 * Time: 오후 2:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Dialog
{
	partial class FormChainInputList
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
			this.button_MoveNext = new System.Windows.Forms.Button();
			this.button_MovePrev = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.button_OK = new System.Windows.Forms.Button();
			this.listView_InputList = new System.Windows.Forms.ListView();
			this.columnHeader_Code = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Quantity = new System.Windows.Forms.ColumnHeader();
			this.textBox_InputBarcode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_TotalQuantity = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_MoveNext
			// 
			this.button_MoveNext.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext.Location = new System.Drawing.Point(476, 270);
			this.button_MoveNext.Name = "button_MoveNext";
			this.button_MoveNext.Size = new System.Drawing.Size(51, 118);
			this.button_MoveNext.TabIndex = 12;
			this.button_MoveNext.Text = "▼";
			this.button_MoveNext.UseVisualStyleBackColor = true;
			this.button_MoveNext.Click += new System.EventHandler(this.Button_MoveNextClick);
			// 
			// button_MovePrev
			// 
			this.button_MovePrev.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev.Location = new System.Drawing.Point(476, 104);
			this.button_MovePrev.Name = "button_MovePrev";
			this.button_MovePrev.Size = new System.Drawing.Size(51, 118);
			this.button_MovePrev.TabIndex = 11;
			this.button_MovePrev.Text = "▲";
			this.button_MovePrev.UseVisualStyleBackColor = true;
			this.button_MovePrev.Click += new System.EventHandler(this.Button_MovePrevClick);
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Cancel.Location = new System.Drawing.Point(198, 407);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(94, 35);
			this.button_Cancel.TabIndex = 10;
			this.button_Cancel.Text = "취소";
			this.button_Cancel.UseVisualStyleBackColor = true;
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_OK.Location = new System.Drawing.Point(12, 407);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(90, 35);
			this.button_OK.TabIndex = 9;
			this.button_OK.Text = "확인";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.Button_OKClick);
			// 
			// listView_InputList
			// 
			this.listView_InputList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader_Code,
									this.columnHeader_Quantity});
			this.listView_InputList.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listView_InputList.FullRowSelect = true;
			this.listView_InputList.GridLines = true;
			listViewItem1.StateImageIndex = 0;
			this.listView_InputList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1,
									listViewItem2,
									listViewItem3,
									listViewItem4,
									listViewItem5});
			this.listView_InputList.Location = new System.Drawing.Point(12, 104);
			this.listView_InputList.MultiSelect = false;
			this.listView_InputList.Name = "listView_InputList";
			this.listView_InputList.Size = new System.Drawing.Size(458, 284);
			this.listView_InputList.TabIndex = 8;
			this.listView_InputList.UseCompatibleStateImageBehavior = false;
			this.listView_InputList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader_Code
			// 
			this.columnHeader_Code.Text = "바코드";
			this.columnHeader_Code.Width = 344;
			// 
			// columnHeader_Quantity
			// 
			this.columnHeader_Quantity.Text = "개수";
			this.columnHeader_Quantity.Width = 70;
			// 
			// textBox_InputBarcode
			// 
			this.textBox_InputBarcode.Font = new System.Drawing.Font("굴림", 18F);
			this.textBox_InputBarcode.Location = new System.Drawing.Point(12, 35);
			this.textBox_InputBarcode.Name = "textBox_InputBarcode";
			this.textBox_InputBarcode.Size = new System.Drawing.Size(354, 35);
			this.textBox_InputBarcode.TabIndex = 13;
			this.textBox_InputBarcode.Click += new System.EventHandler(this.TextBox_InputBarcodeClick);
			this.textBox_InputBarcode.TextChanged += new System.EventHandler(this.TextBox_InputBarcodeTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "바코드 입력";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(345, 413);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "총 개수: ";
			// 
			// label_TotalQuantity
			// 
			this.label_TotalQuantity.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
			this.label_TotalQuantity.Location = new System.Drawing.Point(436, 413);
			this.label_TotalQuantity.Name = "label_TotalQuantity";
			this.label_TotalQuantity.Size = new System.Drawing.Size(94, 23);
			this.label_TotalQuantity.TabIndex = 16;
			this.label_TotalQuantity.Text = "0";
			// 
			// FormChainInputList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 451);
			this.Controls.Add(this.label_TotalQuantity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_InputBarcode);
			this.Controls.Add(this.button_MoveNext);
			this.Controls.Add(this.button_MovePrev);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.listView_InputList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormChainInputList";
			this.Text = "FormChainInputList";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label_TotalQuantity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_InputBarcode;
		private System.Windows.Forms.ColumnHeader columnHeader_Quantity;
		private System.Windows.Forms.ColumnHeader columnHeader_Code;
		private System.Windows.Forms.ListView listView_InputList;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_MovePrev;
		private System.Windows.Forms.Button button_MoveNext;
	}
}
