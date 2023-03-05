using Kite.DevOps.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class ReleaseParameter : Entity<int>
    {
        /// <summary>
        /// 所属发布项
        /// </summary>
        public int ReleaseId { get; set; }
        /// <summary>
        /// 参数名
        /// </summary>
        [MaxLength(128)]
        public string ParameterName { get; set; }
        /// <summary>
        /// 参数类型
        /// </summary>
        public ParameterTypeEnum ParameterType { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        [MaxLength(1024)]
        public string DefaultValue { get; set; }
        /// <summary>
        /// 参数描述
        /// </summary>
        [MaxLength(512)]
        public string Description { get; set; }
    }
}
