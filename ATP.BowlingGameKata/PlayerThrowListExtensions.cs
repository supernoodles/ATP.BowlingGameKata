namespace ATP.BowlingGameKata
{
    using System.Collections.Generic;
    using System.Linq;

    internal static class PlayerThrowListExtensions
    {
        public static int Total(this IList<PlayerThrow> throws) => throws.Last().IsSpare ? 10 : throws.Sum(hit => hit.ParseScore);

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