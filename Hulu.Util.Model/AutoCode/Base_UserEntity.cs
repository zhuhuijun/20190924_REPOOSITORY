/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_User                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_UserEntity : BaseEntity
    {  
        
		/// <summary>
        /// UserId:用户主键
        /// </summary>
        public string UserId { get; set; }
        
		/// <summary>
        /// EnCode:用户编码
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// Account:登录账户
        /// </summary>
        public string Account { get; set; }
        
		/// <summary>
        /// Password:登录密码
        /// </summary>
        public string Password { get; set; }
        
		/// <summary>
        /// Secretkey:密码秘钥
        /// </summary>
        public string Secretkey { get; set; }
        
		/// <summary>
        /// RealName:真实姓名
        /// </summary>
        public string RealName { get; set; }
        
		/// <summary>
        /// NickName:呢称
        /// </summary>
        public string NickName { get; set; }
        
		/// <summary>
        /// HeadIcon:头像
        /// </summary>
        public string HeadIcon { get; set; }
        
		/// <summary>
        /// QuickQuery:快速查询
        /// </summary>
        public string QuickQuery { get; set; }
        
		/// <summary>
        /// SimpleSpelling:简拼
        /// </summary>
        public string SimpleSpelling { get; set; }
        
		/// <summary>
        /// Gender:性别
        /// </summary>
        public int Gender { get; set; }
        
		/// <summary>
        /// Birthday:生日
        /// </summary>
        public DateTime Birthday { get; set; }
        
		/// <summary>
        /// Mobile:手机
        /// </summary>
        public string Mobile { get; set; }
        
		/// <summary>
        /// Telephone:电话
        /// </summary>
        public string Telephone { get; set; }
        
		/// <summary>
        /// Email:电子邮件
        /// </summary>
        public string Email { get; set; }
        
		/// <summary>
        /// OICQ:QQ号
        /// </summary>
        public string OICQ { get; set; }
        
		/// <summary>
        /// WeChat:微信号
        /// </summary>
        public string WeChat { get; set; }
        
		/// <summary>
        /// MSN:MSN
        /// </summary>
        public string MSN { get; set; }
        
		/// <summary>
        /// ManagerId:主管主键
        /// </summary>
        public string ManagerId { get; set; }
        
		/// <summary>
        /// Manager:主管
        /// </summary>
        public string Manager { get; set; }
        
		/// <summary>
        /// OrganizeId:机构主键
        /// </summary>
        public string OrganizeId { get; set; }
        
		/// <summary>
        /// DepartmentId:部门主键
        /// </summary>
        public string DepartmentId { get; set; }
        
		/// <summary>
        /// RoleId:角色主键
        /// </summary>
        public string RoleId { get; set; }
        
		/// <summary>
        /// DutyId:岗位主键
        /// </summary>
        public string DutyId { get; set; }
        
		/// <summary>
        /// DutyName:岗位名称
        /// </summary>
        public string DutyName { get; set; }
        
		/// <summary>
        /// PostId:职位主键
        /// </summary>
        public string PostId { get; set; }
        
		/// <summary>
        /// PostName:职位名称
        /// </summary>
        public string PostName { get; set; }
        
		/// <summary>
        /// WorkGroupId:工作组主键
        /// </summary>
        public string WorkGroupId { get; set; }
        
		/// <summary>
        /// SecurityLevel:安全级别
        /// </summary>
        public int SecurityLevel { get; set; }
        
		/// <summary>
        /// UserOnLine:在线状态
        /// </summary>
        public int UserOnLine { get; set; }
        
		/// <summary>
        /// OpenId:单点登录标识
        /// </summary>
        public int OpenId { get; set; }
        
		/// <summary>
        /// Question:密码提示问题
        /// </summary>
        public string Question { get; set; }
        
		/// <summary>
        /// AnswerQuestion:密码提示答案
        /// </summary>
        public string AnswerQuestion { get; set; }
        
		/// <summary>
        /// CheckOnLine:允许多用户同时登录
        /// </summary>
        public int CheckOnLine { get; set; }
        
		/// <summary>
        /// AllowStartTime:允许登录时间开始
        /// </summary>
        public DateTime AllowStartTime { get; set; }
        
		/// <summary>
        /// AllowEndTime:允许登录时间结束
        /// </summary>
        public DateTime AllowEndTime { get; set; }
        
		/// <summary>
        /// LockStartDate:暂停用户开始日期
        /// </summary>
        public DateTime LockStartDate { get; set; }
        
		/// <summary>
        /// LockEndDate:暂停用户结束日期
        /// </summary>
        public DateTime LockEndDate { get; set; }
        
		/// <summary>
        /// FirstVisit:第一次访问时间
        /// </summary>
        public DateTime FirstVisit { get; set; }
        
		/// <summary>
        /// PreviousVisit:上一次访问时间
        /// </summary>
        public DateTime PreviousVisit { get; set; }
        
		/// <summary>
        /// LastVisit:最后访问时间
        /// </summary>
        public DateTime LastVisit { get; set; }
        
		/// <summary>
        /// LogOnCount:登录次数
        /// </summary>
        public int LogOnCount { get; set; }
        
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
