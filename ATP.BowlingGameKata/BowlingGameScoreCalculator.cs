namespace ATP.BowlingGameKata
{
    using System.Collections.Generic;
    using System.Linq;

    public class BowlingGameScoreCalculator
    {
        public int ScoreGame(string gameBoard)
        {
            var playerThrowsForGame = Parse(gameBoard).ToList();

            return Enumerable.Range(1, 10)
                .Sum(frameNumberToScore => 
                        ScoreFrame(playerThrowsForGame.PlayerThrowsForFrame(frameNumberToScore), 
                    playerThrowsForGame.NextTwoPlayerThrowsAfterFrame(frameNumberToScore)));
        }

        private IEnumerable<PlayerThrow> Parse(string gameBoard) =>
            gameBoard.Split('|')
                .SelectMany((frame, frameIndex) => frame.Select(hit => new PlayerThrow {Score = hit, FrameNumber = frameIndex + 1}));

        private int ScoreFrame(IList<PlayerThrow> playerThrowsInFrame, IList<PlayerThrow> nextTwoPlayerThrows)
        {
            var score = playerThrowsInFrame.Total();

            if (playerThrowsInFrame.Last().IsSpare)
            {
                score += nextTwoPlayerThrows.Take(1).ToList().Total();
            }

            if (playerThrowsInFrame.First().IsStrike)
            {
                score += nextTwoPlayerThrows.Total();
            }

            return score;
        }
    }
}