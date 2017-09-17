/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-24
 * Time: 오전 12:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

using Theson.Common;

namespace Artn.Ilhwa.View
{
	public delegate void DataViewEventHandler(object sender, IMultiColumnRecordable mcData);
	
	    
	public interface IDataViewList: IMultiColumnDataView{
		event DataViewEventHandler ItemSelected;
		void SetData(DataTable data);
		void SetData(List<IMultiColumnRecordable> dataList);
	}
}
