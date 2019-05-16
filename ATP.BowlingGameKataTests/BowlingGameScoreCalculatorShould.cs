namespace ATP.BowlingGameKataTests
{
    using BowlingGameKata;
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

        [TestCase("--|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 0)]
        [TestCase("21|13|--|--|--|--|--|--|--|--||--", ExpectedResult = 7)]
        [TestCase("-9|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 9)]
        [TestCase("-3|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 3)]
        [TestCase("-1|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        [TestCase("32|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 5)]
        [TestCase("22|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 4)]
        [TestCase("23|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 5)]
        [TestCase("--|1-|--|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        [TestCase("--|-3|--|--|--|--|--|--|--|--||--", ExpectedResult = 3)]
        [TestCase("--|13|--|--|--|--|--|--|--|--||--", ExpectedResult = 4)]
        public int ReturnExpectedScore_GivenThrowsInFirstTwoFrames(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("--|--|1-|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        [TestCase("--|--|-7|--|--|--|--|--|--|--||--", ExpectedResult = 7)]
        [TestCase("--|--|17|--|--|--|--|--|--|--||--", ExpectedResult = 8)]
        public int ReturnExpectedScore_GivenThrowsInThirdFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("--|--|17|-5|--|--|--|--|--|--||--", ExpectedResult = 13)]
        public int ReturnExpectedScore_GivenThrowsInFirstFourFrames(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }


    }
}

