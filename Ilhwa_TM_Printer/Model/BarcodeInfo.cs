/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-21
 * Time: 오후 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Theson.Common;
using Artn.Ilhwa.Model;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of BarcodeInfo.
	/// </summary>
	public class BarcodeInfo: AbsMatchTableRecordData
	{
		public BarcodeInfo(IMultiColumnRecordable parent){ parent.AddChild(this); }
		public BarcodeInfo(){}
		
		public override string[] GetUpdateQueryKeys()
		{
			throw new NotImplementedException();
		}
		
		public override string[] GetInsertQueryKeys()
		{
			throw new NotImplementedException();
		}
		
		
	}
}
