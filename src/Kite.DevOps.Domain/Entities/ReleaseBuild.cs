using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Kite.DevOps.Domain.Entities
{
    public class ReleaseBuild : Entity<int>
    {
        /// <summary>
        /// 所属发布项
        /// </summary>
        public int ReleaseId { get; set; }
        /// <summary>
        /// 构建标题
        /// </summary>
        [MaxLength(256)]
        public string Title { get; set; }
        /// <summary>
        /// 脚本内容
        /// </summary>
        public string Contents { get; set; }
        /// <summary>
        /// 构建顺序
        /// </summary>
        public int SortCount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
