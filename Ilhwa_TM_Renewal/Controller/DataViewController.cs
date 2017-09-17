/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-12
 * Time: 오후 8:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Artn.Ilhwa.Controller.Barcode;
using Theson.Common;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of DataViewController.
	/// </summary>
	public class DataViewController: DataViewBinder
	{
		private TaskOrderController _taskOrderCtrl = null;
		private TaskProcessController _taskProcessCtrl = null;
		private TaskRegistController _taskRegistCtrl = null;
		private BarcodeController _barcodeCtrl = null;
		private LogController _logCtrl = null;
		
		public event LogEventHandler LogMessage;
		protected void OnLogMessage(object sender, string msg){
			if(LogMessage != null) LogMessage(sender, msg);
		}
		
		public DataViewController(): base()
		{
			_taskOrderCtrl = new TaskOrderController();
			_taskOrderCtrl.ViewBinder = this;
			_taskOrderCtrl.LogMessage += OnLogMessage;
			
			_taskProcessCtrl = new TaskProcessController();
			_taskProcessCtrl.ViewBinder = this;
			_taskProcessCtrl.LogMessage += OnLogMessage;
			
			_taskRegistCtrl = new TaskRegistController();
			_taskRegistCtrl.ViewBinder = this;
			_taskRegistCtrl.LogMessage += OnLogMessage;
			
			_barcodeCtrl = new BarcodeController();
			_barcodeCtrl.ViewBinder = this;
			_barcodeCtrl.LogMessage += OnLogMessage;
			
			_logCtrl = new LogController();
		}
		
		public TaskOrderController TaskOrder{
			get{ return _taskOrderCtrl; }
		}
		public TaskProcessController TaskProcess{
			get{ return _taskProcessCtrl; }
		}
		public TaskRegistController TaskRegist{
			get{ return _taskRegistCtrl; }
		}
		public BarcodeController Barcode{
			get{ return _barcodeCtrl; }
		}
		public LogController Log{
			get{ return _logCtrl; }
		}
	}
}
