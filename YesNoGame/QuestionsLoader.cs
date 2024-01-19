namespace YesNoGame
{
    using System;
    using System.Collections.Generic;

    class QuestionLoader
    {
        public static List<Question> LoadQuestionsFromFile(string filePath)
        {
            List<Question> questions = new List<Question>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('/');

                    if (parts.Length == 2)
                    {
                        string questionText = parts[0].Trim(); //Trim - delete spaces " "
                        string correctAnswer = parts[1].Trim().ToUpper();

                        Question question = new Question(questionText, correctAnswer);
                        questions.Add(question);
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка в формате строки: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return questions;
        }
    }
}
