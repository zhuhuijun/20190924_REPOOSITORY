/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_SchemeInfoAuthorize                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_SchemeInfoAuthorizeEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// SchemeInfoId:流程模板信息Id
        /// </summary>
        public string SchemeInfoId { get; set; }
        
		/// <summary>
        /// ObjectId:权限对象Id
        /// </summary>
        public string ObjectId { get; set; }
   

    }
}
