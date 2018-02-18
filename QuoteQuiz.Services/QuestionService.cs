namespace QuoteQuiz.Services
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Contracts;
    using Data;
    using Models;
    using ViewModels;

    public class QuestionService : IQuestionService
    {
        private QuoteQuizContext context;

        public QuestionService(QuoteQuizContext context)
        {
            this.context = context;
        }

        public QuestionWithAnswersViewModel MultipleChoiceById(int id)
        {
            MultipleChoisesQuestion questionWithAnswers = this.context.MultipleAnswerQuesitons
                .Include(a => a.Answers)
                .Where(i => i.Id == id)                
                .SingleOrDefault();

            return Mapper.Map<QuestionWithAnswersViewModel>(questionWithAnswers);
        }

        public OneChoiceViewModel OneChoiceById(int id)
        {
            return this.context.OneChoiseQuestion
                .Where(i => i.Id == id)
                .ProjectTo<OneChoiceViewModel>()
                .SingleOrDefault();
        }
    }
}
