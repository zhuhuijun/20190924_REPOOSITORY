/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Wechat_UserRelation                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Wechat_UserRelationEntity : BaseEntity
    {  
        
		/// <summary>
        /// UserRelationId:用户对应关系主键
        /// </summary>
        public string UserRelationId { get; set; }
        
		/// <summary>
        /// DeptId:部门Id
        /// </summary>
        public string DeptId { get; set; }
        
		/// <summary>
        /// DeptName:部门名称
        /// </summary>
        public string DeptName { get; set; }
        
		/// <summary>
        /// WeChatDeptId:微信部门ID
        /// </summary>
        public int WeChatDeptId { get; set; }
        
		/// <summary>
        /// UserId:用户Id
        /// </summary>
        public string UserId { get; set; }
        
		/// <summary>
        /// SyncState:同步状态
        /// </summary>
        public string SyncState { get; set; }
        
		/// <summary>
        /// SyncLog:同步日志
        /// </summary>
        public string SyncLog { get; set; }
        
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
   

    }
}
