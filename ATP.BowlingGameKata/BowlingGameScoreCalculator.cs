using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

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
                score += GetFrameScore(frames,frame);
            }

            return score;
        }

        private int GetFrameScore(string[] frames, int frame)
            => GetScoreForBowls(GetBowlsContributingToFrameScore(frames, frame));
        
        private char[] GetBowlsContributingToFrameScore(string[] frames, int frame)
        {
            var bowl1 = (frames[frame - 1])[0];
            var bowl2 = bowl1 == 'X' ? (frames[frame])[0] : (frames[frame - 1])[1];
            var bowl3 = bowl2 == 'X' ? (frames[frame + 1])[0]
                : bowl2 == '/' ? (frames[frame])[0]
                : '-';
            return new char[]{bowl1, bowl2,bowl3};
        }

        private int GetScoreForBowls(char[] bowls)
        {
            var total = 0;
            var score = 0;
            var last = 0;

            foreach (var bowl in bowls)
            {
                score = bowl == '-' ? 0
                        : bowl == 'X' ? 10
                        : bowl == '/' ? 10 - last
                        : int.Parse(bowl.ToString());

                total += score;
                last = score;
            }
            return total;
        }
    }
}