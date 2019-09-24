/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:04:32                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间:Hulu.Application.BLL                              
*│　类   名:Wechat_UserRelationBLL                               
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;
using Hulu.Data.Repository;
using Hulu.Application.IService;
using Hulu.Util.Model;

namespace Hulu.Application.Service
{	
	/// <summary>
	/// IWechat_UserRelationService
	/// </summary>	
	public partial class Wechat_UserRelationBLL
    {
		private IWechat_UserRelationService service = new Wechat_UserRelationService();
        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Wechat_UserRelationEntity> GetList()
        {
            return service.GetList_Auto();
        }
    }
}

