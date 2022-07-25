using Kite.DevOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace Kite.DevOps.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class KiteDbContext : AbpDbContext<KiteDbContext>
    {

        #region Entities from the modules
        public DbSet<ServerInfo> ServerInfos { get; set; }
        public DbSet<ServerGroup> ServerGroups { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        #endregion
        
        public KiteDbContext(DbContextOptions<KiteDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
