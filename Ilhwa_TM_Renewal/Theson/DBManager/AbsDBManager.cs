using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using Artn.Ilhwa.Model;
using Theson.DBManager;
using Theson.Common;
using Theson.Util;

namespace Theson.DBManager
{
    public abstract class AbsDBManager: IDBManager
    {
        private TextLogger _txtLogger = null;
        private String _dbName = "";
        private List<String> _tableNames = null;
        private Dictionary<String, List<String>> _columnNames = null;
        private IConfigTable _config = null;
        private IConfigTable _queryReader = null;
        private IConfigDataSet _matchTable = null;
        protected Dictionary<string, string> _dicOutParams = new Dictionary<string, string>();

        public AbsDBManager()
        {
            _txtLogger = new TextLogger(Environment.CurrentDirectory + "\\err_" + GetDbmsName() + ".log");
        }

        protected void WriteLog(String msg) { _txtLogger.WriteLog(msg); }
        protected String CheckFilePath(String filePath){ return _txtLogger.CheckFilePath(filePath); }

        #region IDBManager 멤버

        public virtual string DBName
        {
            get
            {
                return _dbName;
            }
            set
            {
                _dbName = value;
            }
        }

        public IConfigTable Config
        {
            get
            {
                return _config;
            }
            set
            {
                _config = value;
                _queryReader = new XmlQueryReader(GetDbmsName(), _config["Query Info", "QueryFile"]);
            }
        }
        
        public IConfigTable QueryReader{
        	get{ return _queryReader; }
        }
        
        public IConfigDataSet MatchTable{
        	get{ return _matchTable; }
        	set{ _matchTable = value; }
        }

        public List<string> GetTableNames()
        {
            if (_tableNames == null) _tableNames = ReadTableNames();

            return _tableNames;
        }

        public List<string> GetColumnNames(string tableName)
        {
            if ((_columnNames == null) || 
                (_columnNames.Count < 1))
            {
                _columnNames = ReadColumnNames(GetTableNames().ToArray());
            }

            return _columnNames[tableName];
        }
        
        public virtual List<SqlParameter> GetParamList(string queryKey, IMultiColumnRecordable data){
			List<SqlParameter> paraList = new List<SqlParameter>();
			int iRowCount = 0;
			string sKey = "";
			string sParam = "";
			
			MatchTable.GoToTable(data.GetType().Name);
			iRowCount = MatchTable.RowCount;
			_dicOutParams.Clear();
			
			for(int i = 0; i < iRowCount; i++){
				sParam = MatchTable[i, queryKey];
				
				if (sParam == "") continue;
				
				sKey = MatchTable[i, "key"];
				
				if 		(sKey == "#now()") 			paraList.Add(new SqlParameter(sParam, DateTime.Now));
				else if (sKey == "#now(yyyyMMdd)")	paraList.Add(new SqlParameter(sParam, DateTime.Now.ToString("yyyyMMdd")));
				else if (sKey == "") 				paraList.Add(new SqlParameter(sParam, ""));
				else if (sKey.StartsWith("#"))		paraList.Add(new SqlParameter(sParam, sKey.Substring(1)));
				else if (sKey.StartsWith("++"))		paraList.Add(new SqlParameter(sParam, (Int32.Parse(data[sKey.Substring(2)]) + 1).ToString()));
				else if (sKey.StartsWith("@"))	{
					SqlParameter para = new SqlParameter();
					para.ParameterName = sParam;
					para.Direction = ParameterDirection.Output;
					para.Size = 100;
					paraList.Add(para);
					_dicOutParams[sParam] = "";
				}
				else							paraList.Add(new SqlParameter(sParam, data[sKey]));
			}
			
			return paraList;
		}
        public virtual string GetOutputParamValue(string key){ return _dicOutParams[key]; }
        
        public abstract DataSet ExecuteQuery(string queryKey, IMultiColumnRecordable data);
		public abstract int ExecuteNonQuery(string queryKey, IMultiColumnRecordable data);
		public abstract DataSet ExecuteQuery(string queryKey, string param, string value);
		public abstract int ExecuteNonQuery(string queryKey, string param, string value);

        public abstract List<string> ReadTableNames();
        public abstract Dictionary<String, List<String>> ReadColumnNames(String[] tableNames);
        public abstract DataSet ExecuteQuery(string query);
        public abstract int ExecuteNonQuery(string query);

        public abstract bool Backup(string bakPath);
        public abstract bool Restore(string bakPath, string restoreName);

        public abstract bool CreateDB(string dbName);
        public abstract bool DropDB(string dbName);
        public abstract string GetDbmsName();
        
        

        #endregion

        #region IOpenable 멤버

        public abstract void Open();
        public abstract void Close();
        public abstract bool IsOpen();

        #endregion
    }
}
