/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-12
 * Time: 오후 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of RemainingController.
	/// </summary>
	public class RemainingController: AbsViewController
	{
		public RemainingController()
		{
		}
		
		public int GetRemaining(string orderNo){
			return 0;
		}
		
		
		public override Theson.Common.IMultiColumnRecordable CreateModel(System.Data.DataRow row)
		{
			throw new NotImplementedException();
		}
	}
}
