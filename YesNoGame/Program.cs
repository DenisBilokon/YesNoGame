using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"E:\GameQuestions\Questions1.txt";
        List<Question> questions = LoadQuestionsFromFile(filePath);
    }

    static List<Question> LoadQuestionsFromFile(string filePath)
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

class Question
{
    public string Text { get; set; }
    public string CorrectAnswer { get; set; }

    public Question(string text, string correctAnswer)
    {
        Text = text;
        CorrectAnswer = correctAnswer;
    }
}
