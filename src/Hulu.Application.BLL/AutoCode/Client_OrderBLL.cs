/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 20:12:16                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间:Hulu.Application.BLL                              
*│　类   名:Client_OrderBLL                               
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
	/// Client_OrderBLL
	/// </summary>	
	public partial class Client_OrderBLL
    {
		private IClient_OrderService service = new Client_OrderService();
        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Client_OrderEntity> GetList()
        {
            return service.GetList_Auto();
        }
        /// <summary>
        /// GetPageList
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<Client_OrderEntity> GetPageList(Pagination pagination, string queryJson)
        {
            return service.GetPageList_Auto(pagination, queryJson);
        }
        /// <summary>
        /// GetEntity
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public Client_OrderEntity GetEntity(string keyValue)
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
        public void SaveForm(string keyValue, Client_OrderEntity oneEntity)
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

