/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_UserRelation                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_UserRelationEntity : BaseEntity
    {  
        
		/// <summary>
        /// UserRelationId:用户关系主键
        /// </summary>
        public string UserRelationId { get; set; }
        
		/// <summary>
        /// UserId:用户主键
        /// </summary>
        public string UserId { get; set; }
        
		/// <summary>
        /// Category:分类:1-部门2-角色3-岗位4-职位5-工作组
        /// </summary>
        public int Category { get; set; }
        
		/// <summary>
        /// ObjectId:对象主键
        /// </summary>
        public string ObjectId { get; set; }
        
		/// <summary>
        /// IsDefault:默认对象
        /// </summary>
        public int IsDefault { get; set; }
        
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
