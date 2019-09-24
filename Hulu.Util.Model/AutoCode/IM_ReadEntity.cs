/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：IM_Read                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class IM_ReadEntity : BaseEntity
    {  
        
		/// <summary>
        /// ReadId:未读消息主键
        /// </summary>
        public string ReadId { get; set; }
        
		/// <summary>
        /// ContentId:消息主键
        /// </summary>
        public string ContentId { get; set; }
        
		/// <summary>
        /// UserId:用户主键
        /// </summary>
        public string UserId { get; set; }
        
		/// <summary>
        /// SendId:发送者ID
        /// </summary>
        public string SendId { get; set; }
        
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
        
		/// <summary>
        /// ReadStatus:发送状态（0-未送达，1-已送达，2-已阅读）
        /// </summary>
        public int ReadStatus { get; set; }
   

    }
}
