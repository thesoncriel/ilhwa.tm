/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-01
 * Time: 오전 10:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Theson.Common;
using Artn.Ilhwa.Controller;

namespace Artn.Ilhwa.View.Common
{
	/// <summary>
	/// Description of DataViewUserControl.
	/// </summary>
	public class DataViewUserControl : UserControl, IMultiColumnDataView
	{
		private IMultiColumnRecordable _viewData = null;
		
		public event LogEventHandler LogMessage;
		protected void OnLogMessage(object sender, string msg){
			if(LogMessage != null) LogMessage(sender, msg);
		}
		
		public event DataViewEventHandler ItemSelected = null;
		protected void OnItemSelected(object sender, IMultiColumnRecordable mcData){
			if (ItemSelected != null) ItemSelected(sender, mcData);
		}
		
		public event StringTransEventHandler ViewDataChange = null;
		protected void OnViewDataChange(object sender, string key, string value){
			if(ViewDataChange != null) ViewDataChange(sender, key, value);
		}
		
		public virtual IMultiColumnRecordable ViewData {
			get {
				return _viewData;
			}
			set {
				if (ParentForm == null) return;
				
				_viewData = value;
				ViewCtrl.BindingViewData(this, value);
			}
		}
		
		public DataViewController ViewCtrl{
			get{ 
				return (ParentForm as DataViewForm).ViewCtrl; 
			}
		}
		
		public void MemberClear()
		{
			_viewData = null;
		}
	}
}
