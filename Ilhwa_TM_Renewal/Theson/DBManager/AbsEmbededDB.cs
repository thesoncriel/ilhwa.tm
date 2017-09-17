using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theson.DBManager
{
    public abstract class AbsEmbededDB: AbsAccessibleDB
    {
        public String FilePath
        {
            get
            {
                return Config["FilePath"];
            }
            set
            {
                String sPath = CheckFilePath(value);
                Config["FilePath"] = sPath;
            }
        }

        protected String ExtractFileName(String filePath)
        {
        	String[] asTmp = filePath.Split('\\');

            return asTmp[asTmp.Length - 1];
        }
        

        public override string DBName
        {
            get
            {
                return base.DBName;
            }
            set
            {
                FilePath = value;
                base.DBName = ExtractFileName(value);
            }
        }

        public override bool DropDB(string dbName)
        {
        	try{
	            File.Delete(CheckFilePath(dbName));
	
	            if (dbName == DBName) DBName = "";
        	}
        	catch(IOException ex){
        		WriteLog(ex.ToString());
        		return false;
        	}
        	
        	return true;
        }

        public abstract String GetFileExt();
    }
}
