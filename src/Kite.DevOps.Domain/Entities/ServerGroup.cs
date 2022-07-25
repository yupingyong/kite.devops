using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
namespace Kite.DevOps.Domain.Entities
{
    /// <summary>
    /// 服务器组信息表
    /// </summary>
    public class ServerGroup : Entity<Guid>
    {
        public ServerGroup() { }
        public ServerGroup(Guid id) : base(id)
        {
        }
        /// <summary>
        /// 组名称
        /// </summary>
        [MaxLength(128)]
        public string GroupName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
