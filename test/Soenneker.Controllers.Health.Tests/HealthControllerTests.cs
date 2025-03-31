using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Controllers.Health.Tests;

[Collection("Collection")]
public class HealthControllerTests : FixturedUnitTest
{
    public HealthControllerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
