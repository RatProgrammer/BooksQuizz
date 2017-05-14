using BooksQuizz.Models.Quizzes;
using BooksQuizz.ViewModel;

namespace BooksQuizz.Models.Mappers
{
    public class AnswerMapper
    {
        public static AnswerViewModel Map(Answer answer)
        {
            var answerViewModel = new AnswerViewModel
            {
                IsSelected = false,
                Text = answer.Text
            };
            return answerViewModel;
        }
    }
}