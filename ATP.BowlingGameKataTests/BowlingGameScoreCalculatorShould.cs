namespace ATP.BowlingGameKataTests
{
    using BowlingGameKata;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class BowlingGameScoreCalculatorShould
    {
        private BowlingGameScoreCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new BowlingGameScoreCalculator();
        }

        [Test]
        public void Return0_GivenAllMisses()
        {
            var result = _calculator.ScoreGame("--|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(0);
        }

        [Test]
        public void Return1_Given1PinOnFirstThrowOnFirstFrame()
        {
            var result = _calculator.ScoreGame("1-|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(1);
        }

        [Test]
        public void Return4_Given1PinOnFirstThrowOnFirstFrame()
        {
            var result = _calculator.ScoreGame("4-|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(4);
        }
    } 
}

