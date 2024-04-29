using Volo.Abp.Modularity;

namespace E_Commerce;

public abstract class E_CommerceApplicationTestBase<TStartupModule> : E_CommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
