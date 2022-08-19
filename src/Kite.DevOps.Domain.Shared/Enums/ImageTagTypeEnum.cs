using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kite.DevOps.Domain.Shared.Enums
{
    /// <summary>
    /// 镜像标签类型
    /// </summary>
    public enum ImageTagTypeEnum
    {
        /// <summary>
        /// 默认(自定义输入)
        /// </summary>
        [Display(Name = "默认(自定义输入)")]
        Default=0,
        /// <summary>
        /// 日期时间
        /// </summary>
        [Display(Name = "日期时间")]
        DateTime =1
    }
}
