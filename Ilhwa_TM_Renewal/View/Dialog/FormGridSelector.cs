/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-24
 * Time: 오후 4:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Theson.Common;

namespace Artn.Ilhwa.View.Common
{
	/// <summary>
	/// Description of FormGridSelector.
	/// </summary>
	public partial class FormGridSelector : Form, IMemberClearable
	{
		private Dictionary<string, string> _dicData = new Dictionary<string, string>();
		private Dictionary<string, int> _dicCount = new Dictionary<string, int>();
		private string _singleData = "";
		
		public FormGridSelector()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			textBox_SelectInfo.Text = "";
			gridSelectorView.OnItemSelected += GridItemSelected;
			WeightMode = false;
		}
		public FormGridSelector(bool keyValuePairMode): this(){
			gridSelectorView.KeyValuePair = keyValuePairMode;
			//textBox_Length.Visible = keyValuePairMode;
			//button_NumPad.Visible = keyValuePairMode;
			//label_Weight.Visible = keyValuePairMode;
		}
		
		public bool WeightMode{
			get{
				return textBox_Weight.Visible;
			}
			set{
				textBox_Weight.Visible = value;
				label_Weight.Visible = value;
			}
		}
		
		public Dictionary<string, int> GetSelectData(){
			return _dicCount;
		}
		
		public string GetSelectSingleData(){
			return _singleData;
		}
		
		public string GetSelectValueData(){
			return textBox_SelectInfo.Text;
		}
		
		public string GetLengthData(){
			return textBox_Length.Text;
		}
		
		public void SetData(DataRow[] data){
			gridSelectorView.SetData(data);
		}
		
		void Button_MovePrevClick(object sender, EventArgs e)
		{
			gridSelectorView.MovePrev();
		}
		
		void Button_MoveNextClick(object sender, EventArgs e)
		{
			gridSelectorView.MoveNext();
		}
		
		void GridItemSelected(object sender, string key, string value){
			textBox_SelectInfo.Text = "";
			
			if (gridSelectorView.KeyValuePair == true){
				_dicData[key] = value;
				if (_dicCount.ContainsKey(key) == true){
					_dicCount[key] += 1;
				}
				else{
					_dicCount[key] = 1;
				}

				foreach(KeyValuePair<string, string> keyVal in _dicData){
					textBox_SelectInfo.Text += keyVal.Value + "\tx " + _dicCount[keyVal.Key] + "\r\n";
				}
			}
			else{
				_singleData = key;
				textBox_SelectInfo.Text = value;
			}
		}
		
		public double GetWeight(){
			return Double.Parse(textBox_Weight.Text);
		}
		
		public void MemberClear()
		{
			gridSelectorView.MemberClear();
		}
		
		void Button_NumPadClick(object sender, EventArgs e)
		{
			FormNumberPad numPad = new FormNumberPad();
			
			if(numPad.ShowDialog() == DialogResult.OK){
				textBox_Weight.Text = numPad.Value;
				this.DialogResult = DialogResult.None;
			}
		}
		
		void TextBox_CodeClick(object sender, EventArgs e)
		{
			textBox_Length.SelectAll();
		}
		
		void Button_MovePrev10Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 10; i++){
				gridSelectorView.MovePrev();
			}
		}
		
		void Button_MoveNext10Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 10; i++){
				gridSelectorView.MoveNext();
			}
		}
	}
}
