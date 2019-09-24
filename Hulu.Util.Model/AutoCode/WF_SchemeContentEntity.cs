/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_SchemeContent                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_SchemeContentEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:主键Id
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// WFSchemeInfoId:流程内容Id
        /// </summary>
        public string WFSchemeInfoId { get; set; }
        
		/// <summary>
        /// SchemeVersion:流程内容版本
        /// </summary>
        public string SchemeVersion { get; set; }
        
		/// <summary>
        /// SchemeContent:流程内容
        /// </summary>
        public string SchemeContent { get; set; }
        
		/// <summary>
        /// CreateDate:创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        
		/// <summary>
        /// CreateUserId:创建用户主键
        /// </summary>
        public string CreateUserId { get; set; }
        
		/// <summary>
        /// CreateUserName:创建用户
        /// </summary>
        public string CreateUserName { get; set; }
   

    }
}
