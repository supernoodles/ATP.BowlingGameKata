namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            var frames = gameBoard.Split('|');

            var score = 0;

            for (var frame = 1; frame < 11; frame++)
            {
                score += GetScoreForFrame(frames[frame - 1]);
            }

            return score;
        }

        private int GetScoreForFrame(string frame)
        {
            var score = 0;
            var position = 0;

            foreach (var @throw in frame)
            {
                if (@throw == 'X')
                {
                    return 10;
                }

                score += GetScoreForPosition(frame, position);
                position += 1;
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