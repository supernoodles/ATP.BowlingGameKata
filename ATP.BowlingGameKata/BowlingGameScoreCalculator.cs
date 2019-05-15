namespace ATP.BowlingGameKata
{
    using System.Linq;

    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            if (char.IsDigit(char.Parse(gameBoard.Substring(1, 1))))
            {
                return int.Parse(gameBoard.Substring(1, 1));
            }

            if (char.IsDigit(gameBoard.First()))
            {
                return int.Parse(gameBoard.First().ToString());
            }

            return 0;
        }
    }
}