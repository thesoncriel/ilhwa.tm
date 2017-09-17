/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-04
 * Time: 오전 7:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Theson.Common;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of TempProd.
	/// </summary>
	public class TempProd: AbsMatchTableRecordData
	{
		public TempProd(IMultiColumnRecordable parent){ parent.AddChild(this); }
		public TempProd(IConfigDataSet matchTable, DataRow data): base(matchTable, data){}
		
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
