/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-21
 * Time: 오전 6:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.OleDb;
using Theson.Util.Config;
using LiAsExcelDatabase;

namespace Theson.Util.Config
{
	/// <summary>
	/// Description of ExcelConfigTable.
	/// </summary>
	public class ExcelConfigTable: AbsConfigTable, Theson.Common.IConfigDataSet
	{
		public const String OLE_DB_CONN_STR = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0";
		
		private String _sheetName = "";
		//private OleDbConnection _conn = null;
		private DataSet _data = new DataSet();
		private LiAsExcelDB _excel = new LiAsExcelDB();
		
		public ExcelConfigTable(){}
		public ExcelConfigTable(String filePath){
			Load(filePath);
		}
		
		public override string this[string section, string key] {
			get { 
				if (_data == null) return null;

				if (key == "rowcount") return _data.Tables[_sheetName].Rows.Count.ToString();
				
				int iRow = Int32.Parse(section);
				
				return _data.Tables[_sheetName].Rows[iRow][key].ToString(); 
			}
			set { 
				int iRow = Int32.Parse(section);
				_data.Tables[_sheetName].Rows[iRow][key] = value; 
			}
		}

		public override void Load(string targetPath)
		{
//			if (_conn != null){
//				_conn.Close();
//				_conn.Dispose();
//				_conn = null;
//			}
//			_conn = new OleDbConnection(String.Format(OLE_DB_CONN_STR, targetPath));
//			_conn.Open();
			_data = _excel.OpenExcelDB(CheckFilePath(targetPath));
		}
		
		
		
		public override bool GoToCategory(string category)
		{
			try{
				//if(_data.Tables.Contains(category) == true) return true;
				
				_sheetName = category;
				
				//DataTable dt = _conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
				//String tn = dt.Rows[0]["TABLE NAME"].ToString();
//				OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [$" + _sheetName + "];", _conn);
//				adapter.Fill(_data, category);
				
				return true;
			}
			catch(Exception ex){
				WriteLog("ExcelConfigTable.GoToSection : " + ex.ToString());
				return false;
			}
		}
		
		public string this[int row, string col] {
			get {
				if (_data == null) return null;
				
				return _data.Tables[_sheetName].Rows[row][col].ToString(); 
			}
			set {
				_data.Tables[_sheetName].Rows[row][col] = value; 
			}
		}
		
		public void GoToTable(string tableName)
		{
			_sheetName = tableName;
		}
		
		public int RowCount
		{
			get{ return _data.Tables[_sheetName].Rows.Count; }
		}
	}
}
