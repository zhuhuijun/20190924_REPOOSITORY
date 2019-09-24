/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_DelegateRule                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_DelegateRuleEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// ToUserId:被委托人Id
        /// </summary>
        public string ToUserId { get; set; }
        
		/// <summary>
        /// ToUserName:被委托人
        /// </summary>
        public string ToUserName { get; set; }
        
		/// <summary>
        /// BeginDate:委托开始时间
        /// </summary>
        public DateTime BeginDate { get; set; }
        
		/// <summary>
        /// EndDate:委托结束时间
        /// </summary>
        public DateTime EndDate { get; set; }
        
		/// <summary>
        /// CreateUserId:委托人Id
        /// </summary>
        public string CreateUserId { get; set; }
        
		/// <summary>
        /// CreateUserName:委托人
        /// </summary>
        public string CreateUserName { get; set; }
        
		/// <summary>
        /// CreateDate:创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        
		/// <summary>
        /// EnabledMark:有效标志
        /// </summary>
        public int EnabledMark { get; set; }
        
		/// <summary>
        /// Description:备注
        /// </summary>
        public string Description { get; set; }
   

    }
}
