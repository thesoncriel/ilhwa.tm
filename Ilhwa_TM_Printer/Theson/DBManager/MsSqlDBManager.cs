using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Artn.Ilhwa.Model;
using Theson.Common;

namespace Theson.DBManager
{
    public class MsSqlDBManager: AbsDBServer
    {
        public const String CONN_STR_EXPRESS = "Server=localhost\\SQLEXPRESS;Integrated security=SSPI;database={0}";
        public const String CONN_STR_SERVER = "Password={1};Persist Security Info=True;User ID={0};Initial Catalog={2};Data Source={3}"; // 0=ID, 1=PW, 2=DBName, 3=IP&Port

        private SqlConnection _connection = null;
        private bool _isExpressVersion = false;
        private DataSet _data = new DataSet();

        protected String GetLogicalDBNameFromBak(String filePath)
        {
            DataSet data = ExecuteQuery("restore headeronly from disk = '" + filePath + "';");
            
            if (data == null) return "";
            
            return data.Tables[0].Rows[0]["DatabaseName"].ToString();
        }

        public MsSqlDBManager(bool isExpressVersion)
        {
            _isExpressVersion = isExpressVersion;
            
        }

        public override List<string> ReadTableNames()
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, List<string>> ReadColumnNames(string[] tableNames)
        {
        	// TODO: 수정해라이 ㅡ.ㅡ;;
        	return null;
//            StringBuilder sbQuery = new StringBuilder();
//            sbQuery += "use {4} SELECT TABLE_NAME, COLUMN_NAME as name FROM INFORMATION_SCHEMA.Columns where (TABLE_NAME = " + tableNames[0]) ;
//
//            for(int i = 1; i < tableNames.Length; i++)
//            {
//                sbQuery += " or TABLE_NAME = ");
//                sbQuery += tableNames[i]);
//            }
//
//            ExecuteQuery(sbQuery.ToString());
				
        }

        public override DataSet ExecuteQuery(string query)
        {
        	try{
        		SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
        		
        		_data = new DataSet();
        		adapter.Fill(_data);
        		
        		return _data;
        	}
        	catch(SqlException ex){
        		WriteLog(query + "\t" + ex.Message);
        	}
        	return null;
        }

        public override int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, _connection);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                WriteLog(query + "\t" + ex.Message);
            }
            return -1;
        }

        public override bool Backup(string bakPath)
        {
            throw new NotImplementedException();
        }

        public override bool Restore(string bakPath, string restoreName)
        {
        	// TODO: 복구 기능 수정 할 것.
        	return true;
//            String sQuery = "";
//            String sUser = "";
//            sQuery = "use {4} restore database {0} from disk = '{1}' with recovery, " +
//            "move '{2}' to '{3}.mdf', " +
//            "move '{2}_Log' to '{3}.log' "; 
//
//            return ExecuteNonQuery(String.Format(sQuery, DBName, bakPath, ) > 0;
        }

        public override bool CreateDB(string dbName)
        {
            return ExecuteNonQuery("create database " + dbName) > 0;
        }

        public override bool DropDB(string dbName)
        {
            return ExecuteNonQuery("drop database " + dbName) > 0;
        }

        public override string GetDbmsName()
        {
            return "mssql";
        }

        public override void Open()
        {
            if (_isExpressVersion == true)
            {
            	_connection = new SqlConnection(String.Format(CONN_STR_EXPRESS, this.DefaultDB));
            }
            else
            {
                _connection = new SqlConnection(String.Format(CONN_STR_SERVER, this.Id, this.Password, this.DefaultDB, this.IP));
            }
        }

        public override void Close()
        {
            _connection.Close();
        }

        public override bool IsOpen()
        {
            if ((_connection == null) ||
                (_connection.State == System.Data.ConnectionState.Closed) ||
                (_connection.State == System.Data.ConnectionState.Broken)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    	
		public override DataSet ExecuteQuery(string queryKey, IMultiColumnRecordable data)
		{
        	List<SqlParameter> parameters = GetParamList(queryKey, data);
			SqlDataAdapter adapter = new SqlDataAdapter(QueryReader[queryKey], _connection);
			
			if (queryKey.ToLower().Contains("procedure") == true) 
			{
				adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			}
			string sss= "";
			foreach(SqlParameter para in parameters){
				adapter.SelectCommand.Parameters.Add(para);
				sss += "\r\n" + para.ParameterName + ":" + para.Value.ToString();
			}
			WriteLog(sss);

			_data = new DataSet();
			try{
				adapter.Fill(_data, queryKey);
			}
			catch(SqlException ex){
				WriteLog(_data.GetType().Name + " - " + queryKey + "\r\n" + ex.ToString());
			}
			
			return _data;
		}
    	
		public override int ExecuteNonQuery(string queryKey, IMultiColumnRecordable data)
		{
			int iRet = 0;
			List<SqlParameter> parameters = GetParamList(queryKey, data);
			SqlCommand cmd = new SqlCommand(QueryReader[queryKey], _connection);
			
			if (queryKey.ToLower().Contains("procedure") == true)
			{
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = QueryReader[queryKey];
			}
			
			foreach(SqlParameter para in parameters) {
				cmd.Parameters.Add(para);
			}
			
			try{cmd.Connection.Open();
			}catch(InvalidOperationException){}
			iRet = cmd.ExecuteNonQuery();
			
			foreach(string key in _dicOutParams.Keys.ToArray()){
				_dicOutParams[key] = cmd.Parameters[key].Value.ToString();
			}
			
			return iRet;
		}
    	
		public override DataSet ExecuteQuery(string queryKey, string param, string value)
		{
			SqlParameter para = new SqlParameter(param, value);
			SqlDataAdapter adapter = new SqlDataAdapter(QueryReader[queryKey], _connection);
			
			if (queryKey.ToLower().Contains("procedure") == true) 
			{
				adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			}
			
			adapter.SelectCommand.Parameters.Add(para);
			
			_data = new DataSet();
			adapter.Fill(_data, queryKey);
			
			return _data;
		}
    	
		public override int ExecuteNonQuery(string queryKey, string param, string value)
		{
			SqlParameter para = new SqlParameter(param, value);
			SqlCommand cmd = new SqlCommand(QueryReader[queryKey], _connection);
			
			if (queryKey.ToLower().Contains("procedure") == true)
			{
				cmd.CommandType = CommandType.StoredProcedure;
			}
			
			cmd.Parameters.Add(para);
			
			try{cmd.Connection.Open();
			}catch(InvalidOperationException){}
			return cmd.ExecuteNonQuery();
		}
    }
}
