using E_Commerce.Samples;
using Xunit;

namespace E_Commerce.EntityFrameworkCore.Domains;

[Collection(E_CommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<E_CommerceEntityFrameworkCoreTestModule>
{

}
