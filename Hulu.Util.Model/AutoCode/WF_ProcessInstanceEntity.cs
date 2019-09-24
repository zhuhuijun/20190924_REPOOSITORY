/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_ProcessInstance                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_ProcessInstanceEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:主键Id
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// Code:实例编号
        /// </summary>
        public string Code { get; set; }
        
		/// <summary>
        /// CustomName:自定定义标题
        /// </summary>
        public string CustomName { get; set; }
        
		/// <summary>
        /// ActivityId:当前节点ID
        /// </summary>
        public string ActivityId { get; set; }
        
		/// <summary>
        /// ActivityType:当前节点类型
        /// </summary>
        public int ActivityType { get; set; }
        
		/// <summary>
        /// ActivityName:当前节点名称
        /// </summary>
        public string ActivityName { get; set; }
        
		/// <summary>
        /// PreviousId:上一个节点
        /// </summary>
        public string PreviousId { get; set; }
        
		/// <summary>
        /// ProcessSchemeId:流程实例模板Id
        /// </summary>
        public string ProcessSchemeId { get; set; }
        
		/// <summary>
        /// SchemeType:模板类型
        /// </summary>
        public string SchemeType { get; set; }
        
		/// <summary>
        /// FrmType:表单类型
        /// </summary>
        public int FrmType { get; set; }
        
		/// <summary>
        /// EnabledMark:有效标志（0正常，1暂停）
        /// </summary>
        public int EnabledMark { get; set; }
        
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
        /// wfLevel:重要等级
        /// </summary>
        public int wfLevel { get; set; }
        
		/// <summary>
        /// Description:备注
        /// </summary>
        public string Description { get; set; }
        
		/// <summary>
        /// isFinish:
        /// </summary>
        public int isFinish { get; set; }
        
		/// <summary>
        /// MakerList:执行人
        /// </summary>
        public string MakerList { get; set; }
   

    }
}
