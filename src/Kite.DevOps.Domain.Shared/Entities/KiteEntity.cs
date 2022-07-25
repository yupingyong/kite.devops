using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Shared.Entities
{
    /// <summary>
    /// 分布式Abp Vnext推荐使用GUID作为主键
    /// </summary>
    public class KiteEntity:Entity<Guid>
    {

    }
}
