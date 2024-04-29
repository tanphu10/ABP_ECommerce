using Volo.Abp.Modularity;

namespace E_Commerce;

[DependsOn(
    typeof(E_CommerceDomainModule),
    typeof(E_CommerceTestBaseModule)
)]
public class E_CommerceDomainTestModule : AbpModule
{

}
