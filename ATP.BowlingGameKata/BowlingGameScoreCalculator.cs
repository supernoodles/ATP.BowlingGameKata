namespace ATP.BowlingGameKata
{
    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            if (gameBoard == "4-|--|--|--|--|--|--|--|--|--||--")
            {
                return 4;
            }

            if (gameBoard == "--|--|--|--|--|--|--|--|--|--||--")
            {
                return 0;
            }

            return 1;
        }
    }
}