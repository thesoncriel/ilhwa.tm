/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-20
 * Time: 오후 4:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Theson.Common;
using Theson.DBManager;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of AbsDatabaseRecordData.
	/// </summary>
	public abstract class AbsDataViewManageable: TreeRecordable, IMultiColumnRecordable
	{
		private List<string> _keyList = null;
		private IMultiColumnDataView _dataView = null;
		
		public AbsDataViewManageable(){}
		
		public abstract void SetData(IConfigDataSet matchTable, DataRow data);
		public abstract void SetData(IConfigDataSet matchTable, params string[] data);
		
		public abstract void Update(IDBManager dbm);
		public abstract void Insert(IDBManager dbm);

		public virtual List<string> GetKeyList()
		{
			if (_keyList != null) return _keyList;
			
			IEnumerator<string> em = Data.Keys.GetEnumerator();
			_keyList = new List<string>();
			
			while(em.MoveNext() == true){
				_keyList.Add(em.Current);
			}
			
			return _keyList;
		}
	
		public override string this[string attrName] {
			get { return base[attrName]; }
			set { 
				base[attrName] = value;
				
				if(_dataView != null) _dataView.ViewData = this;
			}
		}
		
		public IMultiColumnDataView DataView {
			get {
				return _dataView;
			}
			set {
				_dataView = value;
			}
		}
		
		public override void MemberClear()
		{
			_dataView = null;
			base.MemberClear();
		}
	}
}
