/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-21
 * Time: 오후 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Theson.Common;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of TaskProcessList.
	/// </summary>
//	public abstract class TaskProcessList: AbsSubRecordData
//	{
//		public TaskProcessList(IConfigDataSet matchTable, DataRow data): base(matchTable, data){}
//		
//		public override void SetData(IConfigDataSet matchTable, System.Data.DataRow data)
//		{
//			base.SetData(matchTable, data);
//			string[] saProcSeq = this["ProcessSeq"].Split('|');
//			string sProcCode = "";
//
//			foreach(string procName in saProcSeq){
//				sProcCode = ConvertToProcessCode(procName);
//				//SubData[sProcCode] = new TaskProcess(matchTable, this, sProcCode);
//			}
//		}
//		
//		public override string[] GetUpdateQueryKeys()
//		{
//			string[] saRet = {
//				"table_update task_order_status"
//			};
//			
//			return saRet;
//		}
//		
//		public override string[] GetInsertQueryKeys()
//		{
//			return null;
//		}
//		
//		public string ConvertToProcessCode(string korName){
//			//			T_Plan_Runing.Proc_Code 값에 따른 공정명
//			//			조관PL	1A
//			//			포장1	1E
//			//			PL2		2C
//			//			사각		2A
//			//			HL		2B
//			//			절단		2D
//			//			포장2	2E
//			if 		(korName.Contains("조관") == true) 	return "1A";
//			else if (korName == "포장1") 				return "1E";
//			else if (korName.StartsWith("PL") == true)	return "2C";
//			else if (korName == "사각")					return "2A";
//			else if (korName == "HL")					return "2B";
//			else if (korName == "절단")					return "2D";
//			else 										return "2E";
//		}
//	}
}
