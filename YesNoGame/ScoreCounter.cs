namespace YesNoGame
{
    class ScoreCounter
    {
        private int score;

        public void IncrementScore() 
        {
            score++;
        }

        public int GetScore()
        {
            return score;
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Очки: {score}");
        }
    }

}
