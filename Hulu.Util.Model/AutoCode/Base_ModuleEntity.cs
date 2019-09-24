/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Module                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_ModuleEntity : BaseEntity
    {  
        
		/// <summary>
        /// ModuleId:功能主键
        /// </summary>
        public string ModuleId { get; set; }
        
		/// <summary>
        /// ParentId:父级主键
        /// </summary>
        public string ParentId { get; set; }
        
		/// <summary>
        /// EnCode:编码
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// FullName:名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// Icon:图标
        /// </summary>
        public string Icon { get; set; }
        
		/// <summary>
        /// UrlAddress:导航地址
        /// </summary>
        public string UrlAddress { get; set; }
        
		/// <summary>
        /// Target:导航目标
        /// </summary>
        public string Target { get; set; }
        
		/// <summary>
        /// IsMenu:菜单选项
        /// </summary>
        public int IsMenu { get; set; }
        
		/// <summary>
        /// AllowExpand:允许展开
        /// </summary>
        public int AllowExpand { get; set; }
        
		/// <summary>
        /// IsPublic:是否公开
        /// </summary>
        public int IsPublic { get; set; }
        
		/// <summary>
        /// AllowEdit:允许编辑
        /// </summary>
        public int AllowEdit { get; set; }
        
		/// <summary>
        /// AllowDelete:允许删除
        /// </summary>
        public int AllowDelete { get; set; }
        
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
