/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_DelegateRuleSchemeInfo                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_DelegateRuleSchemeInfoEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// DelegateRuleId:规则Id
        /// </summary>
        public string DelegateRuleId { get; set; }
        
		/// <summary>
        /// SchemeInfoId:模板Id
        /// </summary>
        public string SchemeInfoId { get; set; }
   

    }
}
