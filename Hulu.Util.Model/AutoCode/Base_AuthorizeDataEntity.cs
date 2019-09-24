/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_AuthorizeData                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_AuthorizeDataEntity : BaseEntity
    {  
        
		/// <summary>
        /// AuthorizeDataId:授权数据主键
        /// </summary>
        public string AuthorizeDataId { get; set; }
        
		/// <summary>
        /// AuthorizeType:1-仅限本人2-仅限本人及下属3-所在部门4-所在公司5-按明细设置
        /// </summary>
        public int AuthorizeType { get; set; }
        
		/// <summary>
        /// Category:对象分类:1-部门2-角色3-岗位4-职位5-工作组
        /// </summary>
        public int Category { get; set; }
        
		/// <summary>
        /// ObjectId:对象主键
        /// </summary>
        public string ObjectId { get; set; }
        
		/// <summary>
        /// ItemId:项目Id
        /// </summary>
        public string ItemId { get; set; }
        
		/// <summary>
        /// ItemName:项目Id
        /// </summary>
        public string ItemName { get; set; }
        
		/// <summary>
        /// ResourceId:项目名称
        /// </summary>
        public string ResourceId { get; set; }
        
		/// <summary>
        /// IsRead:只读
        /// </summary>
        public int IsRead { get; set; }
        
		/// <summary>
        /// AuthorizeConstraint:约束表达式
        /// </summary>
        public string AuthorizeConstraint { get; set; }
        
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
