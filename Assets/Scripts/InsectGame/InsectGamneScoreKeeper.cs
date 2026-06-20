namespace DefaultNamespace
{
    public static class InsectGameScoreKeeper
    {
        private static int score;

        public static void AddToScore(int amount)
        {
            score += amount;
        }

        public static void ResetScore()
        {
            score = 0;
        }

        public static int GetScore()
        {
            return score;
        }
    }
}