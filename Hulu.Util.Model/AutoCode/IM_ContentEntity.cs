/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：IM_Content                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class IM_ContentEntity : BaseEntity
    {  
        
		/// <summary>
        /// ContentId:消息主键
        /// </summary>
        public string ContentId { get; set; }
        
		/// <summary>
        /// IsGroup:是否群组消息
        /// </summary>
        public int IsGroup { get; set; }
        
		/// <summary>
        /// SendId:发送者ID
        /// </summary>
        public string SendId { get; set; }
        
		/// <summary>
        /// ToId:接收者ID
        /// </summary>
        public string ToId { get; set; }
        
		/// <summary>
        /// MsgContent:消息内容
        /// </summary>
        public string MsgContent { get; set; }
        
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
