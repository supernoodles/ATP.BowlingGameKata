namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            var position = 0;
            var score = 0;

            for (var frame = 1; frame < 11; frame++)
            {
                score += GetScoreForPosition(gameBoard, position) + GetScoreForPosition(gameBoard, position +1);
                position += 3;
            }

            return score;
        }

        private static int GetScoreForPosition(string gameBoard, int position)
        {
            return char.IsDigit(gameBoard[position])
                ? int.Parse(gameBoard[position].ToString())
                : 0;
        }
    }
}