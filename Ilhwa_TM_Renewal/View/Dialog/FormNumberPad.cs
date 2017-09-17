/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오후 3:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Artn.Ilhwa.View.Dialog;

namespace Artn.Ilhwa.View.Common
{
	/// <summary>
	/// Description of FormNumberPad.
	/// </summary>
	public partial class FormNumberPad : Form
	{
		private bool _isFirst = true;
		public FormNumberPad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			textBox_Value.Text = "";
		}
		
		public string Value{
			get{
				int iValue = 0;
				if( Int32.TryParse(textBox_Value.Text, out iValue) == true){
					if (iValue < 0) {
						MsgBox.ShowDialog("입력 오류", "음수 값은 입력할 수 없습니다.");
						return null;
					}
				}
				return (textBox_Value.Text == "") ? "0" : textBox_Value.Text;
			}
			set{
				textBox_Value.Text = value;
			}
		}
		
		void ButtonClick(object sender, EventArgs e)
		{
			if (_isFirst == true){
				textBox_Value.Text = "";
				_isFirst = false;
			}
			textBox_Value.Text += (sender as Button).Text;
		}
		
		void Button_ClearClick(object sender, EventArgs e)
		{
			textBox_Value.Text = "";
		}
		
		void Button_BackSpaceClick(object sender, EventArgs e)
		{
			string sValue = textBox_Value.Text;
			int iLen = sValue.Length - 1;
			iLen = (iLen < 0)? 0: iLen;
			textBox_Value.Text = sValue.Substring(0, iLen);
		}
	}
}
