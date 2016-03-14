/**  版本信息模板在安装目录下，可自行修改。
* cardinfo.cs
*
* 功 能： N/A
* 类 名： cardinfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/3/13 19:39:35   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Model
{
	/// <summary>
	/// cardinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class cardinfo
	{
		public cardinfo()
		{}
		#region Model
		private string _cardid;
		private string _curtype="RMB";
		private string _savingtype;
		private DateTime  _opendate= DateTime.Now;
		private decimal _openmoney=0M;
		private decimal _balance=0M;
		private string _pass= "888888";
		private bool _isreportloss= false;
		private int _customerid;
		/// <summary>
		/// 
		/// </summary>
		public string cardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string curType
		{
			set{ _curtype=value;}
			get{return _curtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string savingType
		{
			set{ _savingtype=value;}
			get{return _savingtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime  openDate
		{
			set{ _opendate=value;}
			get{return _opendate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal openMoney
		{
			set{ _openmoney=value;}
			get{return _openmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pass
		{
			set{ _pass=value;}
			get{return _pass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsReportLoss
		{
			set{ _isreportloss=value;}
			get{return _isreportloss;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int customerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		#endregion Model

	}
}

