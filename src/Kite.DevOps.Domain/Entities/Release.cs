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
        /// 发布标题
        /// </summary>
        [MaxLength(128)]
        public string Title { get; set; }
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
        /// 所属应用服务
        /// </summary>
        public int AppId { get; set; }
       
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
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
