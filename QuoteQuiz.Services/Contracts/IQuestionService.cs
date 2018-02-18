namespace QuoteQuiz.Services.Contracts
{
    using ViewModels;

    public interface IQuestionService
    {
        QuestionWithAnswersViewModel MultipleChoiceById(int id);

        OneChoiceViewModel OneChoiceById(int id);
    }
}
