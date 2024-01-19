using YesNoGame;

class Program
{
    static void Main()
    {
        string filePath = @"E:\GameQuestions\Questions1.txt";
        List<Question> questions = QuestionLoader.LoadQuestionsFromFile(filePath);

        Game game = new Game();
        game.PlayGame(questions);
    }
}

