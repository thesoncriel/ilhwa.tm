using System.ComponentModel;
using System.Windows.Forms;

/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-06-04
 * Time: 오후 2:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Artn.Ilhwa.View.POP
{
	partial class FormTaskCurrentList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.SearchResultGrid = new System.Windows.Forms.DataGridView();
			this.taskCurrentSearchView1 = new Artn.Ilhwa.View.POP.TaskCurrentSearchView();
			this.GotoBackBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchBtn
			// 
			this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchBtn.Location = new System.Drawing.Point(1114, 29);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(102, 52);
			this.SearchBtn.TabIndex = 2;
			this.SearchBtn.Text = "검색";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtnClick);
			// 
			// SearchResultGrid
			// 
			this.SearchResultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.SearchResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.SearchResultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchResultGrid.Location = new System.Drawing.Point(-1, 107);
			this.SearchResultGrid.Name = "SearchResultGrid";
			this.SearchResultGrid.RowTemplate.Height = 23;
			this.SearchResultGrid.Size = new System.Drawing.Size(1367, 664);
			this.SearchResultGrid.TabIndex = 3;
			// 
			// taskCurrentSearchView1
			// 
			this.taskCurrentSearchView1.Location = new System.Drawing.Point(10, 29);
			this.taskCurrentSearchView1.Name = "taskCurrentSearchView1";
			this.taskCurrentSearchView1.Size = new System.Drawing.Size(972, 52);
			this.taskCurrentSearchView1.TabIndex = 4;
			this.taskCurrentSearchView1.ViewData = null;
			this.taskCurrentSearchView1.Visible = false;
			// 
			// GotoBackBtn
			// 
			this.GotoBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GotoBackBtn.Location = new System.Drawing.Point(1244, 29);
			this.GotoBackBtn.Name = "GotoBackBtn";
			this.GotoBackBtn.Size = new System.Drawing.Size(102, 52);
			this.GotoBackBtn.TabIndex = 5;
			this.GotoBackBtn.Text = "이전 화면";
			this.GotoBackBtn.UseVisualStyleBackColor = true;
			this.GotoBackBtn.Click += new System.EventHandler(this.GotoBackBtnClick);
			// 
			// FormTaskCurrentList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1368, 768);
			this.ControlBox = false;
			this.Controls.Add(this.GotoBackBtn);
			this.Controls.Add(this.taskCurrentSearchView1);
			this.Controls.Add(this.SearchResultGrid);
			this.Controls.Add(this.SearchBtn);
			this.Name = "FormTaskCurrentList";
			this.Text = "FormTaskCurrentList";
			((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button GotoBackBtn;
		private Artn.Ilhwa.View.POP.TaskCurrentSearchView taskCurrentSearchView1;

		private System.Windows.Forms.DataGridView SearchResultGrid;
		private System.Windows.Forms.Button SearchBtn;

	}
}
