/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：IM_UserGroup                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class IM_UserGroupEntity : BaseEntity
    {  
        
		/// <summary>
        /// UserGroupId:用户群组主键
        /// </summary>
        public string UserGroupId { get; set; }
        
		/// <summary>
        /// GroupId:群组主键
        /// </summary>
        public string GroupId { get; set; }
        
		/// <summary>
        /// UserId:用户主键
        /// </summary>
        public string UserId { get; set; }
        
		/// <summary>
        /// CreateDate:创建时间
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
