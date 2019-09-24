/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_ModuleFormInstance                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_ModuleFormInstanceEntity : BaseEntity
    {  
        
		/// <summary>
        /// FormInstanceId:表单实例主键
        /// </summary>
        public string FormInstanceId { get; set; }
        
		/// <summary>
        /// FormId:表单主键
        /// </summary>
        public string FormId { get; set; }
        
		/// <summary>
        /// FormInstanceJson:表单实例Json
        /// </summary>
        public string FormInstanceJson { get; set; }
        
		/// <summary>
        /// ObjectId:对象主键
        /// </summary>
        public string ObjectId { get; set; }
        
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
