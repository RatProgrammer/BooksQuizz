using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksQuizz.Models;
using BooksQuizz.Models.Quiz;

namespace BooksQuizz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //GameOfThronesModel gameOfThronesModel = new GameOfThronesModel();
            //gameOfThronesModel.LoadQuestions();
            //ViewBag.Question = gameOfThronesModel.AnswerA;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GameOfThrones()
        {
            ViewBag.Message = "Game of Thrones QuuiZZy";
            
            QuizModel quizModel = new QuizModel();
            quizModel.LoadQuestions();
            Tag gameOfThronesTag = quizModel.TagsContainer.Tag.FirstOrDefault(x => x.Name.Equals("Game of Thrones"));
            //ViewBag.Questions = gameOfThronesTag?.Questions.Question.Select(x => x.Content).ToList();
            ViewBag.Questions = gameOfThronesTag?.QuestionsContainer;
            //ViewBag.Answers = gameOfThronesTag?.Questions.Question.Select(x => x.Answer).ToList();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult GameOfThrones(QuizModel model)
        {

            return View();
        }
    }
}