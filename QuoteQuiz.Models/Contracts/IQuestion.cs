namespace QuoteQuiz.Models.Contracts
{
    public interface IQuestion
    {
        string Text { get; }

        string Author { get; }
    }
}
