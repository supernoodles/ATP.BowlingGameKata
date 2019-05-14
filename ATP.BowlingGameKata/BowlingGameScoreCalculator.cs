namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            if (gameBoard == "--|--|--|--|--|--|--|--|--|--||--")
            {
                return 0;
            }

            return 1;
        }
    }
}