/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_ModuleColumn                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_ModuleColumnEntity : BaseEntity
    {  
        
		/// <summary>
        /// ModuleColumnId:列主键
        /// </summary>
        public string ModuleColumnId { get; set; }
        
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
        /// SortCode:排序码
        /// </summary>
        public int SortCode { get; set; }
        
		/// <summary>
        /// Description:备注
        /// </summary>
        public string Description { get; set; }
   

    }
}
