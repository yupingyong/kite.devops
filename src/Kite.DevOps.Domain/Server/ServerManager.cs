using Kite.DevOps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Mapster;
namespace Kite.DevOps.Domain.Server
{
    internal class ServerManager : DomainService,IServerManager
    {
        private readonly IRepository<ServerInfo> _repository;
        private readonly IRepository<ServerGroup> _groupRepository;
        public ServerManager(IRepository<ServerInfo> repository, IRepository<ServerGroup> groupRepository)
        {
            _repository = repository;
            _groupRepository = groupRepository;
        }


        public async Task<IQueryable<dynamic>> GetQueryAsync()
        {
            var query = (await _repository.GetQueryableAsync())
                .Join(await _groupRepository.GetQueryableAsync(), x => x.GroupId, y => y.Id, (x, y) => new 
                {
                    Id=x.Id,
                    ServerName=x.ServerName,
                    GroupId = x.GroupId,
                    GroupName=y.GroupName,
                    Host=x.Host,
                    Port=x.Port,
                    UserName=x.UserName,
                    Password=x.Password,
                    SystemTag=x.SystemTag,
                    DockerComposeVersion=x.DockerComposeVersion,
                    Remarks=x.Remarks
                });
            return query;
        }
    }
}
