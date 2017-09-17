/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-25
 * Time: 오후 2:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.TasRegistPart
{
	partial class InputStatusListViewPart
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
									"0841800000304PR$$$$$0016",
									"1000",
									"",
									""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))));
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
									"ㅇㅇ",
									"ㅁㅁ",
									"ㄹㄹ"}, -1);
			this.listView_InsertStatus = new System.Windows.Forms.ListView();
			this.columnHeader_RowNo = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Barcode = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Weight = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_ProdCode = new System.Windows.Forms.ColumnHeader();
			this.button_MovePrev = new System.Windows.Forms.Button();
			this.button_MoveNext = new System.Windows.Forms.Button();
			this.label_Column1 = new System.Windows.Forms.Label();
			this.label_Column2 = new System.Windows.Forms.Label();
			this.label_Column3 = new System.Windows.Forms.Label();
			this.label_Column0 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView_InsertStatus
			// 
			this.listView_InsertStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView_InsertStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader_RowNo,
									this.columnHeader_Barcode,
									this.columnHeader_Weight,
									this.columnHeader_ProdCode});
			this.listView_InsertStatus.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listView_InsertStatus.FullRowSelect = true;
			this.listView_InsertStatus.GridLines = true;
			this.listView_InsertStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_InsertStatus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1,
									listViewItem2});
			this.listView_InsertStatus.Location = new System.Drawing.Point(0, 23);
			this.listView_InsertStatus.MultiSelect = false;
			this.listView_InsertStatus.Name = "listView_InsertStatus";
			this.listView_InsertStatus.Size = new System.Drawing.Size(292, 139);
			this.listView_InsertStatus.TabIndex = 0;
			this.listView_InsertStatus.UseCompatibleStateImageBehavior = false;
			this.listView_InsertStatus.View = System.Windows.Forms.View.Details;
			this.listView_InsertStatus.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_InsertStatusItemSelectionChanged);
			this.listView_InsertStatus.SelectedIndexChanged += new System.EventHandler(this.ListView_InsertStatusSelectedIndexChanged);
			this.listView_InsertStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView_InsertStatusMouseUp);
			// 
			// columnHeader_RowNo
			// 
			this.columnHeader_RowNo.Text = "순서";
			this.columnHeader_RowNo.Width = 50;
			// 
			// columnHeader_Barcode
			// 
			this.columnHeader_Barcode.Text = "코드";
			this.columnHeader_Barcode.Width = 100;
			// 
			// columnHeader_Weight
			// 
			this.columnHeader_Weight.Text = "중량";
			this.columnHeader_Weight.Width = 70;
			// 
			// columnHeader_ProdCode
			// 
			this.columnHeader_ProdCode.Text = "강종";
			this.columnHeader_ProdCode.Width = 50;
			// 
			// button_MovePrev
			// 
			this.button_MovePrev.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev.Location = new System.Drawing.Point(293, 0);
			this.button_MovePrev.Name = "button_MovePrev";
			this.button_MovePrev.Size = new System.Drawing.Size(65, 81);
			this.button_MovePrev.TabIndex = 1;
			this.button_MovePrev.Text = "▲";
			this.button_MovePrev.UseVisualStyleBackColor = true;
			this.button_MovePrev.Click += new System.EventHandler(this.Button_MovePrevClick);
			// 
			// button_MoveNext
			// 
			this.button_MoveNext.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext.Location = new System.Drawing.Point(293, 84);
			this.button_MoveNext.Name = "button_MoveNext";
			this.button_MoveNext.Size = new System.Drawing.Size(65, 78);
			this.button_MoveNext.TabIndex = 2;
			this.button_MoveNext.Text = "▼";
			this.button_MoveNext.UseVisualStyleBackColor = true;
			this.button_MoveNext.Click += new System.EventHandler(this.Button_MoveNextClick);
			// 
			// label_Column1
			// 
			this.label_Column1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(136)))), ((int)(((byte)(131)))));
			this.label_Column1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Column1.ForeColor = System.Drawing.Color.White;
			this.label_Column1.Location = new System.Drawing.Point(51, 0);
			this.label_Column1.Name = "label_Column1";
			this.label_Column1.Size = new System.Drawing.Size(98, 23);
			this.label_Column1.TabIndex = 3;
			this.label_Column1.Text = "코드";
			// 
			// label_Column2
			// 
			this.label_Column2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(136)))), ((int)(((byte)(131)))));
			this.label_Column2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Column2.ForeColor = System.Drawing.Color.White;
			this.label_Column2.Location = new System.Drawing.Point(151, 0);
			this.label_Column2.Name = "label_Column2";
			this.label_Column2.Size = new System.Drawing.Size(69, 23);
			this.label_Column2.TabIndex = 4;
			this.label_Column2.Text = "중량";
			// 
			// label_Column3
			// 
			this.label_Column3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(136)))), ((int)(((byte)(131)))));
			this.label_Column3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Column3.ForeColor = System.Drawing.Color.White;
			this.label_Column3.Location = new System.Drawing.Point(222, 0);
			this.label_Column3.Name = "label_Column3";
			this.label_Column3.Size = new System.Drawing.Size(70, 23);
			this.label_Column3.TabIndex = 5;
			this.label_Column3.Text = "강종";
			// 
			// label_Column0
			// 
			this.label_Column0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(136)))), ((int)(((byte)(131)))));
			this.label_Column0.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label_Column0.ForeColor = System.Drawing.Color.White;
			this.label_Column0.Location = new System.Drawing.Point(-1, 0);
			this.label_Column0.Name = "label_Column0";
			this.label_Column0.Size = new System.Drawing.Size(50, 23);
			this.label_Column0.TabIndex = 6;
			this.label_Column0.Text = "순서";
			// 
			// InputStatusListViewPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.label_Column0);
			this.Controls.Add(this.label_Column3);
			this.Controls.Add(this.label_Column2);
			this.Controls.Add(this.label_Column1);
			this.Controls.Add(this.button_MoveNext);
			this.Controls.Add(this.button_MovePrev);
			this.Controls.Add(this.listView_InsertStatus);
			this.Name = "InputStatusListViewPart";
			this.Size = new System.Drawing.Size(358, 162);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_Column0;
		private System.Windows.Forms.ColumnHeader columnHeader_RowNo;
		private System.Windows.Forms.Label label_Column3;
		private System.Windows.Forms.Label label_Column2;
		private System.Windows.Forms.Label label_Column1;
		private System.Windows.Forms.Button button_MoveNext;
		private System.Windows.Forms.Button button_MovePrev;
		private System.Windows.Forms.ColumnHeader columnHeader_ProdCode;
		private System.Windows.Forms.ColumnHeader columnHeader_Weight;
		private System.Windows.Forms.ColumnHeader columnHeader_Barcode;
		private System.Windows.Forms.ListView listView_InsertStatus;
	}
}
