/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:12:41                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间:Hulu.Application.BLL                              
*│　类   名:WF_DelegateRecordBLL                               
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
	/// WF_DelegateRecordBLL
	/// </summary>	
	public partial class WF_DelegateRecordBLL
    {
		private IWF_DelegateRecordService service = new WF_DelegateRecordService();
        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public IEnumerable<WF_DelegateRecordEntity> GetList()
        {
            return service.GetList_Auto();
        }
    }
}

