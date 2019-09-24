/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:49                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间:Hulu.Application.IService                              
*│　类   名:IWF_SchemeInfoAuthorizeService                                
*└──────────────────────────────────────────────────────────────┘
*/


using System;
using System.Collections.Generic;
using System.Text;
using Hulu.Util.Model;
namespace Hulu.Application.IService
{	
	/// <summary>
	/// IWF_SchemeInfoAuthorizeService
	/// </summary>	
	public partial interface IWF_SchemeInfoAuthorizeService
    {
        #region 获取数据
        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        IEnumerable<WF_SchemeInfoAuthorizeEntity> GetList_Auto();
        /// <summary>
        /// GetPageList
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<WF_SchemeInfoAuthorizeEntity> GetPageList_Auto(Pagination pagination, string queryJson);

        /// <summary>
        /// GetEntity
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        WF_SchemeInfoAuthorizeEntity GetEntity_Auto(string keyValue);
		#endregion

        #region 提交数据
        /// <summary>
        /// RemoveForm
        /// </summary>
        /// <param name="keyValue">主键</param>
        void RemoveForm_Auto(string keyValue);
        /// <summary>
        /// 保存职位表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="oneEntity">职位实体</param>
        /// <returns></returns>
        void SaveForm_Auto(string keyValue, WF_SchemeInfoAuthorizeEntity oneEntity);
        #endregion
    }
}

