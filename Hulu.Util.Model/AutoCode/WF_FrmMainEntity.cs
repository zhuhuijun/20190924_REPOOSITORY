/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_FrmMain                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_FrmMainEntity : BaseEntity
    {  
        
		/// <summary>
        /// FrmMainId:表单模板Id
        /// </summary>
        public string FrmMainId { get; set; }
        
		/// <summary>
        /// FrmCode:表单编号
        /// </summary>
        public string FrmCode { get; set; }
        
		/// <summary>
        /// FrmName:表单名称
        /// </summary>
        public string FrmName { get; set; }
        
		/// <summary>
        /// FrmType:表单分类
        /// </summary>
        public string FrmType { get; set; }
        
		/// <summary>
        /// FrmDbId:数据库Id
        /// </summary>
        public string FrmDbId { get; set; }
        
		/// <summary>
        /// FrmTable:数据表
        /// </summary>
        public string FrmTable { get; set; }
        
		/// <summary>
        /// isSystemTable:0不建表,1建表
        /// </summary>
        public int isSystemTable { get; set; }
        
		/// <summary>
        /// FrmTableId:关联表主键
        /// </summary>
        public string FrmTableId { get; set; }
        
		/// <summary>
        /// FrmContent:表单内容
        /// </summary>
        public string FrmContent { get; set; }
        
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
