/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Role                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_RoleEntity : BaseEntity
    {  
        
		/// <summary>
        /// RoleId:角色主键
        /// </summary>
        public string RoleId { get; set; }
        
		/// <summary>
        /// OrganizeId:机构主键
        /// </summary>
        public string OrganizeId { get; set; }
        
		/// <summary>
        /// Category:分类1-角色2-岗位3-职位4-工作组
        /// </summary>
        public int Category { get; set; }
        
		/// <summary>
        /// EnCode:角色编码
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// FullName:角色名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// IsPublic:公共角色
        /// </summary>
        public int IsPublic { get; set; }
        
		/// <summary>
        /// OverdueTime:过期时间
        /// </summary>
        public DateTime OverdueTime { get; set; }
        
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
