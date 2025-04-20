using Northwind.Samples;
using Xunit;

namespace Northwind.EntityFrameworkCore.Applications;

[Collection(NorthwindTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NorthwindEntityFrameworkCoreTestModule>
{

}
