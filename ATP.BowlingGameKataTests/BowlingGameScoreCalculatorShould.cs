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

        [TestCase("-9|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 9)]
        [TestCase("-3|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 3)]
        [TestCase("-1|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        public int ReturnExpectedScore_Given1HitOnSecondThrowOnFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("32|--|--|--|--|--|--|--|--|--||--",ExpectedResult = 5)]
        [TestCase("22|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 4)]
        [TestCase("23|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 5)]
        public int ReturnExpectedScore_Given1HitsOnBothThrowsOnFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("--|1-|--|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        public int ReturnExpectedScore_Given1HitsOnFirstThrowOnFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("--|-3|--|--|--|--|--|--|--|--||--", ExpectedResult = 3)]
        public int ReturnExpectedScore_Given1HitsOnSecondThrowOnFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }
    }
}

