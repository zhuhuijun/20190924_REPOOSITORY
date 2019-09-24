/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Organize                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_OrganizeEntity : BaseEntity
    {  
        
		/// <summary>
        /// OrganizeId:机构主键
        /// </summary>
        public string OrganizeId { get; set; }
        
		/// <summary>
        /// Category:机构分类
        /// </summary>
        public int Category { get; set; }
        
		/// <summary>
        /// ParentId:父级主键
        /// </summary>
        public string ParentId { get; set; }
        
		/// <summary>
        /// EnCode:机构代码
        /// </summary>
        public string EnCode { get; set; }
        
		/// <summary>
        /// ShortName:机构简称
        /// </summary>
        public string ShortName { get; set; }
        
		/// <summary>
        /// FullName:机构名称
        /// </summary>
        public string FullName { get; set; }
        
		/// <summary>
        /// Nature:机构性质
        /// </summary>
        public string Nature { get; set; }
        
		/// <summary>
        /// OuterPhone:外线电话
        /// </summary>
        public string OuterPhone { get; set; }
        
		/// <summary>
        /// InnerPhone:内线电话
        /// </summary>
        public string InnerPhone { get; set; }
        
		/// <summary>
        /// Fax:传真
        /// </summary>
        public string Fax { get; set; }
        
		/// <summary>
        /// Postalcode:邮编
        /// </summary>
        public string Postalcode { get; set; }
        
		/// <summary>
        /// Email:电子邮箱
        /// </summary>
        public string Email { get; set; }
        
		/// <summary>
        /// ManagerId:负责人主键
        /// </summary>
        public string ManagerId { get; set; }
        
		/// <summary>
        /// Manager:负责人
        /// </summary>
        public string Manager { get; set; }
        
		/// <summary>
        /// ProvinceId:省主键
        /// </summary>
        public string ProvinceId { get; set; }
        
		/// <summary>
        /// CityId:市主键
        /// </summary>
        public string CityId { get; set; }
        
		/// <summary>
        /// CountyId:县/区主键
        /// </summary>
        public string CountyId { get; set; }
        
		/// <summary>
        /// Address:详细地址
        /// </summary>
        public string Address { get; set; }
        
		/// <summary>
        /// WebAddress:公司主页
        /// </summary>
        public string WebAddress { get; set; }
        
		/// <summary>
        /// FoundedTime:成立时间
        /// </summary>
        public DateTime FoundedTime { get; set; }
        
		/// <summary>
        /// BusinessScope:经营范围
        /// </summary>
        public string BusinessScope { get; set; }
        
		/// <summary>
        /// Layer:层
        /// </summary>
        public int Layer { get; set; }
        
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
