using System.Collections.Generic;
using BooksQuizz.Models.Quizzes;
using BooksQuizz.ViewModel;

namespace BooksQuizz.Models.Mappers
{
    public class HomeMapper
    {
        public static HomeViewModel Map(QuizzesContainer quizzesContainer)
        {
            var homeViewModel = new HomeViewModel
            {
                QuizNames = new List<string>(),
                QuizDescription = new List<string>()
            };
            foreach (var quiz in quizzesContainer.Quizzes)
            {
                homeViewModel.QuizNames.Add(quiz.Name);
                homeViewModel.QuizDescription.Add(quiz.Description);
            }
            return homeViewModel;
        }
    }
}