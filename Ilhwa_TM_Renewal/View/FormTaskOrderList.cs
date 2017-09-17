/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-23
 * Time: 오후 4:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
using Theson.Common;

namespace Artn.Ilhwa.View
{
	/// <summary>
	/// Description of FormTaskOrderList.
	/// </summary>
	public partial class FormTaskOrderList : DataViewForm
	{
		private FormTaskProcessList _frmTaskProcList = new FormTaskProcessList();
		private string _userDate = "";
		
		public FormTaskOrderList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			taskOrderViewList.ItemSelected += TaskOrderList_ItemSelected;
			textBox_Keyword.Text = "";
		}
		
		

		void Button_MovePrevClick(object sender, EventArgs e)
		{
			taskOrderViewList.MovePrev();
		}
		
		void Button_MoveNextClick(object sender, EventArgs e)
		{
			taskOrderViewList.MoveNext();
		}
		
		void FormTaskOrderListActivated(object sender, EventArgs e)
		{
			//LoadTableByDate(_userDate);
		}
		
		void Button_SearchClick(object sender, EventArgs e)
		{

			FormSearchOption frm = new FormSearchOption();
			frm.ViewCtrl = ViewCtrl;
			
			if (frm.ShowDialog() == DialogResult.OK){
				taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByVarOption(frm.ViewData as TaskOrder));
			}
			
			frm.MemberClear();
		}
		
		void Button_SearchAllClick(object sender, EventArgs e)
		{
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByCode(""));
		}
		
		
		
		void Button_SearchDayClick(object sender, EventArgs e)
		{
			_userDate = DateTime.Now.ToString("yyyy-MM-dd");
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByDate(_userDate));
		}
		
		void Button_SearchWeekClick(object sender, EventArgs e)
		{
			_userDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByDate(_userDate));
		}
		
		void Button_SearchMonthClick(object sender, EventArgs e)
		{
			_userDate = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByDate(_userDate));
		}
		
		void FormTaskOrderListLoad(object sender, EventArgs e)
		{
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByConfigExpress());
		}
		
		void TaskOrderList_ItemSelected(object sender, IMultiColumnRecordable mcData){
			if (mcData["Status"] == "E"){
				MsgBox.Show("확인", "해당 작업은 이미 완료 되었습니다.");
				return;
			}
			if (mcData["Status"] == "X"){
				MsgBox.Show("확인", "해당 작업은 지시 취소 되었습니다.");
				return;
			}
			
			FormTaskProcessList frm = (MdiParent as MainForm).Form_TaskProcList;
			
			frm.ViewData = mcData;
			frm.Show();
			frm.WindowState = FormWindowState.Maximized;
		}
		
		void TaskOrderViewListLogMessage(object Sender, string msg)
		{
			OnLogMessage(Sender, msg);
		}
		
		void TextBox_KeywordClick(object sender, EventArgs e)
		{
			textBox_Keyword.SelectAll();
		}
		
		void TextBox_KeywordTextChanged(object sender, EventArgs e)
		{
			if (ViewCtrl == null) return;
			
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByCode(textBox_Keyword.Text));
		}
		
		public bool PrinterAbility{
			get{
				return taskOrderViewList.CheckingAbility;
			}
			set{
				taskOrderViewList.CheckingAbility = value;
			}
		}
		
		public override void Refresh()
		{
			base.Refresh();
			Button_SearchDayClick(this, null);
		}
		
		
		
		// 프린트 출력 기능 추가 -
		// TODO: 추후에 모듈화 시켜야함.
		private Font m_MainFont = null;
        private Font m_SubFont = null;
        private Font m_SmallFont = null;
        private Font m_barcodeFont = null;
        private PageSettings m_PageSetting = null;
        //private Bitmap m_BackBmp = null;
        Pen PenBlack = new Pen(Color.Black);
		
		void Button_PrintClick(object sender, EventArgs e)
		{
			m_MainFont = new Font("돋움", 30, FontStyle.Bold);
            m_SubFont = new Font("돋움체", 13);
            m_SmallFont = new Font("바탕체", 9);
            m_barcodeFont = new Font("Free 3 of 9 Extended", 38);
			
			 try
             {
                //프린트 설정
                 //PageSetupDialog psd = new PageSetupDialog();
                 //if (this.m_PageSetting == null)
                 //    this.m_PageSetting = new PageSettings();
                 //psd.PageSettings = this.m_PageSetting;
                 //psd.ShowDialog();

                 PrintDocument pd = new PrintDocument();// 필수
                 pd.DefaultPageSettings.Landscape = true; // 인쇄 가로(true) 세로(false)
                 pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);	// 프린트 페이지 이벤트헨들러
                 m_PageSetting = new PageSettings();
                 if (this.m_PageSetting != null)
                     pd.DefaultPageSettings = this.m_PageSetting;

                 PrintPreviewDialog ppd = new PrintPreviewDialog();
                 ppd.Document = pd;
                 ppd.ShowDialog();
             }
             catch (InvalidPrinterException)
             {
                 //MessageBox.Show(pex.Message);
             }
             catch (Exception)
             {
                 //MessageBox.Show(ex.Message);
             }
		}
		
		
		
		
		
		void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            PrintDocument(g, taskOrderViewList.GetSelectedList());
            e.HasMorePages = false;
        }
       
        private void PrintDocument(Graphics g, List<IMultiColumnRecordable> dataList)
        {
            // 이걸 참고 하십시요
            //StringBuilder sb = new StringBuilder();
            //foreach (IMultiColumnRecordable data in taskOrderViewList.GetSelectedList())
            //{
            //    sb += data["OrderNo"] + "\r\n");
            //}
            //MessageBox.Show(sb.ToString());
            // 이걸 참고 하십시요

            //g.FillRectangle(Brushes.White, 100, 50, 600, 800); //전체 사각형
            //g.DrawImage(m_BackBmp, 100, 50); //배경이미지 그리기
            //g.DrawImage(m_Weather[CbWeather.SelectedIndex], 380, 120); //날씨 아이콘

            g.DrawString("작업지시서", this.m_MainFont, Brushes.Black, 450, 40);//제목 출력
           
            // Create points that define line.
            Point point1 = new Point(30, 90);
            Point point2 = new Point(1130, 90);
            Point point3 = new Point(30, 150);
            Point point4 = new Point(1130, 150);

            //g.DrawLine(PenBlack, point1, point2);
            //g.DrawLine(PenBlack, point3, point4);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;//	세로정렬
            sf.LineAlignment = StringAlignment.Center; //  가로정렬

            Rectangle rect = new Rectangle(15, 90, 200, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString("지시번호", this.m_SubFont, Brushes.Black, rect, sf);// 내용출력

            Rectangle rect1 = new Rectangle(215, 90, 200, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect1);
            g.DrawString("거래처", this.m_SubFont, Brushes.Black, rect1, sf);// 내용출력

            Rectangle rect2 = new Rectangle(415, 90, 100, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect2);
            g.DrawString("ProdName", this.m_SubFont, Brushes.Black, rect2, sf);// 내용출력

            Rectangle rect3 = new Rectangle(515, 90, 140, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect3);
            g.DrawString("호칭경 / 두께", this.m_SubFont, Brushes.Black, rect3, sf);// 내용출력

            Rectangle rect4 = new Rectangle(655, 90, 100, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect4);
            g.DrawString("길이", this.m_SubFont, Brushes.Black, rect4, sf);// 내용출력

            Rectangle rect5 = new Rectangle(755, 90, 100, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect5);
            g.DrawString("수량", this.m_SubFont, Brushes.Black, rect5, sf);// 내용출력

            Rectangle rect6 = new Rectangle(855, 90, 100, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect6);
            g.DrawString("납기예정", this.m_SubFont, Brushes.Black, rect6, sf);// 내용출력

            Rectangle rect7 = new Rectangle(955, 90, 80, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect7);
            g.DrawString("중량", this.m_SubFont, Brushes.Black, rect7, sf);// 내용출력

            Rectangle rect8 = new Rectangle(1035, 90, 90, 30);// 글출력하는 영역생성
            g.DrawRectangle(Pens.Black, rect8);
            g.DrawString("조관기", this.m_SubFont, Brushes.Black, rect8, sf);// 내용출력
            

            StringBuilder sb = new StringBuilder();
            int positionx = 140;
            foreach (IMultiColumnRecordable data in dataList)
            {
                string barcode = "*" + data["OrderNo"] + "*";               
                g.DrawString(barcode, this.m_barcodeFont, Brushes.Black, 10, positionx); //바코드 출력
                g.DrawString(barcode, this.m_SmallFont, Brushes.Black, 20, positionx - 13);
                g.DrawString(data["Customer"], this.m_SmallFont, Brushes.Black, 240, positionx+10); //거래처 출력
                g.DrawString(data["ProdName1"] + "\r\n" + data["ProdName2"], this.m_SmallFont, Brushes.Black, 425, positionx); //SPEC 출력
                string odname = data["ODName1"] + "\r\n" + data["ODName2"];
                string thinkness = data["Thickness1"] + "\r\n" + data["Thickness2"];
                g.DrawString(odname, this.m_SmallFont, Brushes.Black, 525, positionx); //호칭경 출력
                g.DrawString(" / ", this.m_SmallFont, Brushes.Black, 585, positionx); // / 출력
                g.DrawString(thinkness, this.m_SmallFont, Brushes.Black, 610, positionx); // 두께 출력
                g.DrawString(data["OrderLength1"], this.m_SmallFont, Brushes.Black, 680, positionx); // 길이 출력
                g.DrawString(data["OrderQuantity2"], this.m_SmallFont, Brushes.Black, 780, positionx); // 중량 출력
                g.DrawString(data["DeliveryDate"], this.m_SmallFont, Brushes.Black, 880, positionx); // 납기예정 출력
                g.DrawString(data["Weight2"], this.m_SmallFont, Brushes.Black, 980, positionx); // 중량 출력
                g.DrawString(data["EquipCode"], this.m_SmallFont, Brushes.Black, 1060, positionx); // 조관기 출력


                Point point5 = new Point(15, positionx + 50);
                Point point6 = new Point(1120, positionx + 50);

                g.DrawLine(PenBlack, point5, point6);

                positionx = positionx + 80;
            }
           // g.DrawString("*2012-12-08*", this.m_barcodeFont, Brushes.Black, 10, 100); //바코드 출력





            //StringFormat sf = new StringFormat();
            //sf.Alignment = StringAlignment.Near;//	세로정렬
            //sf.LineAlignment = StringAlignment.Center; //  가로정렬
            //Rectangle rect = new Rectangle(100, 280, 500, this.m_MainFont.Height * 3);// 글출력하는 영역생성
            //g.DrawRectangle(Pens.Black, rect);
            //g.DrawString("일화1", this.m_MainFont, Brushes.Black, rect, sf);// 내용출력
            //g.DrawString("일화2", this.m_SubFont, Brushes.Black, rect); // 내용출력
        }
		
		void Button_InputOrderNoClick(object sender, EventArgs e)
		{
			FormNumberPad numPad = new FormNumberPad();
			
			if(numPad.ShowDialog() == DialogResult.OK){
				textBox_Keyword.Text = numPad.Value;
			}
		}
	}
}
