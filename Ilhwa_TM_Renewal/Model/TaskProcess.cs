/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-21
 * Time: 오후 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Theson.Common;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of TaskProcess.
	/// </summary>
	public class TaskProcess: AbsMatchTableRecordData
	{
		public TaskProcess(IConfigDataSet matchTable, 
		                   IMultiColumnRecordable parent, 
		                   DataRow data): base(matchTable, data){
			parent.AddChild(this);
		}
		
		public TaskProcess(IConfigDataSet matchTable, IMultiColumnRecordable parent, string processCode){
			matchTable.GoToTable(GetType().Name);
			
			int iRowCount = matchTable.RowCount;
			
			for(int i = 0; i < iRowCount; i++){
				this[matchTable[i, "key"]] = matchTable[i, "value"];
			}
			
			parent.AddChild(this);
			
			this["OrderNo"] = parent["OrderNo"]; //부모 (TaskOrder)와 데이터를 공유 하기에 제거 될 수 있음.
			this["EquipCode"] = parent["EquipCode"]; // 기본적으론 부모의 값을 가져 오지만 추후 공정별로 변경 될 수 있음.
			this["ProcessCode"] = processCode;	// 부모의 설비 순서(ProcessSeq)를 Parsing 한 값을 사용
			// 공정 코드로 만들었다는 것은 지시 내역에 대한 공정 정보가 없다는 것을 의미 하므로 공정 상태를 기본값으로 설정함.
			this["Status"] = "A";
			this["Status_Kor"] = "지시대기";
			this["ProcessCodeKor"] = GetProcessCodeKor(processCode);
		}
		
		public string GetProcessCodeKor(string procCode){
			/*
			WHEN run.Proc_Code = '1A' THEN '조관' 
			WHEN run.Proc_Code = '1B' THEN '연마'
			WHEN run.Proc_Code = '1C' THEN '조관PL'
			WHEN run.Proc_Code = '1E' THEN '포장' 
			WHEN run.Proc_Code = '2A' THEN '사각'
			WHEN run.Proc_Code = '2B' THEN 'HL'
			WHEN run.Proc_Code = '2C' THEN 'PL' 
			WHEN run.Proc_Code = '2D' THEN '절단'
			ELSE '포장'
			 */
			if (procCode == "1A") return "조관";
			if (procCode == "1B") return "연마";
			if (procCode == "1C") return "조관PL";
			if (procCode == "1E") return "포장";
			if (procCode == "2A") return "사각";
			if (procCode == "2B") return "HL";
			if (procCode == "2C") return "PL";
			if (procCode == "2D") return "절단";
			else return "포장";
		}
		
		public override string[] GetUpdateQueryKeys()
		{
			return null;
		}
		
		public override string[] GetInsertQueryKeys()
		{
			return null;
		}
	}
}
