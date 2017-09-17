/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-12
 * Time: 오후 8:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

using Artn.Ilhwa.Model;
using Theson.Common;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of TaskOrderControl.
	/// </summary>
	public class TaskOrderController: AbsViewController
	{
		private TaskOrder _searchParams = null;
		
		public TaskOrderController(){}
		
		public override DataViewController ViewBinder {
			get { return base.ViewBinder; }
			set { 
				base.ViewBinder = value; 
				_searchParams = CreateSearchParams();
			}
		}
		
		public DataTable SearchByDate(string dateStr){
			_searchParams["Param_SearchFlag"] = "Date";
			_searchParams["Param_Date"] = dateStr;
			_searchParams["Param_OrderNo"] = "";
			return LoadTable("table_select find_task_order", _searchParams);
		}
		
		public DataTable SearchByCode(string keyword){
			if (keyword.Length < 8) return null;
			
			_searchParams["Param_SearchFlag"] = "PoNo";
			_searchParams["Param_OrderNo"] = keyword;
			_searchParams["Param_Date"] = "";
			return LoadTable("table_select find_task_order", _searchParams);
		}
		
		public DataTable SearchByConfigExpress(){
			bool isExpress = Boolean.Parse(ViewBinder.DBManager.Config["Database Server", "Express"]);

			if (isExpress == true)
			{
				return SearchByDate("2012-6-15");
			}
			else{
				return SearchByDate(DateTime.Now.ToString("yyyy-MM-dd"));
			}
		}
		
		public DataTable LoadTable(string queryKey, TaskOrder value){
			DataTable data = ViewBinder.DBManager.ExecuteQuery(queryKey, value).Tables[queryKey];
			
			OnLogMessage(this, "작업지시 내역에 대한 검색이 완료 되었습니다.");
			
			return data;
		}
		
		public override IMultiColumnRecordable CreateModel(DataRow row){
			return new TaskOrder(ViewBinder.DBManager.MatchTable, row);
		}
		
		public TaskOrder CreateSearchParams(){
			return new TaskOrder(ViewBinder.DBManager.MatchTable, null);
		}
		
		public DataTable SearchByVarOption(TaskOrder value){
			return LoadTable("table_select find_task_order_varopt", value);
		}
	}
}
