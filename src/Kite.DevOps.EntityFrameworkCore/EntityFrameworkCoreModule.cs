﻿using Microsoft.Extensions.DependencyInjection;
using Kite.DevOps.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;
using Volo.Abp;
using Microsoft.EntityFrameworkCore;

namespace Kite.DevOps.EntityFrameworkCore
{
    [DependsOn(
        typeof(DomainModule),
        typeof(AbpEntityFrameworkCoreSqliteModule)
        )]
    public class EntityFrameworkCoreModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlite();
            });
            context.Services.AddAbpDbContext<KiteDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
        }
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var dbContext = context.ServiceProvider.GetService<KiteDbContext>();
            if (dbContext != null && dbContext.Database.GetMigrations().Any())
            {
                dbContext.Database.Migrate();
            }
        }
    }
}
