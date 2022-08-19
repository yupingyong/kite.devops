using Kite.DevOps.Domain.Shared.Enums;
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
        /// 发布名称
        /// </summary>
        [MaxLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        [MaxLength(1024)]
        public string Remark { get; set; }
        /// <summary>
        /// 是否开启发布
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// 所属项目
        /// </summary>
        public int AppId { get; set; }
        /// <summary>
        /// 容器镜像名
        /// </summary>
        [MaxLength(128)]
        public string ImageName { get; set; }
        /// <summary>
        /// 镜像标签类型
        /// </summary>
        public ImageTagTypeEnum ImageTagType { get; set; }
        /// <summary>
        /// 镜像标签
        /// </summary>
        [MaxLength(64)]
        public string ImageTag { get; set; }
        /// <summary>
        /// 容器名
        /// </summary>
        [MaxLength(128)]
        public string DockerName { get; set; }
       
        /// <summary>
        /// Git配置项ID
        /// </summary>
        public int GitId { get; set; }
        /// <summary>
        /// Git仓库地址
        /// </summary>
        [MaxLength(1024)]
        public string GitRepositoryUrl { get; set; }
        /// <summary>
        /// Git分支
        /// </summary>
        [MaxLength(128)]
        public string GitBranch { get; set; }
        /// <summary>
        /// Dockerfile路径
        /// </summary>
        public string DockerfilePath { get; set; }
        /// <summary>
        /// DockerCompose文件路径
        /// </summary>
        public string DockerComposeFilePath { get; set; }
        /// <summary>
        /// 关联服务器ID
        /// </summary>
        public int ServerId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
