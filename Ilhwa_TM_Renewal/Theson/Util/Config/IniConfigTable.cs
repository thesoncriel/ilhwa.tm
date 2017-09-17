/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-20
 * Time: 오후 10:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;

namespace Theson.Util.Config
{
	/// <summary>
	/// Description of IniConfigTable.
	/// </summary>
	public class IniConfigTable: AbsConfigTable
	{
		private ClsINI _ini = null;
		
		public IniConfigTable()
		{
			_ini = new ClsINI();
		}
		public IniConfigTable(string iniFilePath): this(){
			Load(iniFilePath);
		}
		
		public override string this[string section, string key] {
			get {
				return _ini.ReadString(section, key); 
			}
			set { 
				_ini.WriteString(section, key, value); 
			}
		}
		
		public override void Load(string targetPath)
		{
			_ini.FileName = targetPath;
		}
		
		public override bool GoToCategory(string category)
		{
			return true;
		}
	}
	
	class ClsINI
    {
        //  =======================================================================
        //  Private variables used in the class
        private string mFileName = "";
        private DataSet mDs;
        //  korea or English
        private CultureInfo ci;

        //  =======================================================================
        //  Constructors
        public ClsINI()
        {
            // Nothing here
        }

        public ClsINI(string iniFileName)
        {
            //  Open the IniFile
            FileName = iniFileName;
        }

        //  =======================================================================
        //  Properties
        public string FileName
        {
            get
            {
                //  Return Filename
                return mFileName;
            }
            set
            {
                //  Check if File is allready open
                if (value.Trim() != mFileName)
                {
                    //  If not, open it
                    mFileName = value;
                    LoadIniToDataSet();
                }
            }
        }

        public DataSet DataSet
        {
            get
            {
                //  Return Dataset
                return mDs;
            }
        }

        //  =======================================================================
        //  Methodes
        public string ReadString(string section, string key)
        {
            //  Function ReadString Number 1
            //  Read string from INI Dataset
            //  Use function number 2
            //  Use an empty string as defaultvalue
            return this.ReadString(section, key, "");
        }

        public string ReadString(string section, string key, string defaultValue)
        {
            //  Function ReadString Number 2
            //  Read string from INI Dataset
            return Read(section, key, defaultValue);
        }

        public string ReadString(string section, string key, string defaultValue, string iniFileName)
        {
            //  Function ReadString Number 3
            //  Open the IniFile
            FileName = iniFileName;
            //  Read string from INI Dataset
            //  Use function number 2
            return this.ReadString(section, key, defaultValue);
        }

        public int ReadInteger(string section, string key)
        {
            //  Function ReadInteger Number 1
            //  Store return value
            //  Use function number 2
            //  Use 0 as defaultvalue
            return this.ReadInteger(section, key, 0);
        }

        public int ReadInteger(string section, string key, int defaultValue)
        {
            //  Function ReadInteger Number 2
            //  Store return value
            int ret;
            string tmpRet;
            //  Read string from INI Dataset
            //  First convert DefaultValue to a string to use the Common Read function
            tmpRet = Read(section, key, Convert.ToString(defaultValue));
            try
            {
                //  Convert the Value to an Integer
                ret = Convert.ToInt32(tmpRet);
            }
            catch 
            {
                ret = 0;
            }
            return ret;
        }

        public int ReadInteger(string section, string key, int defaultValue, string iniFileName)
        {
            //  Function ReadInteger Number 3
            //  Open the IniFile
            FileName = iniFileName;
            //  Use ReadInteger function number 2
            return this.ReadInteger(section, key, defaultValue);
        }

        public ArrayList SectionNames()
        {
            //  Store return value in an arraylist
            ArrayList ret = new ArrayList();
            //DataTable table;
            //  Loop through all the Tables
            foreach (DataTable table in mDs.Tables)
            {
                //  Add tablename to the ArrayList
                ret.Add(table.TableName);
            }
            return ret;
        }

        public void WriteString(string section, string key, string value)
        {
            //  Function WriteString Number 1
            //  Store data in dataset
            Write(section, key, value);
            //  Write dataset back to disk
            DumpDatasetToIni();
        }

        public void WriteString(string section, string key, string value, string iniFileName)
        {
            //  Function WriteString Number 2
            //  Open the IniFile
            FileName = iniFileName;
            //  Use WriteString function number 1
            this.WriteString(section, key, value);
        }

        public void WriteInteger(string section, string key, int value)
        {
            //  Function WriteInteger Number 1
            //  First convert Value to a string to use the WriteString function number 1
            this.WriteString(section, key, Convert.ToString(value));
        }

        public void WriteInteger(string section, string key, int value, string iniFileName)
        {
            //  Function WriteInteger Number 2
            //  First convert Value to a string to use the WriteString function number 2
            this.WriteString(section, key, Convert.ToString(value), iniFileName);
        }

        public void DeleteSection(string section)
        {
            //  Function DeleteSection Number 1
            //  Delete 'Section' Table from Dataset
            //  First check if section exists
            if (!(mDs.Tables[section] == null))
            {
                //  Section is found, so kill it
                mDs.Tables.Remove(section);
                //  Write dataset back to disk
                DumpDatasetToIni();
            }
        }

        public void DeleteSection(string section, string iniFileName)
        {
            //  Function DeleteSection Number 2
            //  Open the IniFile
            FileName = iniFileName;
            //  Use DeleteSection function number 1
            this.DeleteSection(section);
        }

        //  =======================================================================
        //  Private Section

        private string Read(string section, string key, string defaultValue)
        {
            //  Store return value
            string ret = "";
            try
            {
                //  Section = TableName
                //  Key = ColumnName
                //  Row = 0, because there is only one row for each table
                //  Get the value from the dataset
                ret = mDs.Tables[section].Rows[0][key].ToString();
            }
            catch
            {
                ret = defaultValue;
            }
            return ret;
        }

        private void Write(string section, string key, string value)
        {
            //  Section = Table
            //  Key = Column
            //  Row = 0, because there is only one row for each table
            //  Look for section in Dataset
            if ((mDs.Tables[section] == null))
            {
                //  Section is not found
                //  Add section to the dataset
                mDs.Tables.Add(section);
                //  Add Key to Section
                mDs.Tables[section].Columns.Add(key);
                //  We must add a new row to the dataset
                DataRow row;
                row = mDs.Tables[section].NewRow();
                //  Add Value to Key
                row[key] = value;
                mDs.Tables[section].Rows.Add(row);
            }
            else
            {
                //  Section was found, now look for key in section
                if ((mDs.Tables[section].Columns[key] == null))
                {
                    //  Key is not found
                    //  Add key to the section
                    mDs.Tables[section].Columns.Add(key);
                }
                //  Update Value for key
                mDs.Tables[section].Rows[0][key] = value;
            }
        }

        private void LoadIniToDataSet()
        {
            //  Initialise Dataset
            mDs = new DataSet();
            //  Open the File
            FileInfo file = new FileInfo(mFileName);
            //  Create DatasetName from IniFileName by removing the file extention
            mDs.DataSetName = file.Name.Remove(file.Name.IndexOf(file.Extension), file.Extension.Length);
            //  Check if inifile exists on specified path
            if (file.Exists)
            {
                //  Store each Section as a Table in the Dataset
                DataTable table = null;
                //  Define row to fill with KeyValue
                DataRow row = null;
                //  A switch to keep track when we have add the row to the table
                bool addRow = false;
                bool skipSection = false;
                StreamReader fileStream = new StreamReader(mFileName, Encoding.Default);
                string readLine;
                //  Read the first line
                readLine = fileStream.ReadLine();
                //  Loop to the end of the File
                while (!(readLine == null))
                {
                    readLine = readLine.Trim();
                    //  Skip empty lines and commented lines
                    if (((readLine != "")
                                && !readLine.StartsWith(";")))
                    {
                        //  Check if the line is a Section Header
                        if ((readLine.StartsWith("[") && readLine.EndsWith("]")))
                        {
                            //  A new Section means a new Table
                            //  Before we create a new table
                            //  add all the values to the previous created table
                            if (addRow)
                            {
                                table.Rows.Add(row);
                            }
                            //  remove brackets from readline
                            readLine = readLine.TrimStart('[');
                            readLine = readLine.TrimEnd(']');
                            //  Tablename is SectionName
                            //  Check if table allready exists
                            //  If so, skip the rest of the section
                            //  An iniFile can't have double sections
                            //  First set it to True, will be corrected a few lines below
                            skipSection = true;
                            table = mDs.Tables[readLine];
                            if ((table == null))
                            {
                                //  If not, Create new table
                                table = new DataTable(readLine);
                                //  Add Table to Dataset
                                mDs.Tables.Add(table);
                                //  Adds a new row to the table
                                row = table.NewRow();
                                skipSection = false;
                            }
                            //  Clear switch
                            addRow = false;
                        }
                        else if (!skipSection)
                        {
                            //  Use a string array to store data
                            string[] splitLine;
                            //  Split the line by a =
                            //  SplitDate(0) holds the Key
                            //  SplitDate(1) holds the KeyValue
                            splitLine = readLine.Split('=');
                            //  Columnname is Key
                            //  Check if Key allready exists
                            //  if so Skip it, a section can't have double keys
                            if ((table.Columns[splitLine[0]] == null))
                            {
                                //  Add Key as a new column to the table
                                table.Columns.Add(splitLine[0]);
                                //  Check if line is splitted ok
                                if ((splitLine.Length == 2))
                                {
                                    //  Fill Key-column with KeyValue 
                                    row[splitLine[0]] = splitLine[1];
                                }
                                else
                                {
                                    //  Fill Key-column with empty string 
                                    row[splitLine[0]] = "";
                                }
                                //  Set switch for adding row
                                addRow = true;
                            }
                        }
                    }
                    //  Read next Line
                    readLine = fileStream.ReadLine();
                }
                //  Don't forget the last entries
                if (addRow)
                {
                    table.Rows.Add(row);
                }
                //  Close file
                fileStream.Close();
            }
        }

        private void DumpDatasetToIni()
        {
            // Dim En As System.Text.Encoding
            // Dim Kr As System.Text.Encoding
            // Kr = En.GetEncoding(949) 'VS2003   영문버전OS에서는 437, 한글버전OS 에서는 949
            //  Check if inifile exists on specified path
            if (File.Exists(mFileName))
            {
                //  if, so....delete it
                File.Delete(mFileName);
            }
            //  Use a StreamWriter to make a new inifile
            // Dim file As IO.StreamWriter = IO.File.CreateText(mFileName)
            FileStream Stream = new FileStream(mFileName, FileMode.Create);
            // Dim file As New System.IO.StreamWriter(Stream, Kr)
            ci = new CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);
            int mEnc = 0;
            if (ci.Name.ToLower() == "ko-kr") { mEnc = 949; } else { mEnc = 936; }
            StreamWriter file = new StreamWriter(Stream, Encoding.GetEncoding(mEnc)); //  <-- 여기를 바꿔야함 영문버전OS에서는 437, 한글버전OS 에서는 949
            //  Section = TableName
            //  Key = ColumnName
            //  Row = 0, because there is only one row for each table
            //DataTable table;
            //DataColumn col;
            string value;
            //  Loop through all sections
            foreach (DataTable table in mDs.Tables)
            {
                //  Write section name
                file.WriteLine(("[" + (table.TableName + "]")));
                //  Loop through all key's in section
                foreach (DataColumn col in table.Columns)
                {
                    //  Find value for key
                    value = table.Rows[0][col].ToString();
                    //  Write Key and Value
                    file.WriteLine((col.ColumnName + ("=" + value)));
                }
                //  Make an empty line between the sections
                file.WriteLine("");
            }
            //  Close IniFile
            file.Close();
        }
    }
}
