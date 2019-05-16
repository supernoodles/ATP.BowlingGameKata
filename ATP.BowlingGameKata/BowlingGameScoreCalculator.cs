namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            var scoreFrame1 = GetScoreForPosition(gameBoard, 0) + GetScoreForPosition(gameBoard, 1);

            var scoreFrame2 = GetScoreForPosition(gameBoard, 3) + GetScoreForPosition(gameBoard, 4);

            var scoreFrame3 = GetScoreForPosition(gameBoard, 6);

            return scoreFrame1 + scoreFrame2 + scoreFrame3;
        }

        private static int GetScoreForPosition(string gameBoard, int position)
        {
            return char.IsDigit(gameBoard[position])
                ? int.Parse(gameBoard[position].ToString())
                : 0;
        }
    }
}