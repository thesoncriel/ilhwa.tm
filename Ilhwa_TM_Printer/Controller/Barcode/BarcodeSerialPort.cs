/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-31
 * Time: 오후 4:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO.Ports;
using System.Text;
using Theson.Common;
using Theson.Util;

namespace Artn.Ilhwa.Controller.Barcode
{
	/// <summary>
	/// Description of ConfigSerialPort.
	/// </summary>
	public class BarcodeSerialPort: TextLogger, IOpenable, IMemberClearable
	{
		private SerialPort _port = new SerialPort();
		private IConfigTable _config = null;
		
		public BarcodeSerialPort(IConfigTable config)
		{
			Config = config;
		}
		
		protected SerialPort ComPort{
			get{ return _port; }
		}
		
		public IConfigTable Config{
			get{ return _config; }
			set{
				if(value == null) return;
				
				_config = value;
			}
		}
		
		public void Open()
		{
			if(_port.IsOpen == true) _port.Close();
			
			_port.PortName = "COM" + Config["Barcode Printer", "ComNumber"];
			_port.BaudRate = Int32.Parse(Config["Barcode Printer", "BaudRate"]);
			_port.Parity = (Parity)Parity.Parse(typeof(Parity), Config["Barcode Printer", "Parity"]);
			_port.DataBits = Int32.Parse(Config["Barcode Printer", "DataBits"]);
			_port.StopBits = (StopBits)StopBits.Parse(typeof(StopBits), Config["Barcode Printer", "StopBits"]);
			
			_port.Open();
		}
		
		public void Close()
		{
			_port.Close();
		}
		
		public bool IsOpen()
		{
			return _port.IsOpen;
		}
		
		public virtual void Write(string data){
			if(IsOpen() == false) Open();
			
			byte[] byTemp = Encoding.Default.GetBytes(data);
            Encoding.Default.GetString(byTemp, 0, byTemp.Length);
            _port.Write(byTemp, 0, byTemp.Length);
            //_port.WriteLine(data);
		}
		
		public virtual void MemberClear()
		{
			try{
				_port.Close();
			}
			catch(Exception){}
			
			_port = null;
			_config = null;
		}
	}
}
