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

        [TestCase("-1|1-|22|-5|42|1-|-7|22|13|31||--", ExpectedResult = 37)]
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
        [TestCase("--|--|1-|--|--|--|--|--|--|--||--", ExpectedResult = 1)]
        [TestCase("--|--|-7|--|--|--|--|--|--|--||--", ExpectedResult = 7)]
        [TestCase("--|--|17|--|--|--|--|--|--|--||--", ExpectedResult = 8)]
        [TestCase("--|--|17|-5|--|--|--|--|--|--||--", ExpectedResult = 13)]
        public int ReturnExpectedScore_GivenThrowsInAnyOfThe10Frames(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("X|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 10)]
        public int ReturnExpectedScore_GivenStrikeOnFirstThrowFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

        [TestCase("X|1-|--|--|--|--|--|--|--|--||--", ExpectedResult = 12)]
        [TestCase("X|1/|--|--|--|--|--|--|--|--||--", ExpectedResult = 30)]
        [TestCase("X|1/|5-|--|--|--|--|--|--|--||--", ExpectedResult = 40)]
        [TestCase("X|X|X|--|--|--|--|--|--|--||--", ExpectedResult = 60)]
        public int ReturnExpectedScore_GivenStrikeOnFirstThrowFirstFrame1OnFirstThrowSecondFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }

    }
}

