namespace QuoteQuiz.Web
{
    using System.Linq;

    using AutoMapper;
    using Models;
    using Services.ViewModels;

    public class QuoteQuizProfile : Profile
    {
        public QuoteQuizProfile()
        {
            CreateMap<MultipleChoisesQuestion, QuestionWithAnswersViewModel>()
                .ForMember(dto => dto.CorrectAnswer,
                opt => opt.MapFrom(src =>
                src.Answers.Where(a => a.IsCorrect)
                .Select(a => a.Text)
                .SingleOrDefault()));
        }
    }
}
