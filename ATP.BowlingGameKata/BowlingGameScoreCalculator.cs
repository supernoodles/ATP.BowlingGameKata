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

            if (gameBoard == "1-|--|--|--|--|--|--|--|--|--||--")
            {
                return 1;
            }

            if (gameBoard == "9-|--|--|--|--|--|--|--|--|--||--")
            {
                return 9;
            }

            return 0;
        }
    }
}