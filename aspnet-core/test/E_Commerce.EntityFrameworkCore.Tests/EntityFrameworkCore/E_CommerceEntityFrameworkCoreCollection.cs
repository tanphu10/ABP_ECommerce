using Xunit;

namespace E_Commerce.EntityFrameworkCore;

[CollectionDefinition(E_CommerceTestConsts.CollectionDefinitionName)]
public class E_CommerceEntityFrameworkCoreCollection : ICollectionFixture<E_CommerceEntityFrameworkCoreFixture>
{

}
