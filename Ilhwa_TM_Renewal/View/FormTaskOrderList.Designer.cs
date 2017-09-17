/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-23
 * Time: 오후 4:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View
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
			this.taskOrderViewList = new Artn.Ilhwa.View.TaskOrderViewList();
			this.textBox_Keyword = new System.Windows.Forms.TextBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.button_SearchAll = new System.Windows.Forms.Button();
			this.button_SearchDay = new System.Windows.Forms.Button();
			this.button_SearchWeek = new System.Windows.Forms.Button();
			this.button_SearchMonth = new System.Windows.Forms.Button();
			this.button_MovePrev = new System.Windows.Forms.Button();
			this.button_MoveNext = new System.Windows.Forms.Button();
			this.button_InputOrderNo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// taskOrderViewList
			// 
			this.taskOrderViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.taskOrderViewList.CheckingAbility = true;
			this.taskOrderViewList.Location = new System.Drawing.Point(-5, 50);
			this.taskOrderViewList.Name = "taskOrderViewList";
			this.taskOrderViewList.Size = new System.Drawing.Size(1008, 497);
			this.taskOrderViewList.TabIndex = 0;
			this.taskOrderViewList.ViewData = null;
			this.taskOrderViewList.LogMessage += new Theson.Common.LogEventHandler(this.TaskOrderViewListLogMessage);
			// 
			// textBox_Keyword
			// 
			this.textBox_Keyword.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_Keyword.Location = new System.Drawing.Point(12, 9);
			this.textBox_Keyword.Multiline = true;
			this.textBox_Keyword.Name = "textBox_Keyword";
			this.textBox_Keyword.Size = new System.Drawing.Size(234, 35);
			this.textBox_Keyword.TabIndex = 2;
			this.textBox_Keyword.Text = "dddd";
			this.textBox_Keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Keyword.Click += new System.EventHandler(this.TextBox_KeywordClick);
			this.textBox_Keyword.TextChanged += new System.EventHandler(this.TextBox_KeywordTextChanged);
			// 
			// button_Search
			// 
			this.button_Search.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_Search.Location = new System.Drawing.Point(400, 9);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(127, 35);
			this.button_Search.TabIndex = 3;
			this.button_Search.Text = "조건검색";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.Button_SearchClick);
			// 
			// button_SearchAll
			// 
			this.button_SearchAll.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_SearchAll.Location = new System.Drawing.Point(559, 9);
			this.button_SearchAll.Name = "button_SearchAll";
			this.button_SearchAll.Size = new System.Drawing.Size(80, 35);
			this.button_SearchAll.TabIndex = 4;
			this.button_SearchAll.Text = "전체";
			this.button_SearchAll.UseVisualStyleBackColor = true;
			this.button_SearchAll.Visible = false;
			this.button_SearchAll.Click += new System.EventHandler(this.Button_SearchAllClick);
			// 
			// button_SearchDay
			// 
			this.button_SearchDay.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_SearchDay.Location = new System.Drawing.Point(682, 9);
			this.button_SearchDay.Name = "button_SearchDay";
			this.button_SearchDay.Size = new System.Drawing.Size(80, 35);
			this.button_SearchDay.TabIndex = 5;
			this.button_SearchDay.Text = "일";
			this.button_SearchDay.UseVisualStyleBackColor = true;
			this.button_SearchDay.Visible = false;
			this.button_SearchDay.Click += new System.EventHandler(this.Button_SearchDayClick);
			// 
			// button_SearchWeek
			// 
			this.button_SearchWeek.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_SearchWeek.Location = new System.Drawing.Point(695, 9);
			this.button_SearchWeek.Name = "button_SearchWeek";
			this.button_SearchWeek.Size = new System.Drawing.Size(80, 35);
			this.button_SearchWeek.TabIndex = 6;
			this.button_SearchWeek.Text = "주";
			this.button_SearchWeek.UseVisualStyleBackColor = true;
			this.button_SearchWeek.Visible = false;
			this.button_SearchWeek.Click += new System.EventHandler(this.Button_SearchWeekClick);
			// 
			// button_SearchMonth
			// 
			this.button_SearchMonth.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_SearchMonth.Location = new System.Drawing.Point(704, 9);
			this.button_SearchMonth.Name = "button_SearchMonth";
			this.button_SearchMonth.Size = new System.Drawing.Size(80, 35);
			this.button_SearchMonth.TabIndex = 7;
			this.button_SearchMonth.Text = "월";
			this.button_SearchMonth.UseVisualStyleBackColor = true;
			this.button_SearchMonth.Visible = false;
			this.button_SearchMonth.Click += new System.EventHandler(this.Button_SearchMonthClick);
			// 
			// button_MovePrev
			// 
			this.button_MovePrev.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MovePrev.Location = new System.Drawing.Point(790, 9);
			this.button_MovePrev.Name = "button_MovePrev";
			this.button_MovePrev.Size = new System.Drawing.Size(100, 35);
			this.button_MovePrev.TabIndex = 8;
			this.button_MovePrev.Text = "▲";
			this.button_MovePrev.UseVisualStyleBackColor = true;
			this.button_MovePrev.Click += new System.EventHandler(this.Button_MovePrevClick);
			// 
			// button_MoveNext
			// 
			this.button_MoveNext.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_MoveNext.Location = new System.Drawing.Point(896, 9);
			this.button_MoveNext.Name = "button_MoveNext";
			this.button_MoveNext.Size = new System.Drawing.Size(100, 35);
			this.button_MoveNext.TabIndex = 9;
			this.button_MoveNext.Text = "▼";
			this.button_MoveNext.UseVisualStyleBackColor = true;
			this.button_MoveNext.Click += new System.EventHandler(this.Button_MoveNextClick);
			// 
			// button_InputOrderNo
			// 
			this.button_InputOrderNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_InputOrderNo.Location = new System.Drawing.Point(252, 9);
			this.button_InputOrderNo.Name = "button_InputOrderNo";
			this.button_InputOrderNo.Size = new System.Drawing.Size(101, 35);
			this.button_InputOrderNo.TabIndex = 10;
			this.button_InputOrderNo.Text = "입력";
			this.button_InputOrderNo.UseVisualStyleBackColor = true;
			this.button_InputOrderNo.Click += new System.EventHandler(this.Button_InputOrderNoClick);
			// 
			// FormTaskOrderList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1011, 554);
			this.ControlBox = false;
			this.Controls.Add(this.button_InputOrderNo);
			this.Controls.Add(this.button_MoveNext);
			this.Controls.Add(this.button_MovePrev);
			this.Controls.Add(this.button_SearchMonth);
			this.Controls.Add(this.button_SearchWeek);
			this.Controls.Add(this.button_SearchDay);
			this.Controls.Add(this.button_SearchAll);
			this.Controls.Add(this.button_Search);
			this.Controls.Add(this.textBox_Keyword);
			this.Controls.Add(this.taskOrderViewList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormTaskOrderList";
			this.Text = "FormTaskOrderList";
			this.Activated += new System.EventHandler(this.FormTaskOrderListActivated);
			this.Load += new System.EventHandler(this.FormTaskOrderListLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button_InputOrderNo;
		private System.Windows.Forms.Button button_MoveNext;
		private System.Windows.Forms.Button button_MovePrev;
		private System.Windows.Forms.Button button_SearchMonth;
		private System.Windows.Forms.Button button_SearchWeek;
		private System.Windows.Forms.Button button_SearchDay;
		private System.Windows.Forms.Button button_SearchAll;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.TextBox textBox_Keyword;
		private Artn.Ilhwa.View.TaskOrderViewList taskOrderViewList;
	}
}
