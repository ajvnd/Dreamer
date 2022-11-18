using TestStack.BDDfy;
using Xunit;

namespace Dreamer.Test.Behavioral.Presentation.Api.SampleControllerTests;

public class SampleControllerTest
{
    private void UserWantsToGetAnItem()
    {
    }

    private void UserGetsAnItem()
    {
    }

    private void UserNowShouldHaveAnItem()
    {
    }

    [Fact]
    public void Get()
    {
        this.Given(_ => UserWantsToGetAnItem())
            .Given(_ => UserGetsAnItem())
            .Given(_ => UserNowShouldHaveAnItem())
            .BDDfy();
    }
}