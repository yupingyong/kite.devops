using Kite.DevOps.Application.Contracts.Server;
using Kite.DevOps.Application.Contracts.Server.Dtos;
using Kite.DevOps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mapster;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Kite.DevOps.Application.Server
{
    public class ServerGroupAppService : BaseApplicationService, IServerGroupAppService
    {
        private readonly IRepository<ServerGroup> _repository;

        public ServerGroupAppService(IRepository<ServerGroup> repository)
        {
            _repository = repository;
        }

        public async Task<KiteResult> CreateAsync(CreateServerGroupDto createGroup)
        {
            var model = new ServerGroup(GuidGenerator.Create())
            {
                Created = DateTime.Now,
                GroupName = createGroup.GroupName
            };
            await _repository.InsertAsync(model);
            return Ok();
        }

        public async Task<KiteResult> DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(x=>x.Id==id);
            return Ok();
        }

        public async Task<KiteResult<ServerGroupDto>> GetAsync(Guid id)
        {
            var result = (await _repository.GetQueryableAsync())
                .Where(x => x.Id == id)
                .ProjectToType<ServerGroupDto>()
                .FirstOrDefault();
            return Ok(result);
        }

        public async Task<KiteResult<List<ServerGroupDto>>> GetListAsync()
        {
            var result = (await _repository.GetQueryableAsync())
                .OrderByDescending(x => x.Created)
                .ProjectToType<ServerGroupDto>()
                .ToList();
            return Ok(result);
        }

        public async Task<KiteResult> UpdateAsync(UpdateServerGroupDto updateGroup)
        {
            var model = await _repository.FirstOrDefaultAsync(x=>x.Id==updateGroup.Id);
            if (model == null)
            {
                throw new ArgumentNullException("服务器组信息不存在");
            }
            model.GroupName=updateGroup.GroupName;
            await _repository.UpdateAsync(model);
            return Ok();
        }
    }
}
