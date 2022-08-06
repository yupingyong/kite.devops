using Kite.DevOps.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kite.DevOps.Application.Contracts.Server.Dtos
{
    public class UpdateServerDto
    {
        /// <summary>
        /// 服务器ID
        /// </summary>
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// 服务器名
        /// </summary>
        [Required]
        public string ServerName { get; set; }
        /// <summary>
        /// 所属服务器组
        /// </summary>
        [Required]
        public Guid GroupId { get; set; }
        /// <summary>
        /// 服务器主机
        /// </summary>
        [Required]
        public string Host { get; set; }
        /// <summary>
        /// 服务器远程访问端口号
        /// </summary>
        [Required]
        public int Port { get; set; }
        /// <summary>
        /// 服务器登录用户名
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 服务器登录密码
        /// </summary>
        [Required]
        public string Password { get; set; }
        /// <summary>
        /// 系统标签
        /// </summary>
        [Required]
        public string SystemTag { get; set; }
        /// <summary>
        /// 容器编排版本
        /// </summary>
        [Required]
        public DockerComposeVersionEnum DockerComposeVersion { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remarks { get; set; }
    }
}
