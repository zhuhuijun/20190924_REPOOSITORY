/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Schedule                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_ScheduleEntity : BaseEntity
    {  
        
		/// <summary>
        /// ScheduleId:日程主键
        /// </summary>
        public string ScheduleId { get; set; }
        
		/// <summary>
        /// ScheduleName:日程名称
        /// </summary>
        public string ScheduleName { get; set; }
        
		/// <summary>
        /// ScheduleContent:日程内容
        /// </summary>
        public string ScheduleContent { get; set; }
        
		/// <summary>
        /// Category:类别
        /// </summary>
        public string Category { get; set; }
        
		/// <summary>
        /// StartDate:开始日期
        /// </summary>
        public DateTime StartDate { get; set; }
        
		/// <summary>
        /// StartTime:开始时间
        /// </summary>
        public string StartTime { get; set; }
        
		/// <summary>
        /// EndDate:结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
        
		/// <summary>
        /// EndTime:结束时间
        /// </summary>
        public string EndTime { get; set; }
        
		/// <summary>
        /// Early:提前提醒
        /// </summary>
        public int Early { get; set; }
        
		/// <summary>
        /// IsMailAlert:邮件提醒
        /// </summary>
        public int IsMailAlert { get; set; }
        
		/// <summary>
        /// IsMobileAlert:手机提醒
        /// </summary>
        public int IsMobileAlert { get; set; }
        
		/// <summary>
        /// IsWeChatAlert:微信提醒
        /// </summary>
        public int IsWeChatAlert { get; set; }
        
		/// <summary>
        /// ScheduleState:日程状态
        /// </summary>
        public int ScheduleState { get; set; }
        
		/// <summary>
        /// SortCode:排序码
        /// </summary>
        public int SortCode { get; set; }
        
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
