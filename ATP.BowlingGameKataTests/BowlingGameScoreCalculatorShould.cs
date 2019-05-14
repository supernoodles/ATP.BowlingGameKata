namespace ATP.BowlingGameKataTests
{
    using BowlingGameKata;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class BowlingGameScoreCalculatorShould
    {
        [Test]
        public void Return0_GivenAllMisses()
        {
            var calculator = new BowlingGameScoreCalculator();
            var result = calculator.ScoreGame("--|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(0);
        }

        [Test]
        public void Return1_Given1PinOnFirstThrowOnFirstFrame()
        {
            var calculator = new BowlingGameScoreCalculator();
            var result = calculator.ScoreGame("1-|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(1);
        }
    }
}

