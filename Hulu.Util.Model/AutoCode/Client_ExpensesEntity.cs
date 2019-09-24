/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_Expenses                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_ExpensesEntity : BaseEntity
    {  
        
		/// <summary>
        /// ExpensesId:支出主键
        /// </summary>
        public string ExpensesId { get; set; }
        
		/// <summary>
        /// ExpensesDate:支出日期
        /// </summary>
        public DateTime ExpensesDate { get; set; }
        
		/// <summary>
        /// ExpensesPrice:支出金额
        /// </summary>
        public decimal ExpensesPrice { get; set; }
        
		/// <summary>
        /// ExpensesAccount:支出账户
        /// </summary>
        public string ExpensesAccount { get; set; }
        
		/// <summary>
        /// ExpensesType:支出种类
        /// </summary>
        public string ExpensesType { get; set; }
        
		/// <summary>
        /// ExpensesAbstract:支出摘要
        /// </summary>
        public string ExpensesAbstract { get; set; }
        
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
        
		/// <summary>
        /// ExpensesObject:
        /// </summary>
        public int ExpensesObject { get; set; }
        
		/// <summary>
        /// Managers:经办人
        /// </summary>
        public string Managers { get; set; }
   

    }
}
