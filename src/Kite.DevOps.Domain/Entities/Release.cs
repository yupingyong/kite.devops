using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class Release : Entity<int>
    {
        /// <summary>
        /// 所属项目
        /// </summary>
        public int AppId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
