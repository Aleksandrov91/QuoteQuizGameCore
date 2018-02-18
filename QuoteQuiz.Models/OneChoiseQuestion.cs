namespace QuoteQuiz.Models
{
    using Contracts;

    public class OneChoiseQuestion : IQuestion
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Author { get; set; }

        public bool Correct { get; set; }
    }
}
