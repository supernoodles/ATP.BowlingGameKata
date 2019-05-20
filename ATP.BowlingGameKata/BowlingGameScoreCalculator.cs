namespace ATP.BowlingGameKata
{
    using System.Collections.Generic;
    using System.Linq;

    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            var playerThrows = Parse(gameBoard).ToList();

            return Enumerable.Range(1, 10).Sum(frameNumberToScore => 
                ScoreFrame(playerThrows.PlayerThrowsForFrame(frameNumberToScore), 
                    playerThrows.NextTwoPlayerThrowsAfterFrame(frameNumberToScore)));
        }

        private IEnumerable<PlayerThrow> Parse(string gameBoard) =>
            gameBoard.Split('|')
                .SelectMany((frame, i) => frame.Select(hit => new PlayerThrow {Score = hit, FrameNumber = i + 1}));

        private int ScoreFrame(IList<PlayerThrow> hitsInFrame, IList<PlayerThrow> nextTwoHits)
        {
            var score = hitsInFrame.Total();

            if (hitsInFrame.Last().IsSpare)
            {
                score += nextTwoHits.Take(1).ToList().Total();
            }

            if (hitsInFrame.First().IsStrike)
            {
                score += nextTwoHits.Total();
            }

            return score;
        }
    }
}