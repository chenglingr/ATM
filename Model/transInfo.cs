/**  版本信息模板在安装目录下，可自行修改。
* transInfo.cs
*
* 功 能： N/A
* 类 名： transInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/3/13 19:39:36   N/A    初版
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
	/// transInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class transInfo
	{
		public transInfo()
		{}
		#region Model
		private DateTime _transdate= DateTime.Now;
		private string _cardid;
		private string _transtype;
		private decimal _transmoney;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public DateTime transDate
		{
			set{ _transdate=value;}
			get{return _transdate;}
		}
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
		public string transType
		{
			set{ _transtype=value;}
			get{return _transtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal transMoney
		{
			set{ _transmoney=value;}
			get{return _transmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

