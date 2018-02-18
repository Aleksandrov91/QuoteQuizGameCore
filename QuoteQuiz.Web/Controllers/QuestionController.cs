namespace QuoteQuiz.Web.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using Services.ViewModels;

    public class QuestionController : Controller
    {
        private IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        public IActionResult MultipleChoice(int questionPage = 1)
        {
            QuestionWithAnswersViewModel question = this.questionService.MultipleChoiceById(questionPage);

            if (question == null)
            {
                return this.View("End");
            }            

            ViewBag.QuestionPage = questionPage;

            return this.View(question);
        }

        public IActionResult OneChoice(int questionPage = 1)
        {
            OneChoiceViewModel question = this.questionService.OneChoiceById(questionPage);

            if (question == null)
            {
                return this.View("End");
            }

            ViewBag.QuestionPage = questionPage;

            return this.View(question);
        }

        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
