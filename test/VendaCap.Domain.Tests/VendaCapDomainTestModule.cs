using VendaCap.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VendaCap;

[DependsOn(
    typeof(VendaCapEntityFrameworkCoreTestModule)
    )]
public class VendaCapDomainTestModule : AbpModule
{

}
