/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-20
 * Time: 오후 7:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

using Theson.Common;
using Theson.DBManager;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of AbsSubRecordData.
	/// </summary>
	public abstract class AbsSubRecordData: AbsMatchTableRecordData, IMergeRecordable
	{
		private Dictionary<String, IMultiColumnRecordable> _dicSubData = new Dictionary<string, IMultiColumnRecordable>();
		protected Dictionary<String, IMultiColumnRecordable> SubData{
			get{ return _dicSubData; }
		}
		
		public AbsSubRecordData(): base(null, null){}
		public AbsSubRecordData(IConfigDataSet matchTable, params IMultiColumnRecordable[] data):this(){
			Merge(matchTable, data);
		}
		
		public IMultiColumnRecordable GetSubRecord(string subName)
		{
			return _dicSubData[subName];
		}

		public virtual void Merge(IConfigDataSet matchTable, params IMultiColumnRecordable[] data)
		{
			int iRowCount = 0;
			string sKey = "";
			string sBaseClass = "";
			
			foreach(IMultiColumnRecordable rec in data){
				_dicSubData[rec.GetType().Name] = rec;
			}
			
			matchTable.GoToTable(this.GetType().Name);
			iRowCount = matchTable.RowCount;
				
			for(int i = 0; i < iRowCount; i++){
				sKey = matchTable[i, "key"];
				sBaseClass = matchTable[i, "base_class"];
				
				if ((sBaseClass == "") ||
					(sKey.StartsWith("#") == true)) continue;
				    
				this[sKey] = _dicSubData[sBaseClass][sKey];
			}
		}
		
		public override void MemberClear(){
			_dicSubData.Clear();
			_dicSubData = null;
			base.MemberClear();
		}
	}
}
