namespace QuoteQuiz.Models
{
    using System.Collections.Generic;

    using Contracts;

    public class MultipleChoisesQuestion : IQuestion
    {
        public MultipleChoisesQuestion()
        {
            this.Answers = new List<Answer>();
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public string Author { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
