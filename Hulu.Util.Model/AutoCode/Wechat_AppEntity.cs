/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Wechat_App                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Wechat_AppEntity : BaseEntity
    {  
        
		/// <summary>
        /// AppId:应用主键
        /// </summary>
        public string AppId { get; set; }
        
		/// <summary>
        /// AppLogo:应用Logo
        /// </summary>
        public string AppLogo { get; set; }
        
		/// <summary>
        /// AppName:应用名称
        /// </summary>
        public string AppName { get; set; }
        
		/// <summary>
        /// AppType:应用类型
        /// </summary>
        public int AppType { get; set; }
        
		/// <summary>
        /// Description:应用介绍
        /// </summary>
        public string Description { get; set; }
        
		/// <summary>
        /// AppUrl:应用主页
        /// </summary>
        public string AppUrl { get; set; }
        
		/// <summary>
        /// RedirectDomain:可信域名
        /// </summary>
        public string RedirectDomain { get; set; }
        
		/// <summary>
        /// MenuJson:应用菜单
        /// </summary>
        public string MenuJson { get; set; }
        
		/// <summary>
        /// IsReportUser:是否接收用户变更通知
        /// </summary>
        public int IsReportUser { get; set; }
        
		/// <summary>
        /// IsReportenter:是否上报用户进入应用事件
        /// </summary>
        public int IsReportenter { get; set; }
        
		/// <summary>
        /// DeleteMark:删除标记
        /// </summary>
        public int DeleteMark { get; set; }
        
		/// <summary>
        /// EnabledMark:有效标志
        /// </summary>
        public int EnabledMark { get; set; }
        
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
