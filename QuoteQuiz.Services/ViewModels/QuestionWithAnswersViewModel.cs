namespace QuoteQuiz.Services.ViewModels
{
    using System.Collections.Generic;

    public class QuestionWithAnswersViewModel
    {
        public string Text { get; set; }

        public string Author { get; set; }

        public string CorrectAnswer { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
    }
}
