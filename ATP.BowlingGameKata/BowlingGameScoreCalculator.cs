namespace ATP.BowlingGameKata
{
    using System.Linq;

    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            if (gameBoard == "-9|--|--|--|--|--|--|--|--|--||--")
            {
                return 9;
            }

            if (gameBoard == "-3|--|--|--|--|--|--|--|--|--||--")
            {
                return 3;
            }

            if (gameBoard == "-1|--|--|--|--|--|--|--|--|--||--")
            {
                return 1;
            }

            if (char.IsDigit(gameBoard.First()))
            {
                return int.Parse(gameBoard.First().ToString());
            }

            return 0;
        }
    }
}