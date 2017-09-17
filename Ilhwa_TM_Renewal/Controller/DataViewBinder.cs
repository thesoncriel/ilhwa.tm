/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-01
 * Time: 오전 11:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Theson.Common;
using Theson.DBManager;
using Theson.Util.Config;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of DataViewBinder.
	/// </summary>
	public class DataViewBinder
	{
		public const string TABLE_EQUIPMENT = 	"table_select find_equipment";
		public const string TABLE_WORKER = 		"table_select find_worker_code";
		public const string TABLE_BADCODE = 	"table_select find_bad_code";
		public const string TABLE_CUSTOMER = 	"table_select find_customer_code";
		public const string TABLE_PRODUCT = 	"table_select find_product_code";
		public const string TABLE_OD = 			"table_select find_outer_diamenter";
		public const string TABLE_THICKNESS = 	"table_select find_thickness";
		public const string TABLE_SEL_THK =		"table_select find_task_order_thickness";
		
		private IDBManager _dbm = null;
		private DataSet _commonData = null;

		public IDBManager DBManager{
			get{
				return _dbm;
			}
			set{
				_dbm = value;
			}
		}
		
		public DataSet Data{
			get{ return _commonData; }
		}
		
		public DataViewBinder(){
			Init();
		}
		
		public void Init(){
			ExcelConfigTable match = new ExcelConfigTable();
			IniConfigTable config = new IniConfigTable();

			try{
				match.Load(@"Config\class_db_matching_info.xls");
				config.Load(@"Config\config.ini");
				
				if (config["Database Server", "Express"] == "true"){
					_dbm = new MsSqlDBManager(true);
				}
				else{
					_dbm = new MsSqlDBManager(false);
				}
				
				_commonData = new DataSet();
				_dbm.MatchTable = match;
				_dbm.Config = config;
				_dbm.Open();
				
				LoadCommonData();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void LoadCommonData(){
			string[] saQueryKeys = {
				TABLE_BADCODE,
				TABLE_CUSTOMER,
				TABLE_OD,
				TABLE_PRODUCT,
				TABLE_THICKNESS,
				TABLE_WORKER,
				TABLE_EQUIPMENT,
				TABLE_SEL_THK
			};
			
			foreach(string key in saQueryKeys){
				_commonData.Merge((DBManager.ExecuteQuery(key, "", "")));
			}
		}
		public void BindingViewData(System.Windows.Forms.Control container, IMultiColumnRecordable value){
			BindingViewData(container, "label", value);
		}
		public void BindingViewData(System.Windows.Forms.Control container, string ctrlType, IMultiColumnRecordable value){
			if(value == null) return;
			
			string sKey = "";
			string sVal1 = "";
			string sVal2 = "";
			string sDiv = "";
			ctrlType += "_";
				
			foreach(System.Windows.Forms.Control ctrl in container.Controls){
				if (ctrl is Button) { continue; }
				
				sKey = ctrl.Name.Replace(ctrlType, "");
				
				if (value.ContainsKey(sKey) == true){
					ctrl.Text = value[sKey];
					continue;
				}
				
				if (ctrl.Name.Contains("_") == false) continue;
				
				if (value.ContainsKey(sKey + "1") == true) {
					sVal1 = value[sKey + "1"];
				}
				if (value.ContainsKey(sKey + "2") == true) {
					sVal2 = value[sKey + "2"];
				}
				
				sDiv = (ctrl.AutoSize == true)? " / " : "\r\n";
				ctrl.Text = sVal1 + ( ((sVal1 == "") || (sVal2 == ""))? "" : sDiv) + sVal2;
			}
		}
		
		public void BindingViewLabelValue(System.Windows.Forms.Control container, IMultiColumnRecordable data){
			BindingViewLabelValue(container, data, data.GetType().Name, true);
		}
		public void BindingViewLabel(System.Windows.Forms.Control container, IMultiColumnRecordable data){
			BindingViewLabelValue(container, data, null, false);
		}
		public void BindingViewLabel(System.Windows.Forms.Control container, string className){
			BindingViewLabelValue(container, null, className, false);
		}
		
		public void BindingViewLabelValue(System.Windows.Forms.Control container, IMultiColumnRecordable data, string className, bool bindValue){
			if (((bindValue == false) && (className == null)) ||
			    (bindValue && (data == null))
			   ) return;
			
			string sKey = "";
			string sLabel = "";
			int iRowCount = 0;
			System.Windows.Forms.Control ctrl = null;
			
			DBManager.MatchTable.GoToTable(className);
			iRowCount = DBManager.MatchTable.RowCount;

			for(int i = 0; i < iRowCount; i++){
				sKey = DBManager.MatchTable[i , "key"];
				sLabel = DBManager.MatchTable[i , "label"];
				
				if ((sKey == "") || (sLabel == "")) continue;
				
				ctrl = container.Controls["label" + i];
				if (ctrl == null) continue;
				ctrl.Text = sLabel + " :";
				ctrl.Visible = true;
				
				ctrl = container.Controls["label_Value" + i];
				if (ctrl == null) continue;
				if (bindValue == true) ctrl.Text = data[sKey];
				else	ctrl.Text = "";
				ctrl.Visible = true;
			}
		}
		
		
	}
}
