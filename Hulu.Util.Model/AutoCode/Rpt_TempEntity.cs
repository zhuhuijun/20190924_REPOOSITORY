/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Rpt_Temp                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Rpt_TempEntity : BaseEntity
    {  
        
		/// <summary>
        /// TempId:模板主键
        /// </summary>
        public string TempId { get; set; }
        
		/// <summary>
        /// FullName:报表名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// EnCode:报表编号
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// TempType:报表类型
        /// </summary>
        public string TempType { get; set; }
        
		/// <summary>
        /// Description:报表介绍
        /// </summary>
        public string Description { get; set; }
        
		/// <summary>
        /// ParamJson:报表参数Json
        /// </summary>
        public string ParamJson { get; set; }
        
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
        
		/// <summary>
        /// TempCategory:
        /// </summary>
        public string TempCategory { get; set; }
   

    }
}
