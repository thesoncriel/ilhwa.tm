/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-01
 * Time: 오전 8:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Theson.Common;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of AbsTreeRecordable.
	/// </summary>
	public class TreeRecordable: ITreeData
	{
		private ITreeData _parent = null;
		private List<ITreeData> _childList = new List<ITreeData>();
		private Dictionary<String, String> _dicData = new Dictionary<String, String>();
		
		public TreeRecordable(){}
			
		protected Dictionary<String, String> Data{
			get{ return _dicData; }
		}
		
		public virtual string this[String attrName]
		{
			get {				
				if ((_dicData.ContainsKey(attrName) == false) &&
				    (Parent != null)) {
					return Parent[attrName];
				}
				return _dicData[attrName];
			}
			set {
				_dicData[attrName] = value;
			}
		}
		
		public bool ContainsKey(string key){
			bool bRet = _dicData.ContainsKey(key);
			
			if ((bRet == false) &&
			    (_parent != null)) {
				bRet = _parent.ContainsKey(key);
			}
			return bRet;
		}
		
		public virtual ITreeData Parent {
			get { return _parent; }
			set { 
				_parent = value; 
			}
		}
		
		public ITreeData FirstChild {
			get { return _childList[0]; }
		}
		
		public ITreeData LastChild {
			get { 
				int iLastIndex = _childList.Count - 1;
				
				if (iLastIndex < 0) return null;
				else return _childList[iLastIndex];
			}
		}
		
		public System.Collections.Generic.List<ITreeData> Childs {
			get { return _childList; }
		}
		
		public void AddChild(ITreeData treeRec)
		{
			treeRec.Parent = this;
			_childList.Add(treeRec);
		}
		
		public void InsertChild(int index, ITreeData treeRec)
		{
			treeRec.Parent = this;
			_childList.Insert(index, treeRec);
		}
		
		public void Clear()
		{
			for(int i = 0; i < _childList.Count; i++){
				_childList[i].MemberClear(); //모든 자식들을 끊어주고
			}
			_childList.Clear();
		}
		
		public void Remove(ITreeData treeRec)
		{
			treeRec.Parent = null;
			_childList.Remove(treeRec);
		}
		
		public virtual void MemberClear()
		{
			if(_parent != null){
				_parent.Remove(this); //부모에서 끊어주고..
			}
			Clear();
		}
	}
}
