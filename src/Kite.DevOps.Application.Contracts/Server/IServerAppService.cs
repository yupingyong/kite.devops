using Kite.DevOps.Application.Contracts.Server.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Kite.DevOps.Application.Contracts.Server
{
    public interface IServerAppService : IApplicationService
    {
        /// <summary>
        /// 获取所有服务器列表
        /// </summary>
        /// <returns></returns>
        Task<KiteResult<List<ServerDto>>> GetListAsync();
        /// <summary>
        /// 获取服务器列表
        /// </summary>
        /// <param name="kw">关键字(服务器名、服务器主机名)</param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<KitePageResult<List<ServerDto>>> GetListAsync(Guid? groupId,string kw = "", int page = 1, int pageSize = 10);
        /// <summary>
        /// 获取服务器详情信息
        /// </summary>
        /// <param name="id">服务器ID</param>
        /// <returns></returns>
        Task<KiteResult<ServerDto>> GetAsync(Guid id);
        /// <summary>
        /// 删除服务器
        /// </summary>
        /// <param name="id">服务器ID</param>
        /// <returns></returns>
        Task<KiteResult> DeleteAsync(Guid id);
        /// <summary>
        /// 更新服务器
        /// </summary>
        /// <param name="updateServer"></param>
        /// <returns></returns>
        Task<KiteResult> UpdateAsync(UpdateServerDto updateServer);
        /// <summary>
        /// 创建服务器
        /// </summary>
        /// <param name="createServer"></param>
        /// <returns></returns>
        Task<KiteResult> CreateAsync(CreateServerDto createServer);
    }
}
