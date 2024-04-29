using E_Commerce.Samples;
using Xunit;

namespace E_Commerce.EntityFrameworkCore.Applications;

[Collection(E_CommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<E_CommerceEntityFrameworkCoreTestModule>
{

}
