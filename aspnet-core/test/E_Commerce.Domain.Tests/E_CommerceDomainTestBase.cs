using Volo.Abp.Modularity;

namespace E_Commerce;

/* Inherit from this class for your domain layer tests. */
public abstract class E_CommerceDomainTestBase<TStartupModule> : E_CommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
