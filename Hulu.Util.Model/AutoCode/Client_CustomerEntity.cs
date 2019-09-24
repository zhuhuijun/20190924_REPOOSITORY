/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Client_Customer                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Client_CustomerEntity : BaseEntity
    {  
        
		/// <summary>
        /// CustomerId:客户主键
        /// </summary>
        public string CustomerId { get; set; }
        
		/// <summary>
        /// EnCode:客户编号
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// FullName:客户名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// ShortName:客户简称
        /// </summary>
        public string ShortName { get; set; }
        
		/// <summary>
        /// CustIndustryId:客户行业
        /// </summary>
        public string CustIndustryId { get; set; }
        
		/// <summary>
        /// CustTypeId:客户类型
        /// </summary>
        public string CustTypeId { get; set; }
        
		/// <summary>
        /// CustLevelId:客户级别
        /// </summary>
        public string CustLevelId { get; set; }
        
		/// <summary>
        /// CustDegreeId:客户程度
        /// </summary>
        public string CustDegreeId { get; set; }
        
		/// <summary>
        /// Province:所在省份
        /// </summary>
        public string Province { get; set; }
        
		/// <summary>
        /// City:所在城市
        /// </summary>
        public string City { get; set; }
        
		/// <summary>
        /// Contact:联系人
        /// </summary>
        public string Contact { get; set; }
        
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
        /// LegalPerson:法人代表
        /// </summary>
        public string LegalPerson { get; set; }
        
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
        /// TraceUserId:跟进人员Id
        /// </summary>
        public string TraceUserId { get; set; }
        
		/// <summary>
        /// TraceUserName:跟进人员
        /// </summary>
        public string TraceUserName { get; set; }
        
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
