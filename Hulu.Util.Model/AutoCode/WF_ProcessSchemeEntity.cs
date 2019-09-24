/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_ProcessScheme                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_ProcessSchemeEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:主键Id
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// SchemeContent:流程模板内容
        /// </summary>
        public string SchemeContent { get; set; }
        
		/// <summary>
        /// WFSchemeInfoId:流程模板ID
        /// </summary>
        public string WFSchemeInfoId { get; set; }
        
		/// <summary>
        /// SchemeVersion:流程内容版本
        /// </summary>
        public string SchemeVersion { get; set; }
        
		/// <summary>
        /// ProcessType:类型(0.正常,1.草稿)
        /// </summary>
        public int ProcessType { get; set; }
   

    }
}
