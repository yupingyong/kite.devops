using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class GitConfigure : Entity<int>
    {
        /// <summary>
        /// 配置标题
        /// </summary>
        [MaxLength(128)]
        public string Title { get; set; }
        /// <summary>
        /// 授权访问用户名
        /// </summary>
        [MaxLength(128)]
        public string UserName { get; set; }
        /// <summary>
        /// 授权访问密码
        /// </summary>
        [MaxLength(64)]
        public string Password { get; set; }
    }
}
