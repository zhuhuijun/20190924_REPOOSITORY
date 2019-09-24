/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Email_Addressee                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Email_AddresseeEntity : BaseEntity
    {  
        
		/// <summary>
        /// AddresseeId:邮箱收件人主键
        /// </summary>
        public string AddresseeId { get; set; }
        
		/// <summary>
        /// ContentId:邮件信息主键
        /// </summary>
        public string ContentId { get; set; }
        
		/// <summary>
        /// CategoryId:邮件分类主键
        /// </summary>
        public string CategoryId { get; set; }
        
		/// <summary>
        /// RecipientId:收件人Id
        /// </summary>
        public string RecipientId { get; set; }
        
		/// <summary>
        /// RecipientName:收件人
        /// </summary>
        public string RecipientName { get; set; }
        
		/// <summary>
        /// RecipientState:收件状态（0-收件1-抄送2-密送）
        /// </summary>
        public int RecipientState { get; set; }
        
		/// <summary>
        /// IsRead:是否阅读
        /// </summary>
        public int IsRead { get; set; }
        
		/// <summary>
        /// ReadCount:阅读次数
        /// </summary>
        public int ReadCount { get; set; }
        
		/// <summary>
        /// ReadDate:最后阅读日期
        /// </summary>
        public DateTime ReadDate { get; set; }
        
		/// <summary>
        /// IsHighlight:设置红旗
        /// </summary>
        public int IsHighlight { get; set; }
        
		/// <summary>
        /// Backlog:设置待办
        /// </summary>
        public int Backlog { get; set; }
        
		/// <summary>
        /// DeleteMark:删除标记
        /// </summary>
        public int DeleteMark { get; set; }
        
		/// <summary>
        /// CreateDate:创建日期
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
        /// ModifyDate:修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }
        
		/// <summary>
        /// ModifyUserId:修改用户主键
        /// </summary>
        public string ModifyUserId { get; set; }
        
		/// <summary>
        /// ModifyUserName:修改用户
        /// </summary>
        public string ModifyUserName { get; set; }
   

    }
}
