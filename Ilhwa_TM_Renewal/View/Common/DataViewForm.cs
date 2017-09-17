/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-01
 * Time: 오전 10:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.Controller;
using Theson.Common;

namespace Artn.Ilhwa.View.Common
{
	/// <summary>
	/// Description of FormDataView.
	/// </summary>
	public class DataViewForm : Form, IMultiColumnDataView, IMemberClearable
	{
		private IMultiColumnRecordable _viewData = null;
		private DataViewController _viewCtrl = null;
		
		public event LogEventHandler LogMessage;
		protected void OnLogMessage(object sender, string msg){
			if(LogMessage != null) LogMessage(sender, msg);
		}
		
		public virtual IMultiColumnRecordable ViewData {
			get {
				return _viewData;
			}
			set {
				_viewData = value;
				if(value == null) return;
				ViewCtrl.BindingViewData(this, value);
			}
		}
		
		public virtual DataViewController ViewCtrl{
			get{ return _viewCtrl; }
			set{ _viewCtrl = value; }
		}
		
		public void MemberClear()
		{
			_viewCtrl = null;
			_viewData = null;
		}
	}
}
