using YesNoGame;

class Program
{
    static void Main()
    {
        CategoryManager categoryManager = new CategoryManager();
        List<Question> selectedQuestions = categoryManager.ChooseCategory();

        if (selectedQuestions.Count > 0)
        {
            Game game = new Game();
            game.PlayGame(selectedQuestions);
        }
        else
        {
            Console.WriteLine("Извините, выбранная категория не содержит вопросов.");
        }
    }
}

