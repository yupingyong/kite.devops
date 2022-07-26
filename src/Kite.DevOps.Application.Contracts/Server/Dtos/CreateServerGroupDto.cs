using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kite.DevOps.Application.Contracts.Server.Dtos
{
    public class CreateServerGroupDto
    {
        /// <summary>
        /// 组名称
        /// </summary>
        [Required]
        public string GroupName { get; set; }
    }
}
