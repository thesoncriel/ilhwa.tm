/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-08-21
 * Time: 오후 12:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Theson.Common;

namespace Artn.Ilhwa.Model
{
	/// <summary>
	/// Description of MaterialsInfo.
	/// </summary>
	public class MaterialSkelpInfo: AbsMatchTableRecordData
	{
		public MaterialSkelpInfo(IConfigDataSet matchTable, DataRow data): base(matchTable, data){}
		
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
				if(value == null) return;

				this["ExpectQuantity"] = GetExpectQuantity(
					this, Double.Parse(this["Weight"])
				).ToString();
			}
		}
		public static int GetExpectQuantity(IMultiColumnRecordable matSkelp, double weight){
			if (matSkelp["OuterDiameter1"] == ""){
				matSkelp["OuterDiameter1"] = matSkelp["OuterDiameter2"];
			}
			
			return GetExpectQuantity(
				Double.Parse(matSkelp["OuterDiameter1"]),
				Double.Parse(matSkelp["Thickness1"]),
				Double.Parse(matSkelp["PlanLength"]),
				weight);
		}
		
		public static int GetExpectQuantity(double outerDiameter,
		                            double thickness,
		                            double length,
		                            double weight){
			/*
			※ p_PlanQty2 = (무게 * 1000 )/ 임시개수
			※ 임시개수 = (외경(ODValue) - 두께) * 두께 * 0.02491 * 제품길이
			*/
			return (int)Math.Round((weight * 1000) / 
			                       ((outerDiameter - thickness) * thickness * 0.02491 * length));
		}
		
		public static double GetRemainingWeight(double outerDiameter, 
		                                     double thickness, 
		                                     double length,
		                                     double quantity){
			return (quantity * ( (outerDiameter - thickness) * thickness * 0.02491 * length )) / 1000;
		}
		public static double GetRemainingWeight(IMultiColumnRecordable matSkelp, double quantity){
			if (matSkelp["OuterDiameter1"] == "") matSkelp["OuterDiameter1"] = matSkelp["OuterDiameter2"];
			if (matSkelp["Thickness1"] == "") matSkelp["Thickness1"] = matSkelp["Thickness2"];
			
			return GetRemainingWeight(
				Double.Parse(matSkelp["OuterDiameter1"]),
				Double.Parse(matSkelp["Thickness1"]),
				Double.Parse(matSkelp["PlanLength"]),
				quantity);
		}
//		
//		public static double GetLengthByWeight(double outerDiameter,
//		                            double thickness,
//		                            double quantity,
//		                            double weight){
//			return ((weight * 1000) / 
//			                       ((outerDiameter - thickness) * thickness * 0.02491 * quantity));
//		}
//		public static double GetLengthByWeight(IMultiColumnRecordable data){
//			return GetLengthByWeight(
//				data["PlanODValue"],
//				data["PlanThickness"],
//				data["
//		}
		
		public static SpecCheckType IsEqualSpec(IMultiColumnRecordable taskProc, IMultiColumnRecordable matProd){
//			if (taskProc["ProdName1"] == "") taskProc["ProdName1"] = taskProc["ProdName2"];
//			if (taskProc["Thickness1"] == "") taskProc["Thickness1"] = taskProc["Thickness2"];
//			if (taskProc["OuterDiameter1"] == "") taskProc["OuterDiameter1"] = taskProc["OuterDiameter2"];
			
			if (taskProc["Qual"] != matProd["Qual"]) 				return SpecCheckType.Quality;
			if (taskProc["PlanThickness"] != matProd["Thickness"]) 		return SpecCheckType.Thickness;
			if(taskProc["PlanODValue"] != matProd["OuterDiameter"]) 	return SpecCheckType.OuterDiameter;
			return SpecCheckType.OK;
		}
	}
}
