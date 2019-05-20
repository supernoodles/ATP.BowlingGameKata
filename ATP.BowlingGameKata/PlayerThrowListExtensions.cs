namespace ATP.BowlingGameKata
{
    using System.Collections.Generic;
    using System.Linq;

    internal static class PlayerThrowListExtensions
    {
        public static int Total(this IList<PlayerThrow> playerThrows) =>
            playerThrows.Last().IsSpare
                ? 10
                : playerThrows.Sum(playerThrow => playerThrow.ParseScore);

        public static List<PlayerThrow> PlayerThrowsForFrame(this IEnumerable<PlayerThrow> playerThrows, int frameNumber) =>
            playerThrows.Where(playerThrow => playerThrow.FrameNumber == frameNumber)
                .ToList();

        public static List<PlayerThrow> NextTwoPlayerThrowsAfterFrame(this IEnumerable<PlayerThrow> playerThrows,
            int frameNumber) =>
            playerThrows.Where(playerThrow => playerThrow.FrameNumber > frameNumber)
                .OrderBy(playerThrow => playerThrow.FrameNumber)
                .Take(2)
                .ToList();
    }
}