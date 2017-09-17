/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-12
 * Time: 오후 8:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
using Theson.Common;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of AbsViewController.
	/// </summary>
	public abstract class AbsViewController
	{
		public event LogEventHandler LogMessage;
		protected void OnLogMessage(object sender, string msg){
			if(LogMessage != null) LogMessage(sender, msg);
		}
		
		private DataViewController _viewBinder = null;
		public virtual DataViewController ViewBinder{
			get{
				return _viewBinder;
			}
			set{
				_viewBinder = value;
			}
		}
		
		public AbsViewController(){}
		
		public List<IMultiColumnRecordable> CreateModelList(DataSet data){
			return CreateModelList(data.Tables[0].Select());
		}
		
		public List<IMultiColumnRecordable> CreateModelList(DataRow[] rows){
			List<IMultiColumnRecordable> viewDataList = new List<IMultiColumnRecordable>();
			
			foreach(DataRow row in rows){
				viewDataList.Add(CreateModel(row));
			}
			
			return viewDataList;
		}
		
		protected string ShowNumberPad(string initValue){
			FormNumberPad numPad = new FormNumberPad();
			int iValue = 0;
			numPad.Value = initValue;
			
			if (numPad.ShowDialog() == DialogResult.OK){
				return numPad.Value;
			}
			else{
				return null;
			}
		}
		
		protected List<string[]> ShowGridSelector(string tableKey){
			FormGridSelector frm = new FormGridSelector(true);
			List<string[]> saList = new List<string[]>();
			Dictionary<string, int> dicData = null;
			string[] saValue = null;
			frm.SetData(ViewBinder.Data.Tables[tableKey].Select());
			
			if (frm.ShowDialog() == DialogResult.OK){
				dicData = frm.GetSelectData();
				
				foreach(KeyValuePair<string ,int> keyval in dicData){
					saValue = new string[3];
					saValue[0] = keyval.Key;
					saValue[1] = keyval.Value.ToString();
					saValue[2] = frm.GetLengthData();
					saList.Add(saValue);
				}
			}
			frm.MemberClear();
			return saList;
		}
		
		protected string ShowGridSelectorSingle(string tableKey){
			FormGridSelector frm = new FormGridSelector(false);
			frm.SetData(ViewBinder.Data.Tables[tableKey].Select());
			
			if (frm.ShowDialog() == DialogResult.OK){
				return frm.GetSelectSingleData();
			}
			else {
				return null;
			}
		}
		
		public abstract IMultiColumnRecordable CreateModel(DataRow row);
	}
}
