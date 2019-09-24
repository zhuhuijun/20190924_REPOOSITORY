/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：WF_ProcessTransitionHistory                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class WF_ProcessTransitionHistoryEntity : BaseEntity
    {  
        
		/// <summary>
        /// Id:
        /// </summary>
        public string Id { get; set; }
        
		/// <summary>
        /// ProcessId:实例进程Id
        /// </summary>
        public string ProcessId { get; set; }
        
		/// <summary>
        /// fromNodeId:开始节点Id
        /// </summary>
        public string fromNodeId { get; set; }
        
		/// <summary>
        /// fromNodeType:
        /// </summary>
        public int fromNodeType { get; set; }
        
		/// <summary>
        /// fromNodeName:开始节点名称
        /// </summary>
        public string fromNodeName { get; set; }
        
		/// <summary>
        /// toNodeId:结束节点Id
        /// </summary>
        public string toNodeId { get; set; }
        
		/// <summary>
        /// toNodeType:
        /// </summary>
        public int toNodeType { get; set; }
        
		/// <summary>
        /// toNodeName:结束节点名称
        /// </summary>
        public string toNodeName { get; set; }
        
		/// <summary>
        /// TransitionSate:转化状态
        /// </summary>
        public int TransitionSate { get; set; }
        
		/// <summary>
        /// isFinish:是否结束
        /// </summary>
        public int isFinish { get; set; }
        
		/// <summary>
        /// CreateDate:转化时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        
		/// <summary>
        /// CreateUserId:执行人
        /// </summary>
        public string CreateUserId { get; set; }
        
		/// <summary>
        /// CreateUserName:
        /// </summary>
        public string CreateUserName { get; set; }
   

    }
}
