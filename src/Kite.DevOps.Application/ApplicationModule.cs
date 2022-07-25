using Kite.DevOps.Application.Contracts;
using Kite.DevOps.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace Kite.DevOps.Application
{
    [DependsOn(
        typeof(DomainModule),
        typeof(ApplicationContractsModule)
        )]
    public class ApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //在此处注入依赖项
        }
    }
}
