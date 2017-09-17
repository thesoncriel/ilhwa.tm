using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Theson.Common;

namespace Theson.Util.Config
{
    public abstract class AbsConfigTable: IConfigTable
    {
        private Dictionary<String, String> _configMap = new Dictionary<string,string>();
        protected Dictionary<String, String> ConfigMap { get { return _configMap; } }
        private Dictionary<String, String> _defaultMap = new Dictionary<String, String>();
        protected Dictionary<String, String> DefaultMap { get { return _defaultMap; } }
        
        private TextLogger _txtLogger = null;
        protected string _section = "";

        protected void WriteLog(String msg){ _txtLogger.WriteLog(msg); }
        protected String CheckFilePath(String filePath){ return _txtLogger.CheckFilePath(filePath); }
        
        public AbsConfigTable(){
        	_txtLogger = new TextLogger("\\err_config.log");
        }
        
        #region IConfigTable 멤버

        public abstract void Load(string targetPath);

        public abstract bool GoToCategory(string category);

        public virtual string this[string section, string key]
        {
            get { return _configMap[key]; }
            set { _configMap[key] = value; }
        }
        public virtual string this[string key]{
        	get { return this[_section, key]; }
        	set { this[_section, key] = value; }
        }
        
        public virtual void GoToSection(string section)
		{
			_section = section;
		}

        public bool ReadBool(string key)
        {
            return Convert.ToBoolean(this[key]);
        }

        public string ReadStr(string key)
        {
            return this[key];
        }

        public int ReadInt(string key)
        {
            return Int32.Parse(this[key]);
        }

        public double ReadDbl(string key)
        {
        	return Double.Parse(this[key]);
        }

        public string GetDefaultConfigValue(string key)
        {
        	return DefaultMap[key];
        }
    	
		public void SetDefaultConfigValue(string key, string value)
		{
			DefaultMap[key] = value;
		}
    	
		public void SetDefaultConfigValue(Dictionary<string, string> defDataMap)
		{
			_defaultMap = defDataMap;
		}
		
		#endregion
		
    	
		
    }
}
