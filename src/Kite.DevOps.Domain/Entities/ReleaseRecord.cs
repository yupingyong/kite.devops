using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class ReleaseRecord : Entity<int>
    {
        public DateTime Created { get; set; }
    }
}
