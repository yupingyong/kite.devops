using Kite.DevOps.Application.Contracts.Server.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Kite.DevOps.Application.Contracts.Server
{
    public interface IServerGroupAppService:IApplicationService
    {
        /// <summary>
        /// 获取服务器组列表
        /// </summary>
        /// <returns></returns>
        Task<KiteResult<List<ServerGroupDto>>> GetListAsync();
        /// <summary>
        /// 获取服务器组详情信息
        /// </summary>
        /// <param name="id">组ID</param>
        /// <returns></returns>
        Task<KiteResult<ServerGroupDto>> GetAsync(int id);
        /// <summary>
        /// 删除服务器组
        /// </summary>
        /// <param name="id">组ID</param>
        /// <returns></returns>
        Task<KiteResult> DeleteAsync(int id);
        /// <summary>
        /// 更新服务器组信息
        /// </summary>
        /// <param name="updateGroup"></param>
        /// <returns></returns>
        Task<KiteResult> UpdateAsync(UpdateServerGroupDto updateGroup);
        /// <summary>
        /// 创建服务器组
        /// </summary>
        /// <param name="createGroup"></param>
        /// <returns></returns>
        Task<KiteResult> CreateAsync(CreateServerGroupDto createGroup);
    }
}
