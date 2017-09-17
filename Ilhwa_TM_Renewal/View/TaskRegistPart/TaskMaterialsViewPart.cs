/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-08-26
 * Time: 오전 9:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Artn.Ilhwa.Model;
using Artn.Ilhwa.Controller.Barcode;
using Artn.Ilhwa.View.Common;
using Artn.Ilhwa.View.Dialog;
using Theson.Common;

namespace Artn.Ilhwa.View.TasRegistPart
{
	/// <summary>
	/// Description of InputMaterialsViewPart.
	/// </summary>
	public partial class TaskMaterialsViewPart : DataViewUserControl
	{
		public event EventHandler AddMaterialClick = null;
		protected void OnAddMaterialClick(object sender, EventArgs e){
			if (AddMaterialClick != null) AddMaterialClick(sender, e);
		}
		
		public event EventHandler RegistRemainingClick = null;
		protected void OnRegistRemainingClick(object sender, EventArgs e){
			if (RegistRemainingClick != null) RegistRemainingClick(sender, e);
		}
		
		public event EventHandler PrintProductClick = null;
		protected void OnPrintProductClick(object sender, EventArgs e){
			if (PrintProductClick != null) PrintProductClick(sender, e);
		}
		
		public event EventHandler PrintRemainingClick = null;
		protected void OnPrintRemainingClick(object sender, EventArgs e){
			if (PrintRemainingClick != null) PrintRemainingClick(sender, e);
		}
		
		public event EventHandler ChainInputClick = null;
		protected void OnChainInputClick(object sender, EventArgs e){
			if (ChainInputClick != null) ChainInputClick(sender, e);
		}
		
		public TaskMaterialsViewPart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

		}
		
		public override IMultiColumnRecordable ViewData {
			get { return base.ViewData; }
			set {
				if(value == null) return;
				
				bool isFirstProc = false;
				bool isLastProc = false;
				base.ViewData = value;
				MaterialRemaining = Double.Parse(value["Remaining"]);
				TransformType = (value["ProcessCode"] == "1A")? TaskType.MaterialSkelpInfo: TaskType.MaterialProdInfo;
				MaterialManage = (value["IsFirstProc"] == "true");
				
				inputStatusListViewPart.ViewData = value;
				
				isFirstProc = (value["IsFirstProc"] == "true");
				isLastProc = (value["IsLastProc"] == "true");
				
				findMaterialsViewPart.Visible = isFirstProc;
				button_AddMaterial.Visible = isFirstProc;
				button_RegistRemaining.Visible = isFirstProc;
				inputStatusListViewPart.Visible = isFirstProc;
				label_RemainingLabel.Visible = isFirstProc;
				label_Remaining.Visible = isFirstProc;
				
				button_PrintProduct.Visible = isLastProc;
				button_PrintRemain.Visible = isLastProc;
				barcodePrinterViewPart.ViewData = value;
				barcodePrinterViewPart.Visible = isLastProc;
			}
		}
		
		public int PrintProdQty{
			get{ return barcodePrinterViewPart.PrintProdQty; }
			set{ barcodePrinterViewPart.PrintProdQty = value; }
		}
		public int PrintRemainQty{
			get{ return barcodePrinterViewPart.PrintRemainQty; }
			set{ barcodePrinterViewPart.PrintRemainQty = value; }
		}
		
		public void SetInsertStatusListData(DataTable data){
			inputStatusListViewPart.SetData(data);
		}
		
		public double MaterialRemaining {
			get{
				try{
					return Double.Parse(ViewData["Remaining"]);
				}
				catch(Exception){
					return 0;
				}
			}
			set{
				if (TransformType == TaskType.MaterialSkelpInfo){
					label_Remaining.Text = value.ToString("0.0");
				}
				else{
					label_Remaining.Text = value.ToString("0");
				}
			}
		}
		
		public TaskType TransformType{
			get{
				return findMaterialsViewPart.TransformType;
			}
			set{
				if ((value == TaskType.MaterialSkelpInfo)) {
					label_RemainingLabel.Text = "예상 잔량 (kg)";
				}
				else{
					label_RemainingLabel.Text = "가용 잔량 (EA)";
				}
				
				findMaterialsViewPart.TransformType = value;
			}
		}
		
		public bool MaterialManage{
			get{
				return button_AddMaterial.Visible;
			}
			set{
				button_AddMaterial.Visible = value;
				button_RegistRemaining.Visible = value;
				findMaterialsViewPart.Visible = value;
			}
		}

		void Button_AddMaterialClick(object sender, EventArgs e)
		{
			OnAddMaterialClick(this, null);
		}
		
		void Button_RegistRemainingClick(object sender, EventArgs e)
		{
			ViewData["UIRemaining"] = label_Remaining.Text;// 사용가능한 무게 적용 (
			ViewData["TransformType"] = TransformType.ToString();
			OnRegistRemainingClick(this, null);
		}
		
		public IMultiColumnRecordable GetFoundMaterial(){
			IMultiColumnRecordable matData = findMaterialsViewPart.ViewData;
			if ((matData != null) && (ViewData.Childs.Contains(matData) == false)) ViewData.AddChild(matData);
			return matData;
		}
		// 12차 수정 진행 - 가장 최근에 투입된 자재를 이용하기에 삭제 - 121019 by jhson
//		public IMultiColumnRecordable GetSelectedMaterial(){
//			return inputStatusListViewPart.GetSelectedItem();
//		}		
//		public bool IsSelectedItem(){ return inputStatusListViewPart.IsSelectedItem(); }
		
		// 12차 수정 진행 - 가장 최근에 투입된 자재를 이용함 - 121019 by jhson
		public IMultiColumnRecordable GetLastInsertedItem(){
			return inputStatusListViewPart.GetLastInsertedItem();
		}
		
		public bool ContainsBarcode(string barcode){ return inputStatusListViewPart.ContainsBarcode(barcode); }
		public int GetItemCount(){ return inputStatusListViewPart.GetItemCount(); }
		public bool BarcodeVisible{
			get{
				return barcodePrinterViewPart.Visible;
			}
			set{
				barcodePrinterViewPart.Visible = value;
			}
		}
		
		void FindMaterialsViewPartCodeChanged(object sender, string key, string value)
		{
			findMaterialsViewPart.ViewData = ViewCtrl.TaskRegist.SearchMaterial(ViewData, key, value);
		}
		
		
		
		public void AddMaterialToInputList(IMultiColumnRecordable matData){
			inputStatusListViewPart.AddData(matData);
		}
		public bool HasContainsCodeAtList(IMultiColumnRecordable matData){
			return inputStatusListViewPart.HasContainsCode(matData);
		}
		public void ClearSearchKeyword(){ findMaterialsViewPart.Clear(); } // MOD: 자재 등록 시 검색 내역 Clear - jhson 120907
		
		void BarcodePrinterViewPartPrintClick(object sender, EventArgs e)
		{
			OnPrintProductClick(this, e);
		}
	}
}
