/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-21
 * Time: 오후 1:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Xml;
using Theson.Util.Config;

namespace Theson.DBManager
{
	/// <summary>
	/// Description of QueryReader.
	/// </summary>
	public class XmlQueryReader: AbsConfigTable
    {
        private XmlNodeList xmlBaseData = null;
        private XmlDocument xmlDoc = null;
        private String _filePath = "";
        
        public XmlQueryReader(String dbType, String filePath)
        {
            xmlDoc = new XmlDocument();
            Load(filePath);
            GoToCategory(dbType); 
        }
        public XmlQueryReader(): this("mssql", "query.xml"){}
        
        public String GetQuery(String content)
        {
            return GetElementByAttribute("content", content).FirstChild.Value;
        }
        public XmlNode GetElementByAttribute(String attName, String attValue)
        {
            foreach (XmlNode node in xmlBaseData)
            {
                if (node.Attributes != null && node.Attributes[attName].Value == attValue)
                {
                    return node;
                }
            }
            return null;
        }

        public String MixQuery(String query, params object[] values)
        {
            return String.Format(query, values);
        }

        public StringBuilder MixQuery(StringBuilder sb, params object[] values)
        {
            return new StringBuilder(string.Format(sb.ToString(), values));
        }

        public StringBuilder GetAndMixQuery(String content, params object[] values)
        {
            String query = GetQuery(content);
            return new StringBuilder(String.Format(query, values));
        }
		
		public override void Load(string targetPath)
		{
			if((targetPath == null) ||
			   (targetPath == "")) targetPath = "\\query.xml";
			
			xmlDoc.Load(CheckFilePath(targetPath));
			
			_filePath = targetPath;
		}
		
		public override bool GoToCategory(string category)
		{
			XmlNodeList xList = xmlDoc.GetElementsByTagName("dbtype");
			String idStr = category;
			
			foreach(XmlNode node in xList){
                if(node.Attributes["name"].Value == idStr){
                    xmlBaseData = node.ChildNodes;
                    break;
                }
            }
            if (xmlBaseData == null)
            {
                throw new Exception("S/W 수행 경로에 " + this._filePath + "이 없거나 해당 파일의 내용이 잘 못 되었습니다.");
            }
            
            return true;
		}
		
		public override string this[string key] {
			get { return GetQuery(key); }
			set { return; }
		}
		public override string this[string category, string key] {
			get { return GetQuery(key); }
			set { return; }
		}
    }
}
