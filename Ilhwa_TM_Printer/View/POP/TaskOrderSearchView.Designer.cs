/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-22
 * Time: 오후 4:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.POP
{
	partial class TaskOrderSearchView
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton_PublishedNo = new System.Windows.Forms.RadioButton();
			this.radioButton_PublishedYes = new System.Windows.Forms.RadioButton();
			this.radioButton_PublishedAll = new System.Windows.Forms.RadioButton();
			this.checkBox_PoDateUse = new System.Windows.Forms.CheckBox();
			this.checkBox_OrderDateUse = new System.Windows.Forms.CheckBox();
			this.checkBox_DeliveryDateUse = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_Customer = new System.Windows.Forms.TextBox();
			this.textBox_OrderNo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox_Quality = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox_ProdCode = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox_OuterDiameterFrom = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBox_OuterDiameterTo = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.comboBox_ThicknessTo = new System.Windows.Forms.ComboBox();
			this.comboBox_ThicknessFrom = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox_LengthFrom = new System.Windows.Forms.TextBox();
			this.textBox_LengthTo = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.dateTimePicker_PoDateFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_PoDateTo = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_OrderDateFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_OrderDateTo = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_DeliveryDateFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_DeliveryDateTo = new System.Windows.Forms.DateTimePicker();
			this.button_Print = new System.Windows.Forms.Button();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_EquipCode = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "작업 지시일 기간";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "생산 제조일 기간";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(236, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "-";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(236, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "-";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(236, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "-";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 59);
			this.label6.Margin = new System.Windows.Forms.Padding(3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 18);
			this.label6.TabIndex = 8;
			this.label6.Text = "납기 예정일 기간";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton_PublishedNo);
			this.groupBox1.Controls.Add(this.radioButton_PublishedYes);
			this.groupBox1.Controls.Add(this.radioButton_PublishedAll);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(3, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 46);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "발행여부";
			// 
			// radioButton_PublishedNo
			// 
			this.radioButton_PublishedNo.Checked = true;
			this.radioButton_PublishedNo.Location = new System.Drawing.Point(126, 16);
			this.radioButton_PublishedNo.Name = "radioButton_PublishedNo";
			this.radioButton_PublishedNo.Size = new System.Drawing.Size(68, 24);
			this.radioButton_PublishedNo.TabIndex = 16;
			this.radioButton_PublishedNo.TabStop = true;
			this.radioButton_PublishedNo.Text = "미발행";
			this.radioButton_PublishedNo.UseVisualStyleBackColor = true;
			this.radioButton_PublishedNo.CheckedChanged += new System.EventHandler(this.RadioButton_PublishedCheckedChanged);
			// 
			// radioButton_PublishedYes
			// 
			this.radioButton_PublishedYes.Location = new System.Drawing.Point(66, 16);
			this.radioButton_PublishedYes.Name = "radioButton_PublishedYes";
			this.radioButton_PublishedYes.Size = new System.Drawing.Size(54, 24);
			this.radioButton_PublishedYes.TabIndex = 15;
			this.radioButton_PublishedYes.Text = "발행";
			this.radioButton_PublishedYes.UseVisualStyleBackColor = true;
			this.radioButton_PublishedYes.CheckedChanged += new System.EventHandler(this.RadioButton_PublishedCheckedChanged);
			// 
			// radioButton_PublishedAll
			// 
			this.radioButton_PublishedAll.Location = new System.Drawing.Point(6, 16);
			this.radioButton_PublishedAll.Name = "radioButton_PublishedAll";
			this.radioButton_PublishedAll.Size = new System.Drawing.Size(54, 24);
			this.radioButton_PublishedAll.TabIndex = 14;
			this.radioButton_PublishedAll.Text = "전체";
			this.radioButton_PublishedAll.UseVisualStyleBackColor = true;
			this.radioButton_PublishedAll.CheckedChanged += new System.EventHandler(this.RadioButton_PublishedCheckedChanged);
			// 
			// checkBox_PoDateUse
			// 
			this.checkBox_PoDateUse.Checked = true;
			this.checkBox_PoDateUse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_PoDateUse.Location = new System.Drawing.Point(382, 2);
			this.checkBox_PoDateUse.Name = "checkBox_PoDateUse";
			this.checkBox_PoDateUse.Size = new System.Drawing.Size(20, 24);
			this.checkBox_PoDateUse.TabIndex = 13;
			this.checkBox_PoDateUse.UseVisualStyleBackColor = true;
			this.checkBox_PoDateUse.CheckedChanged += new System.EventHandler(this.CheckBox_DateUseCheckedChanged);
			// 
			// checkBox_OrderDateUse
			// 
			this.checkBox_OrderDateUse.Checked = true;
			this.checkBox_OrderDateUse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_OrderDateUse.Location = new System.Drawing.Point(382, 27);
			this.checkBox_OrderDateUse.Name = "checkBox_OrderDateUse";
			this.checkBox_OrderDateUse.Size = new System.Drawing.Size(20, 24);
			this.checkBox_OrderDateUse.TabIndex = 14;
			this.checkBox_OrderDateUse.UseVisualStyleBackColor = true;
			this.checkBox_OrderDateUse.CheckedChanged += new System.EventHandler(this.CheckBox_DateUseCheckedChanged);
			// 
			// checkBox_DeliveryDateUse
			// 
			this.checkBox_DeliveryDateUse.Checked = true;
			this.checkBox_DeliveryDateUse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_DeliveryDateUse.Location = new System.Drawing.Point(382, 53);
			this.checkBox_DeliveryDateUse.Name = "checkBox_DeliveryDateUse";
			this.checkBox_DeliveryDateUse.Size = new System.Drawing.Size(20, 24);
			this.checkBox_DeliveryDateUse.TabIndex = 15;
			this.checkBox_DeliveryDateUse.UseVisualStyleBackColor = true;
			this.checkBox_DeliveryDateUse.CheckedChanged += new System.EventHandler(this.CheckBox_DateUseCheckedChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(470, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "거래처";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(428, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "작업지시번호";
			// 
			// textBox_Customer
			// 
			this.textBox_Customer.Location = new System.Drawing.Point(525, 5);
			this.textBox_Customer.Name = "textBox_Customer";
			this.textBox_Customer.Size = new System.Drawing.Size(260, 21);
			this.textBox_Customer.TabIndex = 18;
			this.textBox_Customer.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_OrderNo
			// 
			this.textBox_OrderNo.Location = new System.Drawing.Point(525, 47);
			this.textBox_OrderNo.Name = "textBox_OrderNo";
			this.textBox_OrderNo.Size = new System.Drawing.Size(88, 21);
			this.textBox_OrderNo.TabIndex = 19;
			this.textBox_OrderNo.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(619, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "지시 설비";
			// 
			// comboBox_Quality
			// 
			this.comboBox_Quality.FormattingEnabled = true;
			this.comboBox_Quality.Location = new System.Drawing.Point(813, 49);
			this.comboBox_Quality.Name = "comboBox_Quality";
			this.comboBox_Quality.Size = new System.Drawing.Size(84, 20);
			this.comboBox_Quality.TabIndex = 23;
			this.comboBox_Quality.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(782, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 23);
			this.label10.TabIndex = 22;
			this.label10.Text = "강종";
			// 
			// comboBox_ProdCode
			// 
			this.comboBox_ProdCode.FormattingEnabled = true;
			this.comboBox_ProdCode.Location = new System.Drawing.Point(332, 99);
			this.comboBox_ProdCode.Name = "comboBox_ProdCode";
			this.comboBox_ProdCode.Size = new System.Drawing.Size(110, 20);
			this.comboBox_ProdCode.TabIndex = 25;
			this.comboBox_ProdCode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(293, 102);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 23);
			this.label11.TabIndex = 24;
			this.label11.Text = "SPEC";
			// 
			// comboBox_OuterDiameterFrom
			// 
			this.comboBox_OuterDiameterFrom.FormattingEnabled = true;
			this.comboBox_OuterDiameterFrom.Location = new System.Drawing.Point(486, 99);
			this.comboBox_OuterDiameterFrom.Name = "comboBox_OuterDiameterFrom";
			this.comboBox_OuterDiameterFrom.Size = new System.Drawing.Size(74, 20);
			this.comboBox_OuterDiameterFrom.TabIndex = 27;
			this.comboBox_OuterDiameterFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(448, 102);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "외경";
			// 
			// comboBox_OuterDiameterTo
			// 
			this.comboBox_OuterDiameterTo.FormattingEnabled = true;
			this.comboBox_OuterDiameterTo.Location = new System.Drawing.Point(583, 99);
			this.comboBox_OuterDiameterTo.Name = "comboBox_OuterDiameterTo";
			this.comboBox_OuterDiameterTo.Size = new System.Drawing.Size(74, 20);
			this.comboBox_OuterDiameterTo.TabIndex = 28;
			this.comboBox_OuterDiameterTo.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(564, 102);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(13, 23);
			this.label13.TabIndex = 29;
			this.label13.Text = "-";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(763, 102);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 23);
			this.label14.TabIndex = 33;
			this.label14.Text = "-";
			// 
			// comboBox_ThicknessTo
			// 
			this.comboBox_ThicknessTo.FormattingEnabled = true;
			this.comboBox_ThicknessTo.Location = new System.Drawing.Point(782, 99);
			this.comboBox_ThicknessTo.Name = "comboBox_ThicknessTo";
			this.comboBox_ThicknessTo.Size = new System.Drawing.Size(52, 20);
			this.comboBox_ThicknessTo.TabIndex = 32;
			this.comboBox_ThicknessTo.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// comboBox_ThicknessFrom
			// 
			this.comboBox_ThicknessFrom.FormattingEnabled = true;
			this.comboBox_ThicknessFrom.Location = new System.Drawing.Point(705, 100);
			this.comboBox_ThicknessFrom.Name = "comboBox_ThicknessFrom";
			this.comboBox_ThicknessFrom.Size = new System.Drawing.Size(52, 20);
			this.comboBox_ThicknessFrom.TabIndex = 31;
			this.comboBox_ThicknessFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(667, 102);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 23);
			this.label15.TabIndex = 30;
			this.label15.Text = "두께";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(956, 102);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(13, 23);
			this.label16.TabIndex = 37;
			this.label16.Text = "-";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(840, 102);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 23);
			this.label17.TabIndex = 34;
			this.label17.Text = "길이";
			// 
			// textBox_LengthFrom
			// 
			this.textBox_LengthFrom.Location = new System.Drawing.Point(873, 99);
			this.textBox_LengthFrom.Name = "textBox_LengthFrom";
			this.textBox_LengthFrom.Size = new System.Drawing.Size(77, 21);
			this.textBox_LengthFrom.TabIndex = 38;
			this.textBox_LengthFrom.Text = "0";
			this.textBox_LengthFrom.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBox_LengthTo
			// 
			this.textBox_LengthTo.Location = new System.Drawing.Point(975, 99);
			this.textBox_LengthTo.Name = "textBox_LengthTo";
			this.textBox_LengthTo.Size = new System.Drawing.Size(77, 21);
			this.textBox_LengthTo.TabIndex = 39;
			this.textBox_LengthTo.Text = "0";
			this.textBox_LengthTo.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(1058, 102);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(40, 23);
			this.label18.TabIndex = 40;
			this.label18.Text = "mm";
			// 
			// dateTimePicker_PoDateFrom
			// 
			this.dateTimePicker_PoDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_PoDateFrom.Location = new System.Drawing.Point(109, 3);
			this.dateTimePicker_PoDateFrom.Name = "dateTimePicker_PoDateFrom";
			this.dateTimePicker_PoDateFrom.Size = new System.Drawing.Size(121, 21);
			this.dateTimePicker_PoDateFrom.TabIndex = 41;
			this.dateTimePicker_PoDateFrom.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_PoDateFrom.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// dateTimePicker_PoDateTo
			// 
			this.dateTimePicker_PoDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_PoDateTo.Location = new System.Drawing.Point(255, 3);
			this.dateTimePicker_PoDateTo.Name = "dateTimePicker_PoDateTo";
			this.dateTimePicker_PoDateTo.Size = new System.Drawing.Size(121, 21);
			this.dateTimePicker_PoDateTo.TabIndex = 42;
			this.dateTimePicker_PoDateTo.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_PoDateTo.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// dateTimePicker_OrderDateFrom
			// 
			this.dateTimePicker_OrderDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_OrderDateFrom.Location = new System.Drawing.Point(109, 30);
			this.dateTimePicker_OrderDateFrom.Name = "dateTimePicker_OrderDateFrom";
			this.dateTimePicker_OrderDateFrom.Size = new System.Drawing.Size(121, 21);
			this.dateTimePicker_OrderDateFrom.TabIndex = 43;
			this.dateTimePicker_OrderDateFrom.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_OrderDateFrom.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// dateTimePicker_OrderDateTo
			// 
			this.dateTimePicker_OrderDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_OrderDateTo.Location = new System.Drawing.Point(255, 29);
			this.dateTimePicker_OrderDateTo.Name = "dateTimePicker_OrderDateTo";
			this.dateTimePicker_OrderDateTo.Size = new System.Drawing.Size(121, 21);
			this.dateTimePicker_OrderDateTo.TabIndex = 44;
			this.dateTimePicker_OrderDateTo.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_OrderDateTo.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// dateTimePicker_DeliveryDateFrom
			// 
			this.dateTimePicker_DeliveryDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_DeliveryDateFrom.Location = new System.Drawing.Point(109, 56);
			this.dateTimePicker_DeliveryDateFrom.Name = "dateTimePicker_DeliveryDateFrom";
			this.dateTimePicker_DeliveryDateFrom.Size = new System.Drawing.Size(121, 21);
			this.dateTimePicker_DeliveryDateFrom.TabIndex = 45;
			this.dateTimePicker_DeliveryDateFrom.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_DeliveryDateFrom.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// dateTimePicker_DeliveryDateTo
			// 
			this.dateTimePicker_DeliveryDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_DeliveryDateTo.Location = new System.Drawing.Point(255, 55);
			this.dateTimePicker_DeliveryDateTo.Name = "dateTimePicker_DeliveryDateTo";
			this.dateTimePicker_DeliveryDateTo.Size = new System.Drawing.Size(121, 21);
			this.dateTimePicker_DeliveryDateTo.TabIndex = 46;
			this.dateTimePicker_DeliveryDateTo.Value = new System.DateTime(2012, 9, 22, 0, 0, 0, 0);
			this.dateTimePicker_DeliveryDateTo.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// button_Print
			// 
			this.button_Print.Location = new System.Drawing.Point(1033, 24);
			this.button_Print.Name = "button_Print";
			this.button_Print.Size = new System.Drawing.Size(50, 50);
			this.button_Print.TabIndex = 47;
			this.button_Print.Text = "인쇄";
			this.button_Print.UseVisualStyleBackColor = true;
			this.button_Print.Click += new System.EventHandler(this.Button_PrintClick);
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(977, 24);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(50, 50);
			this.button_Search.TabIndex = 48;
			this.button_Search.Text = "검색";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.Button_SearchClick);
			// 
			// textBox_EquipCode
			// 
			this.textBox_EquipCode.Location = new System.Drawing.Point(685, 47);
			this.textBox_EquipCode.Name = "textBox_EquipCode";
			this.textBox_EquipCode.Size = new System.Drawing.Size(91, 21);
			this.textBox_EquipCode.TabIndex = 49;
			this.textBox_EquipCode.Text = "전체";
			this.textBox_EquipCode.Click += new System.EventHandler(this.TextBox_EquipCodeClick);
			this.textBox_EquipCode.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// TaskOrderSearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox_EquipCode);
			this.Controls.Add(this.button_Search);
			this.Controls.Add(this.button_Print);
			this.Controls.Add(this.dateTimePicker_DeliveryDateTo);
			this.Controls.Add(this.dateTimePicker_DeliveryDateFrom);
			this.Controls.Add(this.dateTimePicker_OrderDateTo);
			this.Controls.Add(this.dateTimePicker_OrderDateFrom);
			this.Controls.Add(this.dateTimePicker_PoDateTo);
			this.Controls.Add(this.dateTimePicker_PoDateFrom);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.textBox_LengthTo);
			this.Controls.Add(this.textBox_LengthFrom);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.comboBox_ThicknessTo);
			this.Controls.Add(this.comboBox_ThicknessFrom);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.comboBox_OuterDiameterTo);
			this.Controls.Add(this.comboBox_OuterDiameterFrom);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.comboBox_ProdCode);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboBox_Quality);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox_OrderNo);
			this.Controls.Add(this.textBox_Customer);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.checkBox_DeliveryDateUse);
			this.Controls.Add(this.checkBox_OrderDateUse);
			this.Controls.Add(this.checkBox_PoDateUse);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TaskOrderSearchView";
			this.Size = new System.Drawing.Size(1140, 131);
			this.Load += new System.EventHandler(this.TaskOrderSearchLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox_EquipCode;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.Button button_Print;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DeliveryDateTo;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DeliveryDateFrom;
		private System.Windows.Forms.DateTimePicker dateTimePicker_OrderDateTo;
		private System.Windows.Forms.DateTimePicker dateTimePicker_OrderDateFrom;
		private System.Windows.Forms.DateTimePicker dateTimePicker_PoDateTo;
		private System.Windows.Forms.DateTimePicker dateTimePicker_PoDateFrom;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBox_LengthTo;
		private System.Windows.Forms.TextBox textBox_LengthFrom;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox comboBox_ThicknessFrom;
		private System.Windows.Forms.ComboBox comboBox_ThicknessTo;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBox_OuterDiameterTo;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboBox_OuterDiameterFrom;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox_ProdCode;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBox_Quality;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_OrderNo;
		private System.Windows.Forms.TextBox textBox_Customer;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox_DeliveryDateUse;
		private System.Windows.Forms.CheckBox checkBox_OrderDateUse;
		private System.Windows.Forms.CheckBox checkBox_PoDateUse;
		private System.Windows.Forms.RadioButton radioButton_PublishedAll;
		private System.Windows.Forms.RadioButton radioButton_PublishedYes;
		private System.Windows.Forms.RadioButton radioButton_PublishedNo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
