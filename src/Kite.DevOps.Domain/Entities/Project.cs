using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class Project : Entity<int>
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        [MaxLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }

    }
}
