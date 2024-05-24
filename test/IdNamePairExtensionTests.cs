using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Extensions.IdNamePair.Tests;

[Collection("Collection")]
public class IdNamePairExtensionTests : FixturedUnitTest
{
    public IdNamePairExtensionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
