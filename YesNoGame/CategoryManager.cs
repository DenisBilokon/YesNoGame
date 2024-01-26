using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesNoGame
{
    class CategoryManager
    {
        public List<Question> ChooseCategory()
        {
            Console.WriteLine("Добро пожаловать! Выберите категорию, введя номер:");
            Console.WriteLine("1. Вопросы об истории");
            Console.WriteLine("2. Вопросы о науке");
            Console.WriteLine("3. Вопросы о географии");

            int selectedCategory;

            do
            {
                Console.Write("Ваш выбор: ");
            } while (!int.TryParse(Console.ReadLine(), out selectedCategory) || selectedCategory < 1 || selectedCategory > 3);

            List<Question> questions = LoadQuestions(selectedCategory);
            return questions;
        }

        private List<Question> LoadQuestions(int category)
        {

            switch (category)
            {
                case 1:
                    return LoadQuestionsFromFile("HistoryQuestions.txt");
                case 2:
                    return LoadQuestionsFromFile("ScienceQuestions.txt"); 
                case 3:
                    return LoadQuestionsFromFile("GeographyQuestions.txt"); 
                default:
                    return new List<Question>();
            }
        }

        private List<Question> LoadQuestionsFromFile(string filePath)
        {
            List<Question> questions = new List<Question>();

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('/');

                    if (parts.Length == 2)
                    {
                        string questionText = parts[0].Trim();
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
