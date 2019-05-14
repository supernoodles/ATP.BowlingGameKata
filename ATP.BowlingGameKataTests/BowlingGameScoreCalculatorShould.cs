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

        [TestCase("9-|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 9)]
        [TestCase("1-|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        [TestCase("4-|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 4)]
        public int ReturnExpectedScore_Given1HitOnFirstThrowOnFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }
    }
}

