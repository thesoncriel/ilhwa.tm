/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-09-05
 * Time: 오후 4:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;

namespace Artn.Ilhwa.View.TasRegistPart
{
	/// <summary>
	/// Description of PrintBarcode.
	/// </summary>
	public partial class BarcodePrinterViewPart : DataViewUserControl
	{
		public BarcodePrinterViewPart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			label_PrintProdQty.Text = "0";
			label_PrintRemainQty.Text = "0";
		}
		
		public int PrintProdQty{
			get{
				return Int32.Parse(label_PrintProdQty.Text);
			}
			set{
				label_PrintProdQty.Text = value.ToString();
			}
		}
		
		public int PrintRemainQty{
			get{
				return Int32.Parse(label_PrintRemainQty.Text);
			}
			set{
				label_PrintRemainQty.Text = value.ToString();
			}
		}
	}
}
