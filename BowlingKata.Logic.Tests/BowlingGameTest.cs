using Xunit;

namespace BowlingKata.Logic.Tests;

public class BowlingGameTest
{
    [Fact]
    public void AllStrikes()
    {
        Assert.Equal(BowlingGame.Evaluate("X X X X X X X X X X X X"), 300);
    }

    [Fact]
    public void OnePinPerRoll()
    {
        Assert.Equal(BowlingGame.Evaluate("1- 1- 1- 1- 1- 1- 1- 1- 1- 1-"), 10);
    }
}