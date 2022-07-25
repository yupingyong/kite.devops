using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Kite.DevOps.Domain.Shared.Enums
{
    /// <summary>
    /// 容器编排版本
    /// </summary>
    public enum DockerComposeVersionEnum
    {
        /// <summary>
        /// V1版本
        /// </summary>
        [Display(Name ="V1")]
        V1=0,
        /// <summary>
        /// V2版本
        /// </summary>
        [Display(Name = "V2")]
        V2 =1
    }
}
