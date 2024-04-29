using System.Threading.Tasks;

namespace E_Commerce.Data;

public interface IE_CommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
