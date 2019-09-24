/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_FileInfo                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_FileInfoEntity : BaseEntity
    {  
        
		/// <summary>
        /// FileId:文件主键
        /// </summary>
        public string FileId { get; set; }
        
		/// <summary>
        /// FolderId:文件夹主键
        /// </summary>
        public string FolderId { get; set; }
        
		/// <summary>
        /// FileName:文件名称
        /// </summary>
        public string FileName { get; set; }
        
		/// <summary>
        /// FilePath:文件路径
        /// </summary>
        public string FilePath { get; set; }
        
		/// <summary>
        /// FileSize:文件大小
        /// </summary>
        public string FileSize { get; set; }
        
		/// <summary>
        /// FileExtensions:文件后缀
        /// </summary>
        public string FileExtensions { get; set; }
        
		/// <summary>
        /// FileType:文件类型
        /// </summary>
        public string FileType { get; set; }
        
		/// <summary>
        /// IsShare:共享
        /// </summary>
        public int IsShare { get; set; }
        
		/// <summary>
        /// ShareLink:共享连接
        /// </summary>
        public string ShareLink { get; set; }
        
		/// <summary>
        /// ShareCode:共享提取码
        /// </summary>
        public int ShareCode { get; set; }
        
		/// <summary>
        /// ShareTime:共享日期
        /// </summary>
        public DateTime ShareTime { get; set; }
        
		/// <summary>
        /// DownloadCount:下载次数
        /// </summary>
        public int DownloadCount { get; set; }
        
		/// <summary>
        /// IsTop:置顶
        /// </summary>
        public int IsTop { get; set; }
        
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
