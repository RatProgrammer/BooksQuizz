using System.Collections.Generic;
using BooksQuizz.Models.Quizzes;
using BooksQuizz.ViewModel;

namespace BooksQuizz.Models.Mappers
{
    public class QuizMapper
    {
        public static QuizViewModel Map(Quiz quiz)
        {
            var quizViewModel = new QuizViewModel {Questions = new List<QuestionViewModel>()};
            foreach (var question in quiz.QuestionsContainer.Questions)
            {
                quizViewModel.Questions.Add(QuestionMapper.Map(question));
            }
            return quizViewModel;
        }
    }
}