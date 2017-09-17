/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-31
 * Time: 오후 4:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO.Ports;
using System.Text;

using Theson.Common;

namespace Artn.Ilhwa.Controller.Barcode
{
	/// <summary>
	/// Description of BarcodePrinter.
	/// </summary>
	public class BarcodePrinter: BarcodeSerialPort
	{
		public BarcodePrinter(IConfigTable config):base(config){}
		
		public void Print_1stProc(IMultiColumnRecordable data){
			MBarCode_Print(
				data["Customer"],
				data["ProdName1"], 
				data["ODName"] + " * " + data["Thickness1"] + " x " + data["PlanLength"],//주문길이-->지시길이로 변경 120911 jhson
				data["ProductCode"],
				data["DeliveryDate"],
				data["TotalQuantity"], // Quantity와 BunchCount를 곱한 값.
				data["Quantity"],
				"",
				data["ProcessSeqKor"],
				data["ProcessCodeKor"],
				"",
				data["ERP_Len"]
			);	
		}
		public void Print_2ndProc(IMultiColumnRecordable data){
			MBarCode_Print(
				data["Customer"],
				data["ProdName2"], 
				data["ODName"] + " * " + data["Thickness2"] + " x " + data["PlanLength"],//주문길이-->지시길이로 변경 120911 jhson
				data["ProductCode"],
				data["DeliveryDate"],
				data["TotalQuantity"], // Quantity와 BunchCount를 곱한 값.
				data["Quantity"],
				"",
				data["ProcessSeqKor"],
				data["ProcessCodeKor"],
				"",
				data["ERP_Len"]
			);
		}
		public void Print_Etc(IMultiColumnRecordable data){
			MBarCode_Print(
				data["Customer"],
				data["ProdName"], 
				data["ODName"] + " * " + data["Thickness"] + " x " + data["PlanLength"],//주문길이-->지시길이로 변경 120911 jhson
				data["ProductCode"],
				data["DeliveryDate"],
				data["TotalQuantity"], // Quantity와 BunchCount를 곱한 값.
				data["Quantity"],
				"",
				"",
				"포장",
				"",
				""
			);
		}
		// B012 - 
		private void MBarCode_Print(
            string sCustName, 
            string sProdName, 
            string sSpec, 
            string sBarcode, // 출처 제품의 바코드
            string sDeliveryDate, // 제공 예정 날짜
            string sTot_Qty, // 제공될 총 량
            string sQty, // 바코드 붙일 묶음당 개수
            string State, // ??
            string sMust_Name, //총 처리공정 순서
            string sNow_Prod,//제품이 나온 공정명
            string sBadness, // 불량여부??
            string ValueLen) // T_Plan_Detail.ERP_Len - ERP 측에서 전달한 지시 길이
        {
			try{
	        	StringBuilder sbSerialData = new StringBuilder();
	        	if (sBarcode.Length < 22){
	        		throw new InvalidOperationException("이 내용이 보인다면 담당자 조부연[과장] 님에게 말씀 하시어\r\n" +
	        		                                    "본 장면을 캡처 하여 아로테크노로 보내주시길 바랍니다.\r\n" +
	        		                                    "아래쪽 한글로 된 내용까지 다 보이도록 캡처 하여 주십시요." +
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
	            //원본
	            //sSerialData += "^XA^SEE:UHANGUL.DAT^FS" + Environment.NewLine);
	            //sSerialData += "^CWJ,E:KFONT3.FNT^FS" + Environment.NewLine);
	            //sSerialData += "^CI26" + Environment.NewLine);
	            //sSerialData += "^FO30,60^AJN,65,55^FD" + sCustName + "^FS" + Environment.NewLine);
	            //sSerialData += "^FO30,140^AJN,65,55^FD" + sProdName + "^FS" + Environment.NewLine);
	            //sSerialData += "^FO30,220^AJN,65,55^FD" + sSpec + "^FS" + Environment.NewLine);
	            //sSerialData += "^BY2,1,4,10" + Environment.NewLine);
	            //sSerialData += "^FO30,410" + Environment.NewLine);
	            //sSerialData += "^BCN,80,Y,N,N^FD" + sBarcode + "^FS" + Environment.NewLine);
	            //sSerialData += "^BY1,1,4,10" + Environment.NewLine);
	            //sSerialData += "^FO550,60" + Environment.NewLine);
	            //sSerialData += "^BCB,80,N,N,N^FD" + sBarcode + "^FS" + Environment.NewLine);
	            //sSerialData += "^PQ1^XZ" + Environment.NewLine);
	
	            //완성본!!! (가운데바코드) 기타발행에 있던거임
	            //sSerialData += "^XA^SEE:UHANGUL.DAT^FS" + Environment.NewLine);
	            //sSerialData += "^CWJ,E:KFONT3.FNT^FS" + Environment.NewLine);
	            //sSerialData += "^CI26" + Environment.NewLine);
	            //sSerialData += "^FO30,30^AJB,55,45^FD" + sCustName + "^FS" + Environment.NewLine);
	            //sSerialData += "^FO80,30^AJB,55,45^FD" + sProdName + "^FS" + Environment.NewLine);
	            //sSerialData += "^FO130,30^AJB,55,45^FD" + sSpec + "^FS" + Environment.NewLine);
	
	            //sSerialData += "^FO650,30^AJR,55,45^FD" + sCustName + "^FS" + Environment.NewLine);
	            //sSerialData += "^FO600,30^AJR,55,45^FD" + sProdName + "^FS" + Environment.NewLine);
	            //sSerialData += "^FO550,30^AJR,55,45^FD" + sSpec + "^FS" + Environment.NewLine);
	
	            //sSerialData += "^BY1,1,4,10" + Environment.NewLine);
	            //sSerialData += "^FO200,150" + Environment.NewLine);
	            //sSerialData += "^BCB,340,N,N,N^FD" + sBarcode + "^FS" + Environment.NewLine);
	            //sSerialData += "^PQ1^XZ" + Environment.NewLine);
	            
	            //원본
	//                string sSerialData = string.Empty;
	//                sSerialData += "^XA^SEE:UHANGUL.DAT^FS" + Environment.NewLine;
	//                sSerialData += "^CWJ,E:KFONT3.FNT^FS" + Environment.NewLine;
	//                sSerialData += "^CI26" + Environment.NewLine;
	//
	//                sSerialData += "^BY2,1,4,10" + Environment.NewLine;
	//                sSerialData += "^FO40,30" + Environment.NewLine;
	//                sSerialData += "^BCN,80,Y,N,N^FD" + sBarcode + "^FS" + Environment.NewLine;
	//
	//                sSerialData += "^FO30,150^AJN,55,45^FD" + sCustName + "^FS" + Environment.NewLine;
	//                sSerialData += "^FO30,220^AJN,55,45^FD" + sProdName + "^FS" + Environment.NewLine;
	//                sSerialData += "^FO450,220^AJN,35,25^FD 수량 " + sQty + "/" + sTot_Qty + " 개^FS" + Environment.NewLine;
	//                sSerialData += "^FO30,280^AJN,35,25^FD" + sSpec + "^FS" + Environment.NewLine;
	//                if (ValueLen != "")
	//                    sSerialData += "^FO450,280^AJN,35,25^FD 배수길이" + ValueLen + "^FS" + Environment.NewLine;
	//                sSerialData += "^FO30,330^AJN,35,25^FD" + sNow_Prod + "^FS" + Environment.NewLine;
	//                sSerialData += "^FO200,330^AJN,35,25^FD" + sDeliveryDate + "^FS" + Environment.NewLine;
	//                sSerialData += "^FO450,330^AJN,35,25^FD" + sBadness + "^FS" + Environment.NewLine;
	//
	//                sSerialData += "^BY2,1,4,10" + Environment.NewLine;
	//                sSerialData += "^FO40,410" + Environment.NewLine;
	//                sSerialData += "^BCN,80,Y,N,N^FD" + sBarcode + "^FS" + Environment.NewLine;
	//                sSerialData += "^PQ1^XZ" + Environment.NewLine;
	
	            //완성본!!! (가운데바코드) 제품발행쪽에 있던거
	            
	            sbSerialData.Append(string.Empty);
	            sbSerialData.Append("^XA^SEE:UHANGUL.DAT^FS" + Environment.NewLine);
	            sbSerialData.Append("^CWJ,E:KFONT3.FNT^FS" + Environment.NewLine);
	            sbSerialData.Append("^CI26" + Environment.NewLine);
	
	            sbSerialData.Append("^BY2,1,4,10" + Environment.NewLine);
	            sbSerialData.Append("^FO40,30" + Environment.NewLine);
	            sbSerialData.Append("^BCN,80,Y,N,N^FD" + sBarcode + "^FS" + Environment.NewLine);
	
	            sbSerialData.Append("^FO30,150^AJN,55,45^FD" + sCustName + "^FS" + Environment.NewLine);
	            sbSerialData.Append("^FO30,220^AJN,55,45^FD" + sProdName + "^FS" + Environment.NewLine);
	            sbSerialData.Append("^FO450,220^AJN,35,25^FD 수량 " + sQty + "/" + sTot_Qty + " 개^FS" + Environment.NewLine);
	            sbSerialData.Append("^FO30,280^AJN,35,25^FD" + sSpec + "^FS" + Environment.NewLine);
	            
	            if (ValueLen != ""){
	            	//sSerialData.Append("^FO450,280^AJN,35,25^FD 배수" + sSpec + "^FS" + Environment.NewLine);
	            	sbSerialData.Append("^FO450,280^AJN,35,25^FD 배수길이" + ValueLen + "^FS" + Environment.NewLine);
	            }
	            sbSerialData.Append("^FO30,330^AJN,35,25^FD" + sNow_Prod + "^FS" + Environment.NewLine);
	            sbSerialData.Append("^FO200,330^AJN,35,25^FD" + sDeliveryDate + "^FS" + Environment.NewLine);
	            sbSerialData.Append("^FO450,330^AJN,35,25^FD" + sBadness + "^FS" + Environment.NewLine);
	
	            sbSerialData.Append("^BY2,1,4,10" + Environment.NewLine);
	            sbSerialData.Append("^FO40,410" + Environment.NewLine);
	            sbSerialData.Append("^BCN,80,Y,N,N^FD" + sBarcode + "^FS" + Environment.NewLine);
	            sbSerialData.Append("^PQ1^XZ" + Environment.NewLine);
	            
	            Write(sbSerialData.ToString());
	           // Write(sSerialData);
	            Close();
			}
			catch(InvalidOperationException ex){
				WriteLog(ex.ToString());
			}
        }
		
		
	}
}
