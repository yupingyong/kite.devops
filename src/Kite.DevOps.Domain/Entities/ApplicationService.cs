using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class ApplicationService : Entity<int>
    {
        /// <summary>
        /// 所属项目
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// 应用服务名
        /// </summary>
        [MaxLength(128)]
        public string AppServiceName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
