/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Authorize                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_AuthorizeEntity : BaseEntity
    {  
        
		/// <summary>
        /// AuthorizeId:授权功能主键
        /// </summary>
        public string AuthorizeId { get; set; }
        
		/// <summary>
        /// Category:对象分类:1-部门2-角色3-岗位4-职位5-工作组
        /// </summary>
        public int Category { get; set; }
        
		/// <summary>
        /// ObjectId:对象主键
        /// </summary>
        public string ObjectId { get; set; }
        
		/// <summary>
        /// ItemType:项目类型:1-菜单2-按钮3-视图4表单
        /// </summary>
        public int ItemType { get; set; }
        
		/// <summary>
        /// ItemId:项目主键
        /// </summary>
        public string ItemId { get; set; }
        
		/// <summary>
        /// SortCode:排序码
        /// </summary>
        public int SortCode { get; set; }
        
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
