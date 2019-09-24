/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_Receivable                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_ReceivableEntity : BaseEntity
    {  
        
		/// <summary>
        /// ReceivableId:账款主键
        /// </summary>
        public string ReceivableId { get; set; }
        
		/// <summary>
        /// OrderId:订单主键
        /// </summary>
        public string OrderId { get; set; }
        
		/// <summary>
        /// PaymentTime:收款日期
        /// </summary>
        public DateTime PaymentTime { get; set; }
        
		/// <summary>
        /// PaymentPrice:收款金额
        /// </summary>
        public decimal PaymentPrice { get; set; }
        
		/// <summary>
        /// PaymentMode:收款方式
        /// </summary>
        public string PaymentMode { get; set; }
        
		/// <summary>
        /// PaymentAccount:收款账户
        /// </summary>
        public string PaymentAccount { get; set; }
        
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
