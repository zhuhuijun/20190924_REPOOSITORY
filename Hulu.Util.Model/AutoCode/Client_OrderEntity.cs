/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_Order                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_OrderEntity : BaseEntity
    {  
        
		/// <summary>
        /// OrderId:订单主键
        /// </summary>
        public string OrderId { get; set; }
        
		/// <summary>
        /// CustomerId:客户主键
        /// </summary>
        public string CustomerId { get; set; }
        
		/// <summary>
        /// CustomerName:客户名称
        /// </summary>
        public string CustomerName { get; set; }
        
		/// <summary>
        /// SellerId:销售人员Id
        /// </summary>
        public string SellerId { get; set; }
        
		/// <summary>
        /// SellerName:销售人员
        /// </summary>
        public string SellerName { get; set; }
        
		/// <summary>
        /// OrderDate:单据日期
        /// </summary>
        public DateTime OrderDate { get; set; }
        
		/// <summary>
        /// OrderCode:单据编号
        /// </summary>
        public string OrderCode { get; set; }
        
		/// <summary>
        /// DiscountSum:优惠金额
        /// </summary>
        public decimal DiscountSum { get; set; }
        
		/// <summary>
        /// Accounts:应收金额
        /// </summary>
        public decimal Accounts { get; set; }
        
		/// <summary>
        /// ReceivedAmount:已收金额
        /// </summary>
        public decimal ReceivedAmount { get; set; }
        
		/// <summary>
        /// PaymentDate:收款日期
        /// </summary>
        public DateTime PaymentDate { get; set; }
        
		/// <summary>
        /// PaymentMode:收款方式
        /// </summary>
        public string PaymentMode { get; set; }
        
		/// <summary>
        /// PaymentState:收款状态（1-未收款2-部分收款3-全部收款）
        /// </summary>
        public int PaymentState { get; set; }
        
		/// <summary>
        /// SaleCost:销售费用
        /// </summary>
        public decimal SaleCost { get; set; }
        
		/// <summary>
        /// AbstractInfo:摘要信息
        /// </summary>
        public string AbstractInfo { get; set; }
        
		/// <summary>
        /// ContractCode:合同编号
        /// </summary>
        public string ContractCode { get; set; }
        
		/// <summary>
        /// ContractFile:合同附件
        /// </summary>
        public string ContractFile { get; set; }
        
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
