/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-21
 * Time: 오후 10:26
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
	/// Description of AbsMatchTableRecordData.
	/// </summary>
	public abstract class AbsMatchTableRecordData: AbsDataViewManageable
	{
		public AbsMatchTableRecordData(){}
		
		public AbsMatchTableRecordData(IConfigDataSet matchTable, System.Data.DataRow data){
			SetData(matchTable, data);
		}
		
		public override void SetData(IConfigDataSet matchTable, params string[] data)
		{
			if(data == null) return;
			
			int iRowCount = 0;
			String sKey = "";
			String sName = GetType().Name;
			
			matchTable.GoToTable(sName);
			iRowCount = matchTable.RowCount;
			
			for(int i = 0; i < iRowCount; i++){
				sKey = matchTable[i, "key"];

				this[sKey] = data[i];
			}
		}
		
		public override void SetData(IConfigDataSet matchTable, System.Data.DataRow data)
		{
			if(data == null) return;
			
			int iRowCount = 0;
			String sKey = "";
			String sCol = "";
			String sName = GetType().Name;
			String sVal = "";
			
			matchTable.GoToTable(sName);
			iRowCount = matchTable.RowCount;
			
			for(int i = 0; i < iRowCount; i++){
				sKey = matchTable[i, "key"];
				sCol = matchTable[i, "db_column"];
				
				if (sCol == "") continue;
				sVal = data[sCol].ToString();
				
				if (sVal == "") this[sKey] = matchTable[i, "value"];
				else this[sKey] = sVal;
			}
		}
		
		public abstract String[] GetInsertQueryKeys();
		public abstract String[] GetUpdateQueryKeys();

		public override void Insert(IDBManager dbm)
		{
			string[] asQueryKey = GetInsertQueryKeys();
			
			if (asQueryKey == null) return;
			
			foreach(string queryKey in asQueryKey){
				dbm.ExecuteNonQuery(queryKey, this);
			}
		}
		
		public override void Update(IDBManager dbm)
		{
			string[] asQueryKey = GetInsertQueryKeys();
			
			if (asQueryKey == null) return;
			
			foreach(string queryKey in asQueryKey){
				dbm.ExecuteNonQuery(queryKey, this);
			}
		}
	}
}
