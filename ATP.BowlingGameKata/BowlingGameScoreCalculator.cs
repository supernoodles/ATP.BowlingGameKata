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

            foreach (var @throw in frame)
            {
                if (@throw == 'X')
                {
                    return 10;
                }

                score += char.IsDigit(@throw)
                    ? int.Parse(@throw.ToString())
                    : 0;
            }

            return score;
        }
    }
}