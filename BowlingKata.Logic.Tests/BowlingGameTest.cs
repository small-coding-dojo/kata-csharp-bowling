using Xunit;

namespace BowlingKata.Logic.Tests;

public class BowlingGameTest
{
    [Fact]
    public void GameWithZerosReturnsZero() => Assert.Equal(0, BowlingGame.Game("-- -- -- -- -- -- -- -- -- --"));

    [Fact]
    public void GameWithOnePinInFirstThrowReturnsOne() => Assert.Equal(1, BowlingGame.Game("1- -- -- -- -- -- -- -- -- --"));


    [Fact]
    public void GameWithTwoPinsInFirstThrowReturnsTwo() => Assert.Equal(2, BowlingGame.Game("2- -- -- -- -- -- -- -- -- --"));

}
