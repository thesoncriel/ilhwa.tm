/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-06
 * Time: 오전 4:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Artn.Ilhwa.View.Dialog
{
	/// <summary>
	/// Description of FormProgressBar.
	/// </summary>
	public partial class FormProgressBar : Form
	{
		public FormProgressBar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public string Title{
			get{
				return this.Text;
			}
			set{
				this.Text = value;
			}
		}
		
		public string Content{
			get{
				return label_Content.Text;
			}
			set{
				label_Content.Text = value;
			}
		}
		
		public int Progress{
			get{
				return progressBar.Value;
			}
			set{
				progressBar.Value = value;
			}
		}
	}
}
