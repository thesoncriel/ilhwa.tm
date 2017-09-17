/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-02
 * Time: 오전 9:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Artn.Ilhwa.View.Dialog
{
	/// <summary>
	/// Description of MsgBox.
	/// </summary>
	public partial class MsgBox : Form
	{
		public MsgBox()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public MsgBox SetDisplayContents(string title, string msg){
			label_Title.Text = title;
			label_Msg.Text = msg;
			return this;
		}
		
		public static void Show(string title, string msg){
			new MsgBox().SetDisplayContents(title, msg).ShowDialog();
		}
		
		public static DialogResult ShowDialog(string title, string msg){
			return new MsgBox().SetDisplayContents(title, msg).ShowDialog();
		}
	}
}
