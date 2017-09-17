using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Collections;
using Theson.Common;
using Theson.Util.Config;

namespace Theson.Util.Common
{
    public abstract class AbsRegistryConfigTable: AbsConfigTable
    {
        public static String DEFAULT_REG_PATH = "Software\\AsTEK\\LOA\\";

        private String defaultRegistryPath;

        private Hashtable configTable;
        public Hashtable ConfigTable { get { return GetConfigTable(); } }

        #region IConfigTable 멤버

        public override string this[string key]
        {
            get { return configTable[key].ToString(); }
            set { throw new NotImplementedException(); }
        }

        public virtual void LoadAllConfig(){
        	
        }
        
        public virtual void LoadConfig(params String[] keys)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(defaultRegistryPath);
            foreach (String key in keys)
            {
                ConfigTable[key] = reg.GetValue(key, GetDefaultConfigValue(key));
            }
            reg.Close();
        }


        public virtual void SaveAllConfig()
        {
            IDictionaryEnumerator dicEnums = ConfigTable.GetEnumerator();
            List<String> keyList = new List<string>();

            while (dicEnums.MoveNext() == true)
            {
                keyList.Add(dicEnums.Current.ToString());
            }

            SaveConfig(keyList.ToArray());
        }
        public virtual void SaveConfig(params String[] keys)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(defaultRegistryPath);
            foreach (String key in keys)
            {
                reg.SetValue(key, ConfigTable[key]);
            }
            reg.Close();
        }

        public virtual Hashtable GetConfigTable() { return configTable; }

        public AbsRegistryConfigTable(String defaultRegistryPath)
        {
            this.defaultRegistryPath = defaultRegistryPath;
            configTable = new Hashtable();

            Load(defaultRegistryPath);
        }

        #endregion


        public override bool GoToCategory(String category)
        {
            throw new NotImplementedException();
        }

        public override void Load(string targetPath)
        {
            throw new NotImplementedException();
        }
    }
}
