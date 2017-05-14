using System.Linq;
using System.Web.Mvc;
using BooksQuizz.Models;
using BooksQuizz.Models.Mappers;
using BooksQuizz.Models.Quizzes;
using BooksQuizz.ViewModel;


namespace BooksQuizz.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuizModel _quizModel;
        public HomeController()
        { 
            _quizModel = new QuizModel();
            _quizModel.LoadQuestions();
        }
        
        public ActionResult Index()
        {
            var homeViewModel = HomeMapper.Map(_quizModel.QuizzesContainer);
            Session.Add("Quiz", homeViewModel);

            return View(homeViewModel);
        }

        public ActionResult SelectedQuiz(int id)
        {
            Quiz quiz = _quizModel.QuizzesContainer.Quizzes[id];
            ViewBag.Message = quiz.Name;
            Session.Add("Quiz", quiz);
            var quizViewModel = QuizMapper.Map(quiz);
            return View(quizViewModel);
        }

        [HttpPost]
        public ActionResult CheckQuiz(QuizViewModel model)
        {
            var quiz = Session["Quiz"] as Quiz;

            var result = GetResult(model, quiz);

            ViewBag.Result = result;

            return View();
        }

        private static int GetResult(QuizViewModel model, Quiz quiz)
        {
            return model.Questions
                .Select((question, i) => question.Answers
                    .Where((answer, j) => answer.IsSelected == true && quiz.QuestionsContainer.Questions[i].Answers[j].IsValid)
                    .Count())
                    .Sum();
        }
    }
}