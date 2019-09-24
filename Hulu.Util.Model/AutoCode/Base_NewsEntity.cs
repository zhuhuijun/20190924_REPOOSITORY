/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 16:56:29                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_News                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_NewsEntity : BaseEntity
    {  
        
		/// <summary>
        /// NewsId:新闻主键
        /// </summary>
        public string NewsId { get; set; }
        
		/// <summary>
        /// TypeId:类型（1-新闻2-公告）
        /// </summary>
        public int TypeId { get; set; }
        
		/// <summary>
        /// ParentId:父级主键
        /// </summary>
        public string ParentId { get; set; }
        
		/// <summary>
        /// Category:所属类别
        /// </summary>
        public string Category { get; set; }
        
		/// <summary>
        /// FullHead:完整标题
        /// </summary>
        public string FullHead { get; set; }
        
		/// <summary>
        /// FullHeadColor:标题颜色
        /// </summary>
        public string FullHeadColor { get; set; }
        
		/// <summary>
        /// BriefHead:简略标题
        /// </summary>
        public string BriefHead { get; set; }
        
		/// <summary>
        /// AuthorName:作者
        /// </summary>
        public string AuthorName { get; set; }
        
		/// <summary>
        /// CompileName:编辑
        /// </summary>
        public string CompileName { get; set; }
        
		/// <summary>
        /// TagWord:Tag词
        /// </summary>
        public string TagWord { get; set; }
        
		/// <summary>
        /// Keyword:关键字
        /// </summary>
        public string Keyword { get; set; }
        
		/// <summary>
        /// SourceName:来源
        /// </summary>
        public string SourceName { get; set; }
        
		/// <summary>
        /// SourceAddress:来源地址
        /// </summary>
        public string SourceAddress { get; set; }
        
		/// <summary>
        /// NewsContent:新闻内容
        /// </summary>
        public string NewsContent { get; set; }
        
		/// <summary>
        /// PV:浏览量
        /// </summary>
        public int PV { get; set; }
        
		/// <summary>
        /// ReleaseTime:发布时间
        /// </summary>
        public DateTime ReleaseTime { get; set; }
        
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
