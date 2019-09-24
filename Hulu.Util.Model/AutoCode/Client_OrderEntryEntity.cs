/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_OrderEntry                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_OrderEntryEntity : BaseEntity
    {  
        
		/// <summary>
        /// OrderEntryId:订单明细主键
        /// </summary>
        public string OrderEntryId { get; set; }
        
		/// <summary>
        /// OrderId:订单主键
        /// </summary>
        public string OrderId { get; set; }
        
		/// <summary>
        /// ProductId:商品Id
        /// </summary>
        public string ProductId { get; set; }
        
		/// <summary>
        /// ProductCode:商品编号
        /// </summary>
        public string ProductCode { get; set; }
        
		/// <summary>
        /// ProductName:商品名称
        /// </summary>
        public string ProductName { get; set; }
        
		/// <summary>
        /// UnitId:单位
        /// </summary>
        public string UnitId { get; set; }
        
		/// <summary>
        /// Qty:数量
        /// </summary>
        public decimal Qty { get; set; }
        
		/// <summary>
        /// Price:单价
        /// </summary>
        public decimal Price { get; set; }
        
		/// <summary>
        /// Amount:金额
        /// </summary>
        public decimal Amount { get; set; }
        
		/// <summary>
        /// Taxprice:含税单价
        /// </summary>
        public decimal Taxprice { get; set; }
        
		/// <summary>
        /// TaxRate:税率
        /// </summary>
        public decimal TaxRate { get; set; }
        
		/// <summary>
        /// Tax:税额
        /// </summary>
        public decimal Tax { get; set; }
        
		/// <summary>
        /// TaxAmount:含税金额
        /// </summary>
        public decimal TaxAmount { get; set; }
        
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
   

    }
}
