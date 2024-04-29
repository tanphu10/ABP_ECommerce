using Volo.Abp.Modularity;

namespace E_Commerce;

[DependsOn(
    typeof(E_CommerceApplicationModule),
    typeof(E_CommerceDomainTestModule)
)]
public class E_CommerceApplicationTestModule : AbpModule
{

}
