namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            if (char.IsDigit(gameBoard[3]))
            {
                return GetScoreForPosition(gameBoard);
            }

            if (char.IsDigit(gameBoard[1]) && char.IsDigit(gameBoard[0]))
            {
                return int.Parse(gameBoard[1].ToString()) + int.Parse(gameBoard[0].ToString());
            }

            if (char.IsDigit(gameBoard[1]))
            {
                return int.Parse(gameBoard[1].ToString());
            }

            if (char.IsDigit(gameBoard[0]))
            {
                return int.Parse(gameBoard[0].ToString());
            }

            return 0;
        }

        private static int GetScoreForPosition(string gameBoard)
        {
            return int.Parse(gameBoard[3].ToString());
        }
    }
}