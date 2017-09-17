/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-11-29
 * Time: 오후 2:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Artn.Ilhwa.Model;
using Theson.Common;
using Theson.Util;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of LogController.
	/// </summary>
	public class LogController
	{
		private TextLogger txtLog = new TextLogger();
		
		public LogController(){}
		
		public void WriteLog(string msg){
			string sFileName = "log\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
			txtLog.LogFilePath = sFileName;
			txtLog.WriteLog(msg);
		}
		
		public void WriteByWorking(IMultiColumnRecordable data, string workType){
			// 날짜시간\t작업지시번호\t공정\t작업자\t하려던내용\t개수\t바코드\tLot-No
			string sWork = "";
			string sLog = "";
			string sQty = "none";
			string barcode = "";
			
			try{
			if (workType == "insertMat"){
				if (data is MaterialSkelpInfo){
					sWork = "스켈프투입";
					sQty = data["Weight"];
					barcode = data["Barcode"] + "," + data["MaterialNo"];
				}
				else{
					sWork = "제품투입";
					sQty = data["Quantity"];
					barcode = data["Barcode"];
				}
			}
			else if (workType == "addProd"){
				sWork = "생산추가";
				sQty = data["AddValue"];
			}
			else if (workType == "printBarcode"){
				sWork = "바코드출력";
				sQty = data["TotalQuantity"];
			}
			else if (workType == "regRemain1"){
				sWork = "1차투입잔량등록";
				sQty = data["UsableValue"];
				barcode = data["MaterialCode"];
			}
			else if (workType == "regRemain2"){
				sWork = "2차투입잔량등록";
				sQty = data["UsableValue"];
				barcode = data["ProductCode"];
			}
			else if (workType == "regRemainEx"){
				sWork = "잉여잔량등록";
				sQty = data["ProductAdd"];
				barcode = data["ProductCode"];
			}
			
			sLog = data["OrderNo"] + "\t" + 
				data["ProcessCodeKor"] + "(" + data["ProcessCode"] + ")\t" +
				data["Worker"] + "\t" +
				sWork + "\t" +
				sQty + "\t" +
				barcode;
			}
			catch(Exception ex){
				sLog = ex.ToString();
			}
			WriteLog(sLog);
		}
	}
}
