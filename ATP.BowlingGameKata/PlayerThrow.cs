namespace ATP.BowlingGameKata
{
    internal class PlayerThrow
    {
        public char Score { get; set; }

        public int FrameNumber { get; set; }

        public bool IsSpare => Score == '/';

        public bool IsStrike => Score == 'X';

        public bool IsMiss => Score == '-';

        public int ParseScore => IsMiss ? 0 : IsStrike || IsSpare ? 10 : int.Parse(Score.ToString());
    }
}