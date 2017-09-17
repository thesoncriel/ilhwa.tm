using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace Theson.Common
{
    public interface IDBManager: IOpenable
    {
        String DBName { get; set; }
        IConfigTable Config { get; set; }
        IConfigTable QueryReader { get; }
        IConfigDataSet MatchTable { get; set; }

        List<String> GetTableNames();
        List<String> GetColumnNames(String tableName);

        List<String> ReadTableNames();
        Dictionary<String, List<String>> ReadColumnNames(String[] tableNames);
        DataSet ExecuteQuery(String query);
        int ExecuteNonQuery(String query);
        bool Backup(String bakPath);
        bool Restore(String bakPath, String restoreName);
        bool CreateDB(String dbName);
        bool DropDB(String dbName);
        String GetDbmsName();
        
 		List<SqlParameter> GetParamList(string queryKey, IMultiColumnRecordable data);       
        DataSet ExecuteQuery(string queryKey, IMultiColumnRecordable data);
		int ExecuteNonQuery(string queryKey, IMultiColumnRecordable data);
		DataSet ExecuteQuery(string queryKey, string param, string value);
		int ExecuteNonQuery(string queryKey, string param, string value);
		
		string GetOutputParamValue(string key);
    }

    public interface IOpenable
    {
        void Open();
        void Close();
        bool IsOpen();
    }

    public interface IConfigTable
    {
        void Load(String targetPath);
        String GetDefaultConfigValue(String key);
        void SetDefaultConfigValue(String key, String value);
        void SetDefaultConfigValue(Dictionary<String, String> defDataMap);
        bool GoToCategory(String category);
        void GoToSection(String section);

        String this[String section, String key]
        {
            get;
            set;
        }
        String this[String key]{
        	get;
        	set;
        }
        
        bool ReadBool(String key);
        String ReadStr(String key);
        int ReadInt(String key);
        double ReadDbl(String key);
    }
    
    public interface IConfigDataSet: IConfigTable{
    	void GoToTable(string tableName);
    	int RowCount{get;}
    	
    	string this[int row, string col]{
    		get;
    		set;
    	}
    }

    public interface IMultiColumnRecordable: ITreeData
	{
		void SetData(IConfigDataSet matchTable, DataRow data);
		void SetData(IConfigDataSet matchTable, params String[] data);
		
		void Update(IDBManager dbm);
		void Insert(IDBManager dbm);

		List<string> GetKeyList();
	}
	
	public interface IMergeRecordable: IMultiColumnRecordable, IMemberClearable{
		IMultiColumnRecordable GetSubRecord(String subName);
		void Merge(IConfigDataSet matchTable, params IMultiColumnRecordable[] data);
	}
    
    public interface ITreeData{
    	string this[String attrName]{get;set;}
    	bool ContainsKey(string key);
    	
    	ITreeData Parent{get; set;}
    	ITreeData FirstChild{get;}
    	ITreeData LastChild{get;}
    	List<ITreeData> Childs{get;}
    	void AddChild(ITreeData treeRec);
    	void InsertChild(int index, ITreeData treeRec);
    	void Clear();
    	void Remove(ITreeData treeRec);
    }
    
    public interface IMemberClearable{
		void MemberClear();
	}
}
