using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace E_Commerce.Data;

/* This is used if database provider does't define
 * IE_CommerceDbSchemaMigrator implementation.
 */
public class NullE_CommerceDbSchemaMigrator : IE_CommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
