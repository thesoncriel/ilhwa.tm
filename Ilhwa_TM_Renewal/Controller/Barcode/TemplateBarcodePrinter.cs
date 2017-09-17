/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2013-05-14
 * Time: 오후 2:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using Theson.Common;

namespace Artn.Ilhwa.Controller.Barcode
{
	/// <summary>
	/// Description of TemplateBarcodePrinter.
	/// </summary>
	public class TemplateBarcodePrinter: BarcodePrinter
	{
		private static string barcode1 = "";
		private static string barcode2 = "";
		
		public TemplateBarcodePrinter(IConfigTable config):base(config){
			if ((barcode1 == "") || (barcode2 == "")){
				barcode1 = File.ReadAllText(Environment.CurrentDirectory + "\\" + config["Barcode Printer", "barcode1"]);
				barcode2 = File.ReadAllText(Environment.CurrentDirectory + "\\" + config["Barcode Printer", "barcode2"]);
			}
		}
		
		protected override void MBarCode_Print(string sCustName, string sProdName, string sSpec, string sBarcode, string sDeliveryDate, string sTot_Qty, string sQty, string State, string sMust_Name, string sNow_Prod,
		string sBadness, string ValueLen)
		{
			string sBarcodeData = "";
			try{
				if (sBarcode.Length < 22){
        		throw new InvalidOperationException("이 내용이 보인다면 아래쪽 한글로 된 내용까지 다 보이도록 캡처 하여 주십시요." +
        		                                    "\r\n바코드: " + sBarcode + 
        		                                    "\r\n바코드(Hex): " + this.ConvertToHexa(sBarcode) +
        		                                    "\r\n고객: " + sCustName +
        		                                    "\r\n프로드: " + sProdName +
        		                                    "\r\n스펙: " + sSpec + 
        		                                    "\r\n제공날짜: " + sDeliveryDate +
        		                                    "\r\n제공 총량: " + sTot_Qty +
        		                                    "\r\n묶음당 수량: " + sQty +
        		                                    "\r\n처리순서: " + sMust_Name +
        		                                    "\r\n공정명: " + sNow_Prod +
        		                                    "\r\n지시길이: " + ValueLen + 
        		                                    "\r\n-------끝------------------------");
	        	}
				
				if (ValueLen != ""){
					sBarcodeData = String.Format(barcode1, sBarcode, sCustName, sProdName, sQty, sTot_Qty, sSpec, ValueLen, sNow_Prod, sDeliveryDate, sBadness);
				}
				else{
					sBarcodeData = String.Format(barcode2, sBarcode, sCustName, sProdName, sQty, sTot_Qty, sSpec, ValueLen, sNow_Prod, sDeliveryDate, sBadness);
				}
				
				Write(sBarcodeData);
	            Close();
			}
			catch(InvalidOperationException ex){
				WriteLog(ex.ToString());
			}
		}
	}
}
