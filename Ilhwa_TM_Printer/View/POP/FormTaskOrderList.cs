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

namespace Artn.Ilhwa.View.Pop
{
	/// <summary>
	/// Description of FormTaskOrderList.
	/// </summary>
	public partial class FormTaskOrderList : DataViewForm
	{
		public FormTaskOrderList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			taskOrderViewList.ItemSelected += TaskOrderList_ItemSelected;
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
		
		void Button_SearchKeywordClick(object sender, EventArgs e)
		{
			FormNumberPad numPad = new FormNumberPad();
		}
		
		void Button_SearchAllClick(object sender, EventArgs e)
		{
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByCode(""));
		}

		void FormTaskOrderListLoad(object sender, EventArgs e)
		{
			// Printer 기능 변경 - 12.09.23 jhson
			//taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByConfigExpress());
		}
		
		void TaskOrderList_ItemSelected(object sender, IMultiColumnRecordable mcData){

		}
		
		void TaskOrderViewListLogMessage(object Sender, string msg)
		{
			OnLogMessage(Sender, msg);
		}
		
		public override void Refresh()
		{
			base.Refresh();
		}
		
		
		
		// 프린트 출력 기능 추가 -
		// TODO: 추후에 모듈화 시켜야함.
		private Font m_MainFont = null;
        private Font m_SubFont = null;
        private Font m_SmallFont = null;
        private Font m_DoubleLineFont = null;
        private Font m_barcodeFont = null;
        private PageSettings m_PageSetting = null;
        //private Bitmap m_BackBmp = null;
        Pen PenBlack = new Pen(Color.Black);
		
		void Button_PrintClick(object sender, EventArgs e)
		{
			m_MainFont = new Font("돋움", 30, FontStyle.Bold);
            m_SubFont = new Font("돋움체", 10);
            m_SmallFont = new Font("바탕체", 11);
            m_DoubleLineFont = new Font("돋움체", 9.25F);
            m_barcodeFont = new Font("Free 3 of 9 Extended", 24);
			
			 try
             {
                //프린트 설정
                 //PageSetupDialog psd = new PageSetupDialog();
                 //if (this.m_PageSetting == null)
                 //    this.m_PageSetting = new PageSettings();
                 //psd.PageSettings = this.m_PageSetting;
                 //psd.ShowDialog();
                 viewList = taskOrderViewList.GetSelectedViewList();
                 _pageNum = 1;
                 PrintDocument pd = new PrintDocument();// 필수
                 pd.DefaultPageSettings.Landscape = true; // 인쇄 가로(true) 세로(false)
                 pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);	// 프린트 페이지 이벤트헨들러
                 

                 if (this.m_PageSetting != null)
                     pd.DefaultPageSettings = this.m_PageSetting;
                 
                 
                 if (ViewCtrl.DBManager.Config["Other","PrinterPreview"] == "true"){
	                 PrintPreviewDialog ppd = new PrintPreviewDialog();
	                 ppd.Document = pd;
	                 
	                 ppd.ShowDialog();
     	 		 }
                 else{
                 	pd.Print();
                 }
                 
             }
             catch (InvalidPrinterException)
             {
                 //MessageBox.Show(pex.Message);
                 MessageBox.Show("사용 할 수 있는 프린터가 존재하지 않습니다.\r\n현재 컴퓨터에 프린터가 설치되어 있는지 확인 하십시요.");
             }
             catch (Exception)
             {
                 //MessageBox.Show(ex.Message);
             }
             
		}
		
		
		
		List<TaskOrderView> viewList = null;
		int _printCount = 0;
		const int MAX_ROW = 9;//12;// 비고란 길이 두배로 하기 - by jhson 130502
		int _pageNum = 1;
		
		void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
			Graphics g = e.Graphics;
            PrintDocument(g, taskOrderViewList.GetSelectedList());
            e.HasMorePages = (_printCount < viewList.Count);
            if (e.HasMorePages == false){
            	_printCount = 0;
            	_pageNum = 1;
            }
            else{
            	_pageNum++;
            }
		}
       
        private void PrintDocument(Graphics g, List<IMultiColumnRecordable> dataList)
        {
        	g.ScaleTransform(0.9F, 0.95F);
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

            g.DrawString("(          ) 작업지시서", this.m_MainFont, Brushes.Black, 350, 30);//제목 출력
           
            // Create points that define line.
            
//            Point point3 = new Point(30, 150);
//            Point point4 = new Point(1130, 150);

            
            //g.DrawLine(PenBlack, point3, point4);

            StringFormat sf = new StringFormat();
            StringFormat sfProcSeq = new StringFormat();
            StringFormat sfDoubleLine = new StringFormat();
            
            sf.Alignment = StringAlignment.Center;//	세로정렬
            sf.LineAlignment = StringAlignment.Center; //  가로정렬
            sfProcSeq.Alignment = StringAlignment.Far;
            sfProcSeq.LineAlignment = StringAlignment.Center;
            sfDoubleLine.Alignment = StringAlignment.Far;
            sfDoubleLine.LineAlignment = StringAlignment.Center;
            
            List<System.Windows.Forms.Control> ctrls = new TaskOrderView().GetControlList();
            Rectangle rect;
            foreach(System.Windows.Forms.Control ctrl in ctrls){
            	if ((ctrl.Name == "label_PoDate") ||
            	    (ctrl.Name == "label_Remark") ||
            	    (ctrl.Name == "label_ProcessSeqKor") ||
            	    (ctrl.Name.ToLower().Contains("check")) == true) {continue;}

            	rect = new Rectangle(ctrl.Location.X, ctrl.Location.Y + 80, ctrl.Size.Width - 5, 25);
            	//g.DrawRectangle(Pens.Black, rect);
            	g.DrawString(ctrl.Text, this.m_SubFont, Brushes.Black, rect, sf);
            }

            g.DrawLine(PenBlack, new Point(15, 80), new Point(1160, 80));
            g.DrawLine(PenBlack, new Point(15, 105), new Point(1160, 105));
            
            ctrls = null;
            int positionx = 25 + 90;
            int iMin = _printCount;
            for (; (_printCount < iMin + MAX_ROW); _printCount++ )
            {
            	TaskOrderView view = null;
            	try{
            		view = viewList[_printCount];
            	}
            	catch(Exception){ break; }
            	ctrls = view.GetControlList();
                
                foreach(System.Windows.Forms.Control ctrl in ctrls){
            		rect = new Rectangle(ctrl.Location.X, ctrl.Location.Y + positionx - 5, ctrl.Size.Width, 25);
            		if ((ctrl.Name.ToLower().Contains("check")) ||
            			(ctrl.Name == "label_PoDate") ||
            		    (ctrl.Name == "label_left")){
            			continue;
            		}
                	else if (ctrl.Name == "label_OrderNo"){
                		g.DrawString("*" + ctrl.Text + "*", this.m_barcodeFont, Brushes.Black, ctrl.Location.X - 15, ctrl.Location.Y - 5 + positionx);
                		g.DrawString(ctrl.Text, this.m_SmallFont, Brushes.Black, ctrl.Location.X, ctrl.Location.Y + positionx + 25);
                	}
            		else if (ctrl.Name == "label_Remark"){
            			rect = new Rectangle(ctrl.Location.X, ctrl.Location.Y + positionx - 5, ctrl.Size.Width, 50);// 비고란 길이 두배로 하기 - by jhson 130502
            			g.DrawString(ctrl.Text, this.m_SmallFont, Brushes.Black, rect, sf);
            		}
            		else if (ctrl.Name == "label_ProcessSeqKor"){
            			
            			g.DrawString(ctrl.Text, this.m_SmallFont, Brushes.Black, rect, sfProcSeq);
            		}
            		// 재고생산지시일 경우 작업지시 출력 시 거래처란에 '재고'로 표현 하기 - by jhson 121115
	            	else if (ctrl.Name == "label_Customer"){
	            		if ((ctrl.Tag != null) &&
            			    (ctrl.Tag.ToString() != "O")){
	        		    	g.DrawString("재고", this.m_SubFont, Brushes.Black, rect, sf);
	            		}
            			else{
            				g.DrawString(ctrl.Text, this.m_SubFont, Brushes.Black, rect, sf);
            			}
	            	}
//            		else if (ctrl.Name == "label_LengthPop"){
//            			rect = new Rectangle(ctrl.Location.X - 50, ctrl.Location.Y + positionx - 5, ctrl.Size.Width, 30);
//            			g.DrawString(ctrl.Text, this.m_DoubleLineFont, Brushes.Black, rect, sfDoubleLine);
//            		}
            		else {
            			g.DrawString(ctrl.Text, this.m_SmallFont, Brushes.Black, rect, sf);
            		}
                }

                Point point5 = new Point(15, positionx + 40 + 25);// 비고란 길이 두배로 하기 - by jhson 130502
                Point point6 = new Point(1160, positionx + 40 + 25);// 비고란 길이 두배로 하기 - by jhson 130502

                g.DrawLine(PenBlack, point5, point6);

                positionx = positionx + 50 + 25;// 비고란 길이 두배로 하기 - by jhson 130502
            }
            
            rect = new Rectangle(15, positionx + 10, 1100, 25);
            //g.DrawRectangle(Pens.Black, rect);
            g.DrawString( _pageNum + "/" + (Math.Truncate( ((double)viewList.Count / (double)MAX_ROW) ) + 1), this.m_SubFont, Brushes.Black, rect, sf);
            
            g.DrawString(DateTime.Now.ToString(), this.m_SmallFont, Brushes.Black, 15, positionx + 10);
            // g.DrawString("*2012-12-08*", this.m_barcodeFont, Brushes.Black, 10, 100); //바코드 출력

            



            //StringFormat sf = new StringFormat();
            //sf.Alignment = StringAlignment.Near;//	세로정렬
            //sf.LineAlignment = StringAlignment.Center; //  가로정렬
            //Rectangle rect = new Rectangle(100, 280, 500, this.m_MainFont.Height * 3);// 글출력하는 영역생성
            //g.DrawRectangle(Pens.Black, rect);
            //g.DrawString("일화1", this.m_MainFont, Brushes.Black, rect, sf);// 내용출력
            //g.DrawString("일화2", this.m_SubFont, Brushes.Black, rect); // 내용출력
        }
		
		void TaskOrderSearchViewSearchClick(object sender, EventArgs e)
		{
			taskOrderViewList.SetData(ViewCtrl.TaskOrder.SearchByViewData(taskOrderSearchView.ViewData as TaskOrder));
		}
		
		void TaskOrderSearchViewPrintClick(object sender, EventArgs e)
		{
			ViewCtrl.TaskOrder.InsertPublishedInfo(taskOrderViewList.GetSelectedList());
			Button_PrintClick(sender, e);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			((MainForm)this.MdiParent).FormTest.Show();
			((MainForm)this.MdiParent).FormTest.WindowState = FormWindowState.Maximized;
		}
	}
}
