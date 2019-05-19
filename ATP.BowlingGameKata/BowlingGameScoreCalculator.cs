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
                score += GetFrameScore(frames, frame);
            }

            return score;
        }

        private int GetFrameScore(string[] frames, int frame)
        {
            var throw1 = (frames[frame - 1])[0];
            var throw2 = throw1 == 'X' ? (frames[frame])[0] : (frames[frame - 1])[1];
            var throw3 = throw2 == 'X' ? (frames[frame + 1])[0]
                : throw2 == '/' ? (frames[frame])[0]
                : (char?) '-';

            var scoreThrow1 = throw1 == '-' ? 0 
                                    : throw1 == 'X' ? 10 
                                    : int.Parse(throw1.ToString());    
            var scoreThrow2 = throw2 == '-' ? 0
                                    : throw2 == 'X' ? 10 
                                    : throw2 == '/' ? 10 - scoreThrow1 
                                    : int.Parse(throw2.ToString());
            var scoreThrow3 = throw3 == '-' ? 0
                                    : throw3 == 'X' ? 10
                                    : throw3 == '/' ? 10 - scoreThrow2
                                    : int.Parse(throw3.ToString());

            return scoreThrow1 + scoreThrow2 + scoreThrow3;
        }
    }
}