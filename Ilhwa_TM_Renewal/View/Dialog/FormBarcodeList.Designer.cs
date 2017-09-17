/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-11-29
 * Time: 오후 9:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.Dialog
{
	partial class FormBarcodeList
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
									"2012031600304R$$$$$$0168",
									"유민스테인레스(주)",
									"201연마각PIPE",
									"연마50*70",
									"76.3",
									"1.1",
									"6000",
									"100",
									"10"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("asdss");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("dfdfdf");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("aaa");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ㄴㄹㄴㄹㄴㄹ");
			this.button_MoveNext = new System.Windows.Forms.Button();
			this.button_MovePrev = new System.Windows.Forms.Button();
			this.listView_BarcodeList = new System.Windows.Forms.ListView();
			this.columnHeader_Code = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Customer = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_ProdName = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_ODName = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_OuterDiameter = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Thickness = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Length = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_TotalQuantity = new System.Windows.Forms.ColumnHeader();
			this.columnHeader_Quantity = new System.Windows.Forms.ColumnHeader();
			this.tableLayoutPanel_ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button_SelectAll = new System.Windows.Forms.Button();
			this.button_DeselectAll = new System.Windows.Forms.Button();
			this.button_Search = new System.Windows.Forms.Button();
			this.button_Print = new System.Windows.Forms.Button();
			this.button_Close = new System.Windows.Forms.Button();
			this.tableLayoutPanel_ColumnHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_MoveNext
			// 
			this.button_MoveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_MoveNext.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext.Location = new System.Drawing.Point(968, 290);
			this.button_MoveNext.Name = "button_MoveNext";
			this.button_MoveNext.Size = new System.Drawing.Size(51, 118);
			this.button_MoveNext.TabIndex = 15;
			this.button_MoveNext.Text = "▼";
			this.button_MoveNext.UseVisualStyleBackColor = true;
			this.button_MoveNext.Click += new System.EventHandler(this.Button_MoveNextClick);
			// 
			// button_MovePrev
			// 
			this.button_MovePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_MovePrev.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev.Location = new System.Drawing.Point(968, 45);
			this.button_MovePrev.Name = "button_MovePrev";
			this.button_MovePrev.Size = new System.Drawing.Size(51, 118);
			this.button_MovePrev.TabIndex = 14;
			this.button_MovePrev.Text = "▲";
			this.button_MovePrev.UseVisualStyleBackColor = true;
			this.button_MovePrev.Click += new System.EventHandler(this.Button_MovePrevClick);
			// 
			// listView_BarcodeList
			// 
			this.listView_BarcodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView_BarcodeList.CheckBoxes = true;
			this.listView_BarcodeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader_Code,
									this.columnHeader_Customer,
									this.columnHeader_ProdName,
									this.columnHeader_ODName,
									this.columnHeader_OuterDiameter,
									this.columnHeader_Thickness,
									this.columnHeader_Length,
									this.columnHeader_TotalQuantity,
									this.columnHeader_Quantity});
			this.listView_BarcodeList.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listView_BarcodeList.FullRowSelect = true;
			this.listView_BarcodeList.GridLines = true;
			this.listView_BarcodeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_BarcodeList.HideSelection = false;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.StateImageIndex = 0;
			listViewItem3.StateImageIndex = 0;
			listViewItem4.StateImageIndex = 0;
			listViewItem5.StateImageIndex = 0;
			this.listView_BarcodeList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1,
									listViewItem2,
									listViewItem3,
									listViewItem4,
									listViewItem5});
			this.listView_BarcodeList.LabelWrap = false;
			this.listView_BarcodeList.Location = new System.Drawing.Point(9, 25);
			this.listView_BarcodeList.Margin = new System.Windows.Forms.Padding(0);
			this.listView_BarcodeList.Name = "listView_BarcodeList";
			this.listView_BarcodeList.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.listView_BarcodeList.Size = new System.Drawing.Size(956, 503);
			this.listView_BarcodeList.TabIndex = 13;
			this.listView_BarcodeList.UseCompatibleStateImageBehavior = false;
			this.listView_BarcodeList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader_Code
			// 
			this.columnHeader_Code.Text = "바코드";
			this.columnHeader_Code.Width = 260;
			// 
			// columnHeader_Customer
			// 
			this.columnHeader_Customer.Text = "거래처";
			this.columnHeader_Customer.Width = 175;
			// 
			// columnHeader_ProdName
			// 
			this.columnHeader_ProdName.Text = "SPEC";
			this.columnHeader_ProdName.Width = 131;
			// 
			// columnHeader_ODName
			// 
			this.columnHeader_ODName.Text = "호칭경";
			this.columnHeader_ODName.Width = 92;
			// 
			// columnHeader_OuterDiameter
			// 
			this.columnHeader_OuterDiameter.Text = "외경";
			this.columnHeader_OuterDiameter.Width = 47;
			// 
			// columnHeader_Thickness
			// 
			this.columnHeader_Thickness.Text = "두께";
			this.columnHeader_Thickness.Width = 48;
			// 
			// columnHeader_Length
			// 
			this.columnHeader_Length.Text = "길이";
			this.columnHeader_Length.Width = 48;
			// 
			// columnHeader_TotalQuantity
			// 
			this.columnHeader_TotalQuantity.Text = "총수량";
			this.columnHeader_TotalQuantity.Width = 58;
			// 
			// columnHeader_Quantity
			// 
			this.columnHeader_Quantity.Text = "수량";
			this.columnHeader_Quantity.Width = 45;
			// 
			// tableLayoutPanel_ColumnHeader
			// 
			this.tableLayoutPanel_ColumnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel_ColumnHeader.BackColor = System.Drawing.Color.SandyBrown;
			this.tableLayoutPanel_ColumnHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
			this.tableLayoutPanel_ColumnHeader.ColumnCount = 10;
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel_ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label4, 3, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label5, 4, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label6, 5, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label7, 6, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label8, 7, 0);
			this.tableLayoutPanel_ColumnHeader.Controls.Add(this.label9, 8, 0);
			this.tableLayoutPanel_ColumnHeader.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tableLayoutPanel_ColumnHeader.Location = new System.Drawing.Point(9, 0);
			this.tableLayoutPanel_ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel_ColumnHeader.Name = "tableLayoutPanel_ColumnHeader";
			this.tableLayoutPanel_ColumnHeader.RowCount = 1;
			this.tableLayoutPanel_ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel_ColumnHeader.Size = new System.Drawing.Size(956, 25);
			this.tableLayoutPanel_ColumnHeader.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(5, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 21);
			this.label1.TabIndex = 17;
			this.label1.Text = "바코드";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(267, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 21);
			this.label2.TabIndex = 18;
			this.label2.Text = "거래처";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(444, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 21);
			this.label3.TabIndex = 19;
			this.label3.Text = "SPEC";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(571, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 21);
			this.label4.TabIndex = 20;
			this.label4.Text = "호칭경";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(663, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 21);
			this.label5.TabIndex = 21;
			this.label5.Text = "외경";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(710, 2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 21);
			this.label6.TabIndex = 22;
			this.label6.Text = "두께";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(758, 2);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 21);
			this.label7.TabIndex = 23;
			this.label7.Text = "길이";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(806, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 21);
			this.label8.TabIndex = 24;
			this.label8.Text = "총수량";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(864, 2);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 21);
			this.label9.TabIndex = 25;
			this.label9.Text = "수량";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_SelectAll
			// 
			this.button_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_SelectAll.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_SelectAll.Location = new System.Drawing.Point(0, 531);
			this.button_SelectAll.Name = "button_SelectAll";
			this.button_SelectAll.Size = new System.Drawing.Size(140, 60);
			this.button_SelectAll.TabIndex = 18;
			this.button_SelectAll.Text = "전체선택";
			this.button_SelectAll.UseVisualStyleBackColor = true;
			this.button_SelectAll.Click += new System.EventHandler(this.Button_SelectAllClick);
			// 
			// button_DeselectAll
			// 
			this.button_DeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_DeselectAll.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_DeselectAll.Location = new System.Drawing.Point(146, 531);
			this.button_DeselectAll.Name = "button_DeselectAll";
			this.button_DeselectAll.Size = new System.Drawing.Size(140, 60);
			this.button_DeselectAll.TabIndex = 19;
			this.button_DeselectAll.Text = "전체취소";
			this.button_DeselectAll.UseVisualStyleBackColor = true;
			this.button_DeselectAll.Click += new System.EventHandler(this.Button_DeselectAllClick);
			// 
			// button_Search
			// 
			this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Search.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Search.Location = new System.Drawing.Point(292, 531);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(140, 60);
			this.button_Search.TabIndex = 20;
			this.button_Search.Text = "검색";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.Button_SearchClick);
			// 
			// button_Print
			// 
			this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Print.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Print.Location = new System.Drawing.Point(712, 531);
			this.button_Print.Name = "button_Print";
			this.button_Print.Size = new System.Drawing.Size(140, 60);
			this.button_Print.TabIndex = 21;
			this.button_Print.Text = "재발행";
			this.button_Print.UseVisualStyleBackColor = true;
			this.button_Print.Click += new System.EventHandler(this.Button_PrintClick);
			// 
			// button_Close
			// 
			this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Close.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Close.Location = new System.Drawing.Point(879, 531);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(140, 60);
			this.button_Close.TabIndex = 22;
			this.button_Close.Text = "닫기";
			this.button_Close.UseVisualStyleBackColor = true;
			this.button_Close.Click += new System.EventHandler(this.Button_CloseClick);
			// 
			// FormBarcodeList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 593);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.button_Print);
			this.Controls.Add(this.button_Search);
			this.Controls.Add(this.button_DeselectAll);
			this.Controls.Add(this.button_SelectAll);
			this.Controls.Add(this.tableLayoutPanel_ColumnHeader);
			this.Controls.Add(this.button_MoveNext);
			this.Controls.Add(this.button_MovePrev);
			this.Controls.Add(this.listView_BarcodeList);
			this.Name = "FormBarcodeList";
			this.Text = "FormBarcodeList";
			this.Load += new System.EventHandler(this.FormBarcodeListLoad);
			this.tableLayoutPanel_ColumnHeader.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_Close;
		private System.Windows.Forms.Button button_Print;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.Button button_DeselectAll;
		private System.Windows.Forms.Button button_SelectAll;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ColumnHeader;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader_Quantity;
		private System.Windows.Forms.ColumnHeader columnHeader_TotalQuantity;
		private System.Windows.Forms.ColumnHeader columnHeader_Length;
		private System.Windows.Forms.ColumnHeader columnHeader_Thickness;
		private System.Windows.Forms.ColumnHeader columnHeader_OuterDiameter;
		private System.Windows.Forms.ColumnHeader columnHeader_ODName;
		private System.Windows.Forms.ColumnHeader columnHeader_ProdName;
		private System.Windows.Forms.ColumnHeader columnHeader_Customer;
		private System.Windows.Forms.ColumnHeader columnHeader_Code;
		private System.Windows.Forms.ListView listView_BarcodeList;
		private System.Windows.Forms.Button button_MovePrev;
		private System.Windows.Forms.Button button_MoveNext;
	}
}
