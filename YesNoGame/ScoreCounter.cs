namespace YesNoGame
{
    class ScoreCounter
    {
        private int score;
        private int lives;

        public int Score { get { return score; } }
        public int Lives { get { return lives; } }

        public ScoreCounter(int initialLives = 3)
        {
            score = 0;
            lives = initialLives;
        }

        public void IncrementScore() 
        {
            score++;
        }
        public void DecrementLives()
        {
            lives--;
        }

        public void DisplayScoreAndLives()
        {
            Console.WriteLine($"Очки: {score}");
            Console.WriteLine($"Жизни: {new string('♥', lives)}");
        }
        public void DisplayFinalResults()
        {
            Console.WriteLine($"\nОкончательные результаты:");
            Console.WriteLine($"Очки: {score}");
            Console.WriteLine($"Оставшиеся жизни: {lives}");
        }
    }

}
