namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            if (char.IsDigit(gameBoard[3]) && char.IsDigit(gameBoard[4]))
            {
                return GetScoreForPosition(gameBoard, 3) + GetScoreForPosition(gameBoard, 4);
            }

            if (char.IsDigit(gameBoard[4]))
            {
                return GetScoreForPosition(gameBoard, 4);
            }


            if (char.IsDigit(gameBoard[3]))
            {
                return GetScoreForPosition(gameBoard, 3);
            }

            if (char.IsDigit(gameBoard[1]) && char.IsDigit(gameBoard[0]))
            {
                return GetScoreForPosition(gameBoard, 1) + GetScoreForPosition(gameBoard, 0);
            }

            if (char.IsDigit(gameBoard[1]))
            {
                return GetScoreForPosition(gameBoard,1);
            }

            if (char.IsDigit(gameBoard[0]))
            {
                return GetScoreForPosition(gameBoard,0);
            }

            return 0;
        }

        private static int GetScoreForPosition(string gameBoard, int position)
        {
            return int.Parse(gameBoard[position].ToString());
        }
    }
}