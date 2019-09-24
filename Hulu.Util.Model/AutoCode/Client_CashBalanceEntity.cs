/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_CashBalance                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_CashBalanceEntity : BaseEntity
    {  
        
		/// <summary>
        /// CashBalanceId:现金余额主键
        /// </summary>
        public string CashBalanceId { get; set; }
        
		/// <summary>
        /// ObjectId:对象主键
        /// </summary>
        public string ObjectId { get; set; }
        
		/// <summary>
        /// ExecutionDate:
        /// </summary>
        public DateTime ExecutionDate { get; set; }
        
		/// <summary>
        /// CashAccount:
        /// </summary>
        public string CashAccount { get; set; }
        
		/// <summary>
        /// Receivable:
        /// </summary>
        public decimal Receivable { get; set; }
        
		/// <summary>
        /// Expenses:
        /// </summary>
        public decimal Expenses { get; set; }
        
		/// <summary>
        /// Balance:
        /// </summary>
        public decimal Balance { get; set; }
        
		/// <summary>
        /// Abstract:
        /// </summary>
        public string Abstract { get; set; }
        
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
