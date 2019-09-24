/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_FilterTime                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_FilterTimeEntity : BaseEntity
    {  
        
		/// <summary>
        /// FilterTimeId:过滤时段主键
        /// </summary>
        public string FilterTimeId { get; set; }
        
		/// <summary>
        /// ObjectType:对象类型
        /// </summary>
        public string ObjectType { get; set; }
        
		/// <summary>
        /// ObjectId:对象Id
        /// </summary>
        public string ObjectId { get; set; }
        
		/// <summary>
        /// VisitType:访问
        /// </summary>
        public int VisitType { get; set; }
        
		/// <summary>
        /// WeekDay1:星期一
        /// </summary>
        public string WeekDay1 { get; set; }
        
		/// <summary>
        /// WeekDay2:星期二
        /// </summary>
        public string WeekDay2 { get; set; }
        
		/// <summary>
        /// WeekDay3:星期三
        /// </summary>
        public string WeekDay3 { get; set; }
        
		/// <summary>
        /// WeekDay4:星期四
        /// </summary>
        public string WeekDay4 { get; set; }
        
		/// <summary>
        /// WeekDay5:星期五
        /// </summary>
        public string WeekDay5 { get; set; }
        
		/// <summary>
        /// WeekDay6:星期六
        /// </summary>
        public string WeekDay6 { get; set; }
        
		/// <summary>
        /// WeekDay7:星期日
        /// </summary>
        public string WeekDay7 { get; set; }
        
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
