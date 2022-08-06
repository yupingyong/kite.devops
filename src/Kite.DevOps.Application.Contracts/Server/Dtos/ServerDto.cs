using Kite.DevOps.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kite.DevOps.Application.Contracts.Server.Dtos
{
    public class ServerDto
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 服务器名
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// 所属服务器组
        /// </summary>
        public Guid GroupId { get; set; }
        /// <summary>
        /// 服务器组名
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 服务器主机
        /// </summary>
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
        public string Password { get; set; }
        /// <summary>
        /// 系统标签
        /// </summary>
        public string SystemTag { get; set; }
        /// <summary>
        /// 容器编排版本
        /// </summary>

        public DockerComposeVersionEnum DockerComposeVersion { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
