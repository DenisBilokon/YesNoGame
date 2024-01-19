namespace YesNoGame
{
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
}
