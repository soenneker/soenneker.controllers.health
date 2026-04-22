using Soenneker.Tests.HostedUnit;

namespace Soenneker.Controllers.Health.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class HealthControllerTests : HostedUnitTest
{
    public HealthControllerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
