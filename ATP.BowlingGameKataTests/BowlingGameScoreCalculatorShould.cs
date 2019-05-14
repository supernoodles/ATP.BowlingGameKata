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
        public void Return4_Given4PinsOnFirstThrowOnFirstFrame()
        {
            var result = _calculator.ScoreGame("4-|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(4);
        }

        [Test]
        public void Return9_Given9PinsOnFirstThrowOnFirstFrame()
        {
            var result = _calculator.ScoreGame("9-|--|--|--|--|--|--|--|--|--||--");
            result.Should().Be(9);
        }


        [TestCase("9-|--|--|--|--|--|--|--|--|--||--", ExpectedResult = 9)]

        public int ReturnExpectedScore_Given1HitOnFirstThrowOnFirstFrame(string gameBoard)
        {
            return _calculator.ScoreGame(gameBoard);
        }





    }
}

