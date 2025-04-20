using Northwind.Samples;
using Xunit;

namespace Northwind.EntityFrameworkCore.Domains;

[Collection(NorthwindTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NorthwindEntityFrameworkCoreTestModule>
{

}
