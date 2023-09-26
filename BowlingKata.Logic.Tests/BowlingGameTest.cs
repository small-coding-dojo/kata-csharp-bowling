using Xunit;

namespace BowlingKata.Logic.Tests;

public class BowlingGameTest
{
    [Fact]
    public void GameWithZerosReturnsZero() => Assert.Equal(0, BowlingGame.Game("-- -- -- -- -- -- -- -- -- --"));
}
