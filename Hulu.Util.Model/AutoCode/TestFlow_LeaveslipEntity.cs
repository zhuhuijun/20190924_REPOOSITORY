/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：TestFlow_Leaveslip                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class TestFlow_LeaveslipEntity : BaseEntity
    {  
        
		/// <summary>
        /// id:主键
        /// </summary>
        public string id { get; set; }
        
		/// <summary>
        /// type:请假类别
        /// </summary>
        public string type { get; set; }
        
		/// <summary>
        /// reason:请假原因
        /// </summary>
        public string reason { get; set; }
        
		/// <summary>
        /// begintime:请假开始时间
        /// </summary>
        public string begintime { get; set; }
        
		/// <summary>
        /// endtime:请假结束时间
        /// </summary>
        public string endtime { get; set; }
        
		/// <summary>
        /// days:天数
        /// </summary>
        public int days { get; set; }
   

    }
}
