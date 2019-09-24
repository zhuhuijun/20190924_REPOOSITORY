/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_SchemeInfo                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_SchemeInfoEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:流程信息Id
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// SchemeCode:流程编号
        /// </summary>
        public string SchemeCode { get; set; }
        
		/// <summary>
        /// SchemeName:流程名称
        /// </summary>
        public string SchemeName { get; set; }
        
		/// <summary>
        /// SchemeType:流程分类
        /// </summary>
        public string SchemeType { get; set; }
        
		/// <summary>
        /// SchemeVersion:流程内容版本号
        /// </summary>
        public string SchemeVersion { get; set; }
        
		/// <summary>
        /// SchemeCanUser:
        /// </summary>
        public string SchemeCanUser { get; set; }
        
		/// <summary>
        /// FrmType:表单类型
        /// </summary>
        public int FrmType { get; set; }
        
		/// <summary>
        /// AuthorizeType:权限类型0所有人，1指定成员
        /// </summary>
        public int AuthorizeType { get; set; }
        
		/// <summary>
        /// SortCode:排序码
        /// </summary>
        public int SortCode { get; set; }
        
		/// <summary>
        /// DeleteMark:删除标记
        /// </summary>
        public int DeleteMark { get; set; }
        
		/// <summary>
        /// EnabledMark:有效
        /// </summary>
        public int EnabledMark { get; set; }
        
		/// <summary>
        /// Description:备注
        /// </summary>
        public string Description { get; set; }
        
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
        
		/// <summary>
        /// ModifyDate:修改时间
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
