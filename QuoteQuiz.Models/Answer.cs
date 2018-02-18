namespace QuoteQuiz.Models
{
    using Contracts;

    public class Answer : IAnswer
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        public MultipleChoisesQuestion Question { get; set; }
    }
}
