using Xunit;

namespace BowlingKata.Logic.Tests;

public class BowlingGameTest
{
    [Fact]
    public void GameWithZerosReturnsZero() => Assert.Equal(0, BowlingGame.Game("-- -- -- -- -- -- -- -- -- --"));

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(9)]
    public void GameWithHitPinsInFirstThrowReturnsCorrespondingResult(int hitPins) =>
        Assert.Equal(hitPins, BowlingGame.Game($"{hitPins}- -- -- -- -- -- -- -- -- --"));

    [Theory]
    [InlineData(1)]
    public void GameWithHitPinsInSecondThrowReturnsCorrespondingResult(int hitPins) =>
        Assert.Equal(hitPins, BowlingGame.Game($"-{hitPins} -- -- -- -- -- -- -- -- --"));
}