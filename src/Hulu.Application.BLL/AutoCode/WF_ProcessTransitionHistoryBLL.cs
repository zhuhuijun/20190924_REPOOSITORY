/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 20:12:16                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间:Hulu.Application.BLL                              
*│　类   名:WF_ProcessTransitionHistoryBLL                               
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;
using Hulu.Application.IService;
using Hulu.Application.Service;
using Hulu.Util.Model;

namespace Hulu.Application.BLL
{	
	/// <summary>
	/// WF_ProcessTransitionHistoryBLL
	/// </summary>	
	public partial class WF_ProcessTransitionHistoryBLL
    {
		private IWF_ProcessTransitionHistoryService service = new WF_ProcessTransitionHistoryService();
        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public IEnumerable<WF_ProcessTransitionHistoryEntity> GetList()
        {
            return service.GetList_Auto();
        }
        /// <summary>
        /// GetPageList
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<WF_ProcessTransitionHistoryEntity> GetPageList(Pagination pagination, string queryJson)
        {
            return service.GetPageList_Auto(pagination, queryJson);
        }
        /// <summary>
        /// GetEntity
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public WF_ProcessTransitionHistoryEntity GetEntity(string keyValue)
        {
            return service.GetEntity_Auto(keyValue);
        }

        #region 提交数据
        /// <summary>
        /// 删除职位
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void RemoveForm(string keyValue)
        {
            try
            {
                service.RemoveForm_Auto(keyValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 保存SaveForm
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="oneEntity">oneEntity</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, WF_ProcessTransitionHistoryEntity oneEntity)
        {
            try
            {
                service.SaveForm_Auto(keyValue, oneEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}

