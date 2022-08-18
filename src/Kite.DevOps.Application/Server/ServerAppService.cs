using Kite.DevOps.Application.Contracts.Server;
using Kite.DevOps.Application.Contracts.Server.Dtos;
using Kite.DevOps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Mapster;
using Kite.DevOps.Domain.Server;

namespace Kite.DevOps.Application.Server
{
    public class ServerAppService : BaseApplicationService, IServerAppService
    {
        private readonly IRepository<ServerInfo> _repository;
        private readonly IRepository<ServerGroup> _groupRepository;
        private readonly IServerManager _serverManager;

        public ServerAppService(IRepository<ServerInfo> repository, IRepository<ServerGroup> groupRepository, IServerManager serverManager)
        {
            _repository = repository;
            _groupRepository = groupRepository;
            _serverManager = serverManager;
        }

        public async Task<KiteResult> CreateAsync(CreateServerDto createServer)
        {
            var model = new ServerInfo()
            {
                Created = DateTime.Now
            };
            TypeAdapter.Adapt(createServer, model);
            await _repository.InsertAsync(model);
            return Ok();
        }

        public async Task<KiteResult> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(x => x.Id == id);
            return Ok();
        }

        public async Task<KiteResult<ServerDto>> GetAsync(int id)
        {
            var query = await _serverManager.GetQueryAsync<ServerDto>();
            return Ok(query.FirstOrDefault(x => x.Id == id));
        }

        public async Task<KitePageResult<List<ServerDto>>> GetListAsync(int? groupId, string kw = "", int page = 1, int pageSize = 10)
        {
            var query = (await _serverManager.GetQueryAsync<ServerDto>())
                .WhereIf(groupId.HasValue, x => x.GroupId == groupId)
                .WhereIf(!string.IsNullOrEmpty(kw) && kw != "", x => x.ServerName.Contains(kw) || x.Host.Contains(kw));
            var count = query.Count();
            var result = query.OrderByDescending(x => x.Created)
                .PageBy((page - 1) * pageSize, pageSize)
                .ToList();
            return Ok(result, count);
        }

        public async Task<KiteResult<List<ServerDto>>> GetListAsync()
        {
            var result = (await _serverManager.GetQueryAsync<ServerDto>())
                .OrderByDescending(x => x.Created)
                .ToList();
            return Ok(result);
        }

        public async Task<KiteResult> UpdateAsync(UpdateServerDto updateServer)
        {
            var model = await _repository.FirstOrDefaultAsync(x => x.Id == updateServer.Id);
            TypeAdapter.Adapt(updateServer, model);
            await _repository.UpdateAsync(model);
            return Ok();
        }
    }
}
