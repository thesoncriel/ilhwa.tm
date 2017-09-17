/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-20
 * Time: 오후 7:11
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
	/// Description of TaskOrder.
	/// </summary>
	public class TaskOrder: AbsMatchTableRecordData
	{
		public TaskOrder(IConfigDataSet matchTable, DataRow data): base(matchTable, data){}
		
		public override void SetData(IConfigDataSet matchTable, DataRow data)
		{
			base.SetData(matchTable, data);
			
		
		}
		
		public override string[] GetUpdateQueryKeys()
		{
			string[] saRet = {
				"table_update task_order_status"
			};
			
			return saRet;
		}
		
		public override string[] GetInsertQueryKeys()
		{
			return null;
		}
	}
}
