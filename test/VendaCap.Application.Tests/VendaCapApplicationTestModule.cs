using Volo.Abp.Modularity;

namespace VendaCap;

[DependsOn(
    typeof(VendaCapApplicationModule),
    typeof(VendaCapDomainTestModule)
    )]
public class VendaCapApplicationTestModule : AbpModule
{

}
