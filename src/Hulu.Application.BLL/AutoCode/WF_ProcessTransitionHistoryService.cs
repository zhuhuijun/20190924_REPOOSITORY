/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 17:40:36                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间:Hulu.Application.Service                              
*│　类   名:WF_ProcessTransitionHistoryService                                
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;
using Hulu.Data.Repository;
using Hulu.Application.IService;
using Hulu.Util.Model;
using Hulu.Util.Attributes;
using System.Linq;
using Hulu.Util.Attributes.Json;

namespace Hulu.Application.Service
{	
	/// <summary>
	/// IWF_ProcessTransitionHistoryService
	/// </summary>	
	public partial class WF_ProcessTransitionHistoryService : RepositoryFactory<WF_ProcessTransitionHistoryEntity>,IWF_ProcessTransitionHistoryService
    {
        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public IEnumerable<WF_ProcessTransitionHistoryEntity> GetList_Auto()
        {
            var expression = LinqExtensions.True<WF_ProcessTransitionHistoryEntity>();
            return this.BaseRepository().IQueryable(expression).ToList();
        }
        /// <summary>
        /// GetEntity
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public WF_ProcessTransitionHistoryEntity GetEntity_Auto(string keyValue)
        {
            return this.BaseRepository().FindEntity(keyValue);
        }
        /// <summary>
        /// 职位列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<WF_ProcessTransitionHistoryEntity> GetPageList_Auto(Pagination pagination, string queryJson)
        {
            var expression = LinqExtensions.True<WF_ProcessTransitionHistoryEntity>();
            var queryParam = queryJson.ToJObject();
            return this.BaseRepository().FindList(expression, pagination);
        }
        /// <summary>
        /// RemoveForm
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void RemoveForm_Auto(string keyValue)
        {
            this.BaseRepository().Delete(keyValue);
        }
        /// <summary>
        /// 保存职位表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="oneEntity">职位实体</param>
        /// <returns></returns>
        public void SaveForm_Auto(string keyValue, WF_ProcessTransitionHistoryEntity oneEntity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                oneEntity.Modify(keyValue);
                this.BaseRepository().Update(oneEntity);
            }
            else
            {
                oneEntity.Create();
                this.BaseRepository().Insert(oneEntity);
            }
        }
    }
}

