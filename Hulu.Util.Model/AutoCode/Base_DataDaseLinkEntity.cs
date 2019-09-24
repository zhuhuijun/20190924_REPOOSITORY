/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_DataDaseLink                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_DataDaseLinkEntity : BaseEntity
    {  
        
		/// <summary>
        /// DatabaseLinkId:数据库连接主键
        /// </summary>
        public string DatabaseLinkId { get; set; }
        
		/// <summary>
        /// ServerAddress:服务器地址
        /// </summary>
        public string ServerAddress { get; set; }
        
		/// <summary>
        /// DBName:数据库名称
        /// </summary>
        public string DBName { get; set; }
        
		/// <summary>
        /// DBAlias:数据库别名
        /// </summary>
        public string DBAlias { get; set; }
        
		/// <summary>
        /// DbType:数据库类型
        /// </summary>
        public string DbType { get; set; }
        
		/// <summary>
        /// Version:数据库版本
        /// </summary>
        public string Version { get; set; }
        
		/// <summary>
        /// DbConnection:连接地址
        /// </summary>
        public string DbConnection { get; set; }
        
		/// <summary>
        /// DESEncrypt:连接地址是否加密
        /// </summary>
        public int DESEncrypt { get; set; }
        
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
