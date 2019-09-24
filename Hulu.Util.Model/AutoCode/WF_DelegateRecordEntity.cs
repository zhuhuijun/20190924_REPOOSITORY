/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_DelegateRecord                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_DelegateRecordEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// WFDelegateRuleId:委托规则Id
        /// </summary>
        public string WFDelegateRuleId { get; set; }
        
		/// <summary>
        /// FromUserId:委托人Id
        /// </summary>
        public string FromUserId { get; set; }
        
		/// <summary>
        /// FromUserName:委托人
        /// </summary>
        public string FromUserName { get; set; }
        
		/// <summary>
        /// ToUserId:被委托人Id
        /// </summary>
        public string ToUserId { get; set; }
        
		/// <summary>
        /// ToUserName:被委托人名称
        /// </summary>
        public string ToUserName { get; set; }
        
		/// <summary>
        /// CreateDate:创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        
		/// <summary>
        /// ProcessId:流程实例Id
        /// </summary>
        public string ProcessId { get; set; }
        
		/// <summary>
        /// ProcessCode:实例编号
        /// </summary>
        public string ProcessCode { get; set; }
        
		/// <summary>
        /// ProcessName:实例自定义名称
        /// </summary>
        public string ProcessName { get; set; }
   

    }
}
