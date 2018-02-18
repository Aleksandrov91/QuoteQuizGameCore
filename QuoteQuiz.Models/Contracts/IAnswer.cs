namespace QuoteQuiz.Models.Contracts
{
    public interface IAnswer
    {
        string Text { get; }

        bool IsCorrect { get; }

        int QuestionId { get; }
    }
}
