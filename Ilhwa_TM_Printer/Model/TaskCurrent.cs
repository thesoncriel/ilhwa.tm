/*
 * Created by SharpDevelop.
 * User: shkang
 * Date: 2013-06-04
 * Time: 오전 10:27
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
	/// Description of TaskCurrent.
	/// </summary>
	public class TaskCurrent : AbsMatchTableRecordData
	{
		public TaskCurrent(IConfigDataSet matchTable, DataRow data) : base(matchTable, data){}
		
		public override void SetData(IConfigDataSet matchTable, DataRow data)
		{
			base.SetData(matchTable, data);
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
