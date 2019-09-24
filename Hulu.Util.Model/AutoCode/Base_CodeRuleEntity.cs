/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_CodeRule                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_CodeRuleEntity : BaseEntity
    {  
        
		/// <summary>
        /// RuleId:编码规则主键
        /// </summary>
        public string RuleId { get; set; }
        
		/// <summary>
        /// ModuleId:系统功能Id
        /// </summary>
        public string ModuleId { get; set; }
        
		/// <summary>
        /// Module:系统功能
        /// </summary>
        public string Module { get; set; }
        
		/// <summary>
        /// EnCode:编号
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// FullName:名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// Mode:方式（可编辑、自动）
        /// </summary>
        public int Mode { get; set; }
        
		/// <summary>
        /// CurrentNumber:当前流水号
        /// </summary>
        public string CurrentNumber { get; set; }
        
		/// <summary>
        /// RuleFormatJson:规则格式Json
        /// </summary>
        public string RuleFormatJson { get; set; }
        
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
