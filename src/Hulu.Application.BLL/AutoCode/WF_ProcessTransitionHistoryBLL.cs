/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:12:41                            
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
    }
}

