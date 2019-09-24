/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_Chance                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_ChanceEntity : BaseEntity
    {  
        
		/// <summary>
        /// ChanceId:商机主键
        /// </summary>
        public string ChanceId { get; set; }
        
		/// <summary>
        /// EnCode:商机编号
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// FullName:商机名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// SourceId:商机来源
        /// </summary>
        public string SourceId { get; set; }
        
		/// <summary>
        /// StageId:商机阶段
        /// </summary>
        public string StageId { get; set; }
        
		/// <summary>
        /// SuccessRate:成功率
        /// </summary>
        public decimal SuccessRate { get; set; }
        
		/// <summary>
        /// Amount:预计金额
        /// </summary>
        public decimal Amount { get; set; }
        
		/// <summary>
        /// Profit:预计利润
        /// </summary>
        public decimal Profit { get; set; }
        
		/// <summary>
        /// ChanceTypeId:商机类型
        /// </summary>
        public string ChanceTypeId { get; set; }
        
		/// <summary>
        /// SaleCost:销售费用
        /// </summary>
        public decimal SaleCost { get; set; }
        
		/// <summary>
        /// DealDate:预计成交时间
        /// </summary>
        public DateTime DealDate { get; set; }
        
		/// <summary>
        /// IsToCustom:转换客户
        /// </summary>
        public int IsToCustom { get; set; }
        
		/// <summary>
        /// CompanyName:公司名称
        /// </summary>
        public string CompanyName { get; set; }
        
		/// <summary>
        /// CompanyNatureId:公司性质
        /// </summary>
        public string CompanyNatureId { get; set; }
        
		/// <summary>
        /// CompanyAddress:公司地址
        /// </summary>
        public string CompanyAddress { get; set; }
        
		/// <summary>
        /// CompanySite:公司网站
        /// </summary>
        public string CompanySite { get; set; }
        
		/// <summary>
        /// CompanyDesc:公司情况
        /// </summary>
        public string CompanyDesc { get; set; }
        
		/// <summary>
        /// Province:所在省份
        /// </summary>
        public string Province { get; set; }
        
		/// <summary>
        /// City:所在城市
        /// </summary>
        public string City { get; set; }
        
		/// <summary>
        /// Contacts:联系人
        /// </summary>
        public string Contacts { get; set; }
        
		/// <summary>
        /// Mobile:手机
        /// </summary>
        public string Mobile { get; set; }
        
		/// <summary>
        /// Tel:电话
        /// </summary>
        public string Tel { get; set; }
        
		/// <summary>
        /// Fax:传真
        /// </summary>
        public string Fax { get; set; }
        
		/// <summary>
        /// QQ:QQ
        /// </summary>
        public string QQ { get; set; }
        
		/// <summary>
        /// Email:Email
        /// </summary>
        public string Email { get; set; }
        
		/// <summary>
        /// Wechat:微信
        /// </summary>
        public string Wechat { get; set; }
        
		/// <summary>
        /// Hobby:爱好
        /// </summary>
        public string Hobby { get; set; }
        
		/// <summary>
        /// TraceUserId:跟进人员Id
        /// </summary>
        public string TraceUserId { get; set; }
        
		/// <summary>
        /// TraceUserName:跟进人员
        /// </summary>
        public string TraceUserName { get; set; }
        
		/// <summary>
        /// ChanceState:商机状态编码
        /// </summary>
        public int ChanceState { get; set; }
        
		/// <summary>
        /// AlertDateTime:提醒日期
        /// </summary>
        public DateTime AlertDateTime { get; set; }
        
		/// <summary>
        /// AlertState:提醒状态
        /// </summary>
        public int AlertState { get; set; }
        
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
