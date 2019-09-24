using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************************************
* 命名空间: Hulu.Util.Attributes
*
* 功 能： N/A
* 类 名： PrimaryKeyAttribute
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2019/10/28 15:50:35 Hulu 初版
*
****************************************************************/
namespace Hulu.Util.Attributes
{
    /// <summary>
    /// 主键字段
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class PrimaryKeyAttribute : Attribute
    {
        public PrimaryKeyAttribute()
        {
        }

        public PrimaryKeyAttribute(string name)
        {
            _name = name;
        }
        private string _name;
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
