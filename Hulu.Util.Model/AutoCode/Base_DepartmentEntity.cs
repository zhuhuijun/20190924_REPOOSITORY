/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Department                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_DepartmentEntity : BaseEntity
    {  
        
		/// <summary>
        /// DepartmentId:部门主键
        /// </summary>
        public string DepartmentId { get; set; }
        
		/// <summary>
        /// OrganizeId:机构主键
        /// </summary>
        public string OrganizeId { get; set; }
        
		/// <summary>
        /// ParentId:父级主键
        /// </summary>
        public string ParentId { get; set; }
        
		/// <summary>
        /// EnCode:部门代码
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// FullName:部门名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// ShortName:部门简称
        /// </summary>
        public string ShortName { get; set; }
        
		/// <summary>
        /// Nature:部门类型
        /// </summary>
        public string Nature { get; set; }
        
		/// <summary>
        /// ManagerId:负责人主键
        /// </summary>
        public string ManagerId { get; set; }
        
		/// <summary>
        /// Manager:负责人
        /// </summary>
        public string Manager { get; set; }
        
		/// <summary>
        /// OuterPhone:外线电话
        /// </summary>
        public string OuterPhone { get; set; }
        
		/// <summary>
        /// InnerPhone:内线电话
        /// </summary>
        public string InnerPhone { get; set; }
        
		/// <summary>
        /// Email:电子邮件
        /// </summary>
        public string Email { get; set; }
        
		/// <summary>
        /// Fax:部门传真
        /// </summary>
        public string Fax { get; set; }
        
		/// <summary>
        /// Layer:层
        /// </summary>
        public int Layer { get; set; }
        
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
