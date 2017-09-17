/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-27
 * Time: 오전 5:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Theson.Common;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of Badness.
	/// </summary>
	public class Badness: AbsMatchTableRecordData
	{
		public Badness(IMultiColumnRecordable parent){ parent.AddChild(this); }
		public Badness(IConfigDataSet matchTable, DataRow data): base(matchTable, data){}
		
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
