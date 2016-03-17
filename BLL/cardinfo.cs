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
using System.Data;
using System.Collections.Generic;

using Model;
namespace BLL
{
	/// <summary>
	/// cardinfo
	/// </summary>
	public partial class cardinfo
	{
		private readonly DAL.cardinfo dal=new DAL.cardinfo();
		public cardinfo()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string cardID,string pwd)
		{
			return dal.Exists(cardID,pwd);
		}
     
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.cardinfo model,out string CardID)
		{
			return dal.Add(model,out CardID);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.cardinfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string cardID)
		{
			
			return dal.Delete(cardID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string cardIDlist )
		{
			return dal.DeleteList(cardIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.cardinfo GetModel(string cardID)
		{
			
			return dal.GetModel(cardID);
		}

	

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.cardinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.cardinfo> DataTableToList(DataTable dt)
		{
			List<Model.cardinfo> modelList = new List<Model.cardinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.cardinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

