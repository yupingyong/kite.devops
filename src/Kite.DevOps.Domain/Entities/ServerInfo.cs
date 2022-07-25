using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using Kite.DevOps.Domain.Shared.Enums;

namespace Kite.DevOps.Domain.Entities
{
    /// <summary>
    /// 服务器信息表
    /// </summary>
    public class ServerInfo : Entity<Guid>
    {
        public ServerInfo() { }
        public ServerInfo(Guid id) : base(id)
        {
        }
        /// <summary>
        /// 服务器名
        /// </summary>
        [MaxLength(512)]
        public string ServerName { get; set; }
        /// <summary>
        /// 所属服务器组
        /// </summary>
        public Guid GroupId { get; set; }
        /// <summary>
        /// 服务器主机
        /// </summary>
        [MaxLength(128)]
        public string Host { get; set; }
        /// <summary>
        /// 服务器远程访问端口号
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 服务器登录用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 服务器登录密码
        /// </summary>
        [MaxLength(128)]
        public string Password { get; set; }
        /// <summary>
        /// 系统标签
        /// </summary>
        [MaxLength(64)]
        public string SystemTag { get; set; }
        /// <summary>
        /// 容器编排版本
        /// </summary>

        public DockerComposeVersionEnum DockerComposeVersion { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
