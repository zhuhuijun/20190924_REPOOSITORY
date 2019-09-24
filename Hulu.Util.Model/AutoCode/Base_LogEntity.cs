/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：无                                                    
*│　作    者：zhuhj                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-09-24 18:08:42                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间：Hulu.Util.Model                             
*│　类    名：Base_Log                                     
*└──────────────────────────────────────────────────────────────┘
*/

using System;
namespace Hulu.Util.Model
{	
    public partial class Base_LogEntity : BaseEntity
    {  
        
		/// <summary>
        /// LogId:日志主键
        /// </summary>
        public string LogId { get; set; }
        
		/// <summary>
        /// CategoryId:分类Id 1-登陆2-访问3-操作4-异常
        /// </summary>
        public int CategoryId { get; set; }
        
		/// <summary>
        /// SourceObjectId:来源对象主键
        /// </summary>
        public string SourceObjectId { get; set; }
        
		/// <summary>
        /// SourceContentJson:来源日志内容
        /// </summary>
        public string SourceContentJson { get; set; }
        
		/// <summary>
        /// OperateTime:操作时间
        /// </summary>
        public DateTime OperateTime { get; set; }
        
		/// <summary>
        /// OperateUserId:操作用户Id
        /// </summary>
        public string OperateUserId { get; set; }
        
		/// <summary>
        /// OperateAccount:操作用户
        /// </summary>
        public string OperateAccount { get; set; }
        
		/// <summary>
        /// OperateTypeId:操作类型Id
        /// </summary>
        public string OperateTypeId { get; set; }
        
		/// <summary>
        /// OperateType:操作类型
        /// </summary>
        public string OperateType { get; set; }
        
		/// <summary>
        /// ModuleId:系统功能主键
        /// </summary>
        public string ModuleId { get; set; }
        
		/// <summary>
        /// Module:系统功能
        /// </summary>
        public string Module { get; set; }
        
		/// <summary>
        /// IPAddress:IP地址
        /// </summary>
        public string IPAddress { get; set; }
        
		/// <summary>
        /// IPAddressName:IP地址所在城市
        /// </summary>
        public string IPAddressName { get; set; }
        
		/// <summary>
        /// Host:主机
        /// </summary>
        public string Host { get; set; }
        
		/// <summary>
        /// Browser:浏览器
        /// </summary>
        public string Browser { get; set; }
        
		/// <summary>
        /// ExecuteResult:执行结果状态
        /// </summary>
        public int ExecuteResult { get; set; }
        
		/// <summary>
        /// ExecuteResultJson:执行结果信息
        /// </summary>
        public string ExecuteResultJson { get; set; }
        
		/// <summary>
        /// Description:备注
        /// </summary>
        public string Description { get; set; }
        
		/// <summary>
        /// DeleteMark:删除标记
        /// </summary>
        public int DeleteMark { get; set; }
        
		/// <summary>
        /// EnabledMark:有效标志
        /// </summary>
        public int EnabledMark { get; set; }
   

    }
}
