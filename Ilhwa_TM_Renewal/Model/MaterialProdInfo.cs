/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-21
 * Time: 오후 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Theson.Common;

namespace Artn.Ilhwa.Model
{
	public enum SpecCheckType{
		OuterDiameter,
		Thickness,
		Quality,
		OK
	}
	
	/// <summary>
	/// Description of MaterialProdInfo.
	/// </summary>
	public class MaterialProdInfo: AbsMatchTableRecordData
	{
		public MaterialProdInfo(IConfigDataSet matchTable, DataRow data): base(matchTable, data){}
		public MaterialProdInfo(IMultiColumnRecordable parent){ parent.AddChild(this); }
		
		public override string[] GetUpdateQueryKeys()
		{
			throw new NotImplementedException();
		}
		
		public override string[] GetInsertQueryKeys()
		{
			throw new NotImplementedException();
		}
		
		public override ITreeData Parent {
			get { return base.Parent; }
			set { 
				base.Parent = value; 
				if (value == null) return;
				
//				this["ExpectQuantity"] = GetExpectQuantity(
//				Double.Parse(this["Quantity"]),
//				Double.Parse(this["OrderLength2"]),
//				Double.Parse(this["Length"])).ToString();
			}
		}
		
		public static int GetExpectQuantity(double quantity,
		                            double prodLength,
		                            double orderLength
		                            ){
			/*
			※ 제품 예상 수량 = 제품 개수 * (제품 길이 / 지시 길이)
			*/
			return (int)Math.Round(quantity * (prodLength / orderLength));
		}
		
		public static int GetRemainingQuantity(double quantity, IMultiColumnRecordable viewData){
			return GetExpectQuantity(
				quantity,
			    Double.Parse(viewData["OrderLength2"]),
				Double.Parse(viewData["Length"]));
		}
		
		public static SpecCheckType IsEqualSpec(IMultiColumnRecordable taskProc, IMultiColumnRecordable matProd){
			if (taskProc["Thickness2"] != matProd["Thickness"]) 		return SpecCheckType.Thickness;
			if(taskProc["PlanQuality"] != matProd["ProdQuality"]) 	return SpecCheckType.Quality;
			return SpecCheckType.OK;
		}
	}
}