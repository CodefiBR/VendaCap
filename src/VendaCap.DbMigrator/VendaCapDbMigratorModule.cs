using VendaCap.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace VendaCap.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(VendaCapEntityFrameworkCoreModule),
    typeof(VendaCapApplicationContractsModule)
    )]
public class VendaCapDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
