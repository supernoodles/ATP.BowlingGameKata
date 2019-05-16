namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            var scoreFrame2 = GetScoreForPosition(gameBoard, 3) + GetScoreForPosition(gameBoard, 4);

            if (scoreFrame2 > 0)
            {
                return scoreFrame2;
            }

            var scoreFrame1 = GetScoreForPosition(gameBoard, 1) + GetScoreForPosition(gameBoard, 0);

            if (scoreFrame1 > 0)
            {
                return scoreFrame1;
            }

            return 0;
        }

        private static int GetScoreForPosition(string gameBoard, int position)
        {
            return char.IsDigit(gameBoard[position])
                ? int.Parse(gameBoard[position].ToString())
                : 0;
        }
    }
}