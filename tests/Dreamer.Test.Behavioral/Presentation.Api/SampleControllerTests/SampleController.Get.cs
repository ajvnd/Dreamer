using TestStack.BDDfy;
using Xunit;

namespace Dreamer.Test.Behavioral.Presentation.Api.SampleControllerTests;

public class SampleControllerTest
{
    private void UserWantsToGetASample()
    {
    }

    private void UserGetsASample()
    {
    }

    private void UserNowShouldHaveASample()
    {
    }

    [Fact]
    public void Get()
    {
        this.Given(_ => UserWantsToGetASample())
            .Given(_ => UserGetsASample())
            .Given(_ => UserNowShouldHaveASample())
            .BDDfy();
    }
}