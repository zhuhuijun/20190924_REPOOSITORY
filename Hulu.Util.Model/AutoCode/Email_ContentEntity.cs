/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Email_Content                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Email_ContentEntity : BaseEntity
    {  
        
		/// <summary>
        /// ContentId:邮件信息主键
        /// </summary>
        public string ContentId { get; set; }
        
		/// <summary>
        /// CategoryId:邮件分类主键
        /// </summary>
        public string CategoryId { get; set; }
        
		/// <summary>
        /// ParentId:父级主键
        /// </summary>
        public string ParentId { get; set; }
        
		/// <summary>
        /// Theme:邮件主题
        /// </summary>
        public string Theme { get; set; }
        
		/// <summary>
        /// ThemeColor:邮件主题色彩
        /// </summary>
        public string ThemeColor { get; set; }
        
		/// <summary>
        /// EmailContent:邮件内容
        /// </summary>
        public string EmailContent { get; set; }
        
		/// <summary>
        /// EmailType:邮件类型（1-内部2-外部）
        /// </summary>
        public int EmailType { get; set; }
        
		/// <summary>
        /// SenderId:发件人Id
        /// </summary>
        public string SenderId { get; set; }
        
		/// <summary>
        /// SenderName:发件人
        /// </summary>
        public string SenderName { get; set; }
        
		/// <summary>
        /// SenderTime:发件日期
        /// </summary>
        public DateTime SenderTime { get; set; }
        
		/// <summary>
        /// IsHighlight:设置红旗
        /// </summary>
        public int IsHighlight { get; set; }
        
		/// <summary>
        /// SendPriority:优先级
        /// </summary>
        public string SendPriority { get; set; }
        
		/// <summary>
        /// IsSmsReminder:短信提醒
        /// </summary>
        public int IsSmsReminder { get; set; }
        
		/// <summary>
        /// IsReceipt:已读回执
        /// </summary>
        public int IsReceipt { get; set; }
        
		/// <summary>
        /// AddresssHtml:收件人html
        /// </summary>
        public string AddresssHtml { get; set; }
        
		/// <summary>
        /// CopysendHtml:抄送人html
        /// </summary>
        public string CopysendHtml { get; set; }
        
		/// <summary>
        /// BccsendHtml:密送人html
        /// </summary>
        public string BccsendHtml { get; set; }
        
		/// <summary>
        /// SendState:发送状态（1-已发送0-草稿）
        /// </summary>
        public int SendState { get; set; }
        
		/// <summary>
        /// DeleteMark:删除标记
        /// </summary>
        public int DeleteMark { get; set; }
        
		/// <summary>
        /// EnabledMark:有效标志
        /// </summary>
        public int EnabledMark { get; set; }
        
		/// <summary>
        /// Description:备注
        /// </summary>
        public string Description { get; set; }
        
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
