/*
 * Created by SharpDevelop.
 * User: shkang
 * Date: 2013-06-04
 * Time: 오전 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Artn.Ilhwa.Model;
using Theson.Common;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of TaskCurrentController.
	/// </summary>
	public class TaskCurrentController : AbsViewController
	{
		private TaskCurrent _searchParams = null;
		
		public TaskCurrentController(){}
		
		public override DataViewController ViewBinder{
			get { return base.ViewBinder; }
			set { 
				base.ViewBinder = value; 
				_searchParams = CreateSearchParams();
			}
		}
		
		
		public DataTable InsertData(){
			System.DateTime.Now.ToString("yyyy");
			_searchParams["@p_Date"] = DateTime.Now.ToString("yyyy-MM-dd");
			return LoadTable("table_insert task_current_insert", _searchParams);	
		}
		
		public DataTable LoadTable(string queryKey, TaskCurrent value){
			DataTable data = ViewBinder.DBManager.ExecuteQuery(queryKey, value).Tables[queryKey];
			
			OnLogMessage(this, "검색준비가 완료 되었습니다.");
			return data;
		}
		
		public TaskCurrent CreateSearchParams(){
			return new TaskCurrent(ViewBinder.DBManager.MatchTable, null);
		}
		
		public override IMultiColumnRecordable CreateModel(DataRow row)
		{
			return new TaskCurrent(ViewBinder.DBManager.MatchTable, row);
		}
	}
}
