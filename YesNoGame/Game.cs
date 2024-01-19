namespace YesNoGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Game
    {
        public void PlayGame(List<Question> questions)
        {
            Console.WriteLine("Добро пожаловать в игру!");
            Console.WriteLine("Ответьте на вопросы 'T' (True) или 'F' (False).");

            ScoreCounter scoreCounter = new ScoreCounter();

            Random random = new Random();
            List<Question> shuffledQuestions = questions.OrderBy(q => random.Next()).ToList();

            foreach (var question in shuffledQuestions)
            {
                Console.Clear(); 

                scoreCounter.DisplayScore(); 

                string userAnswer;

                do
                {
                    Console.WriteLine($"\nВопрос: {question.Text}");
                    Console.Write("Ответ (T/F): ");

                    userAnswer = Console.ReadLine().ToUpper();

                    if (userAnswer == "T" || userAnswer == "F")
                    {
                        break; 
                    }

                    Console.WriteLine("Неверная буква/формат. Пожалуйста, введите 'T' или 'F'.");
                    Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
                    Console.ReadLine();
                    Console.Clear(); 
                    scoreCounter.DisplayScore(); 
                } while (true);

                if (userAnswer == question.CorrectAnswer)
                {
                    Console.WriteLine("Верно!");
                    scoreCounter.IncrementScore();
                }
                else
                {
                    Console.WriteLine($"Неверно! Правильный ответ: {question.CorrectAnswer}");
                }

                Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
                Console.ReadLine();
            }

            Console.Clear(); 
            Console.WriteLine("\nИгра завершена. Спасибо за участие!");
        }
    }
}