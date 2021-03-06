﻿/*
 * Created by SharpDevelop.
 * User: TheSON
 * Date: 2012-09-12
 * Time: 오후 8:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

using Artn.Ilhwa.Model;
using Theson.Common;

namespace Artn.Ilhwa.Controller
{
	/// <summary>
	/// Description of TaskProcessController.
	/// </summary>
	public class TaskProcessController: AbsViewController
	{
		public TaskProcessController()
		{
		}
		
		public override IMultiColumnRecordable CreateModel(DataRow row)
		{
			return CreateModel(null, row);
		}
		
		
		
		public IMultiColumnRecordable CreateModel(IMultiColumnRecordable parent, DataRow row){
			TaskProcess tp = new TaskProcess(ViewBinder.DBManager.MatchTable, parent, row);
			tp["NextProcCode"] = FindNextProcessCode(tp);
			return tp;
		}
		public IMultiColumnRecordable CreateModel(IMultiColumnRecordable parent, string procCode){
			TaskProcess tp = new TaskProcess(ViewBinder.DBManager.MatchTable, parent, procCode);;
			tp["NextProcCode"] = FindNextProcessCode(tp);
			return tp;
		}
		public IMultiColumnRecordable CreateModel(IMultiColumnRecordable parent, string procCode, bool isMiddleProc, bool isFirstProc, bool isLastProc){
			return InitProcInfo(CreateModel(parent, procCode), 
			                    isMiddleProc, isFirstProc, isLastProc);
		}
		public IMultiColumnRecordable CreateModel(IMultiColumnRecordable parent, DataRow row, bool isMiddleProc, bool isFirstProc, bool isLastProc){
			return InitProcInfo(CreateModel(parent, row), 
			                    isMiddleProc, isFirstProc, isLastProc);
		}
		
		public List<IMultiColumnRecordable> CreateModelList(IMultiColumnRecordable parent){
			if(parent == null) return null;
			
			int index = 0;
			List<IMultiColumnRecordable> viewDataList = new List<IMultiColumnRecordable>();
			IMultiColumnRecordable taskProc = null;
			List<string> sListProcessCode = FillOtherProcInfo(parent);
			int iMaxRowIndex = sListProcessCode.Count - 1;

			foreach(string procCode in sListProcessCode){
				taskProc = CreateModel(parent, procCode, 
				    IsMiddleProcess(sListProcessCode, procCode),
				    index == 0, index == iMaxRowIndex);
				viewDataList.Add(taskProc);
				ViewBinder.DBManager.ExecuteNonQuery(
					"table_insert add_task_process", taskProc);
				index++;
			}
			
			return viewDataList;
		}
		
		public List<IMultiColumnRecordable> CreateModelList(IMultiColumnRecordable parent, DataTable data){
			int index = 0;
			
			List<IMultiColumnRecordable> viewDataList = new List<IMultiColumnRecordable>();
			IMultiColumnRecordable[] arrViewData = new IMultiColumnRecordable[data.Rows.Count];
			List<string> sListProcessCode = FillOtherProcInfo(parent);
			int iMaxRowIndex = sListProcessCode.Count - 1;
			
			foreach(DataRow row in data.Rows){
				index = sListProcessCode.IndexOf(row["Proc_Code"].ToString());
				if (index == -1) continue;
				arrViewData[index] = CreateModel(parent, row, 
					IsMiddleProcess(sListProcessCode, row["Proc_Code"].ToString()), 
					index == 0, index == iMaxRowIndex);
			}
			
			viewDataList.AddRange(arrViewData);
			viewDataList.Remove(null);
			return viewDataList;
		}
		
		public List<string> ConvertToActuallyCodes(string procCodes){
			List<string> sList = new List<string>(procCodes.Split('|'));
			
			sList.Remove("");
			
			if (sList.Contains("1A") == true) {
				sList.Remove("1B");
				sList.Remove("1C");
				sList.Remove("1D");
				
				if (
					(sList.Contains("2E") == true) ){
					sList.Remove("1E");
				}
			}
			
			return sList;
		}
		
		public List<string> FillOtherProcInfo(IMultiColumnRecordable viewData){
			List<string> sListProcessCode = ConvertToActuallyCodes(viewData["ProcessSeq"]);
			bool bIsChainProc = IsChainProcess(sListProcessCode);
			
			viewData["IsChainProc"] = bIsChainProc.ToString().ToLower();
			viewData["MiddleProc"] = ExtractMiddleProcess(sListProcessCode);
			
			return sListProcessCode;
		}
		
		public bool IsMiddleProcess(List<string> procList, string targetProc){
			return ((procList.Contains("1A") == true) && (procList.Count > 2) && (procList.IndexOf(targetProc) == 2));
		}
		public bool IsMiddleProcess(string procCodes, string targetProc){
			return IsMiddleProcess(ConvertToActuallyCodes(procCodes), targetProc);
		}
		public bool IsChainProcess(string procCodes){
			return IsChainProcess(procCodes);
		}
		public bool IsChainProcess(List<string> procList){
			return (procList.Contains("1E") == true) &&
				(procList.Count > 2);
		}
		public string ExtractMiddleProcess(string procCodes){
			return ExtractMiddleProcess(ConvertToActuallyCodes(procCodes));
		}
		public string ExtractMiddleProcess(List<string> procList){
			if((procList.Count < 3) ||
			   (procList.Contains("1A") == false)) return "";
			
			return procList[1];
		}
		
		// 12차 수정 진행 - 공정 완료전 이전 공정의 작업 완료 여부 판별 추가 - 121019 by jhson
		public string FindPrevProcessCode(IMultiColumnRecordable procData){
			if (procData.Parent is TaskOrder){
				List<string> sListProc = ConvertToActuallyCodes(procData["ProcessSeq"]);
				string sPrevProc = "";
				
				foreach(string proc in sListProc){
					if (proc == procData["ProcessCode"]){
						return sPrevProc;
					}
					sPrevProc = proc;
				}
				
				return "";
			}
			else{
				throw new ArgumentException("인수가 잘 못 되었습니다.\r\n처리될 인수는 TaskOrder 타입의 부모를 가지고 있어야 합니다.\r\n위치: TaskProcessController.FindPrevProcess()");
			}
		}
		public string FindNextProcessCode(IMultiColumnRecordable procData){
			if (procData.Parent is TaskOrder){
				return FindNextProcessCode(ConvertToActuallyCodes(procData["ProcessSeq"]), procData["ProcessCode"]);
			}
			else{
				throw new ArgumentException("인수가 잘 못 되었습니다.\r\n처리될 인수는 TaskOrder 타입의 부모를 가지고 있어야 합니다.\r\n위치: TaskProcessController.FindNextProcess()");
			}
		}
		public string FindNextProcessCode(List<string> sListProc, string currentProcCode){
			bool bOK = false;
			
			foreach(string proc in sListProc){
				if (bOK == true){
					return proc;
				}
				if (proc == currentProcCode){
					bOK = true;
				}
			}
			
			return "";
		}
		// 12차 수정 진행 - 공정 완료전 이전 공정의 작업 완료 여부 판별 추가 - 121019 by jhson
		public bool IsPrevProcCompleted(IMultiColumnRecordable procData){
			string sPrevProc = FindPrevProcessCode(procData);
			string sPrevProcStatus = "";
			DataTable data = null;
			
			if (sPrevProc == null || sPrevProc == "") return true;
			
			procData["PrevProcessCode"] = sPrevProc;
			data = ViewBinder.DBManager.ExecuteQuery("table_select find_prev_process_completed", procData).Tables[0];
			sPrevProcStatus = data.Rows[0][0].ToString();
			
			return sPrevProcStatus == "E";
		}
		
		public IMultiColumnRecordable InitProcInfo(IMultiColumnRecordable taskProc, bool isMiddleProc, bool isFirstProc, bool isLastProc){
			taskProc["IsFirstProc"] = isFirstProc.ToString().ToLower();
			taskProc["IsMiddleProc"] = isMiddleProc.ToString().ToLower();
			taskProc["IsLastProc"] = isLastProc.ToString().ToLower();
			
			return taskProc;
		}
		
		public void StartProcess(IMultiColumnRecordable viewData){
			ViewBinder.DBManager.ExecuteNonQuery(
					"table_update task_process_start", viewData);
		}
		
	}
}
