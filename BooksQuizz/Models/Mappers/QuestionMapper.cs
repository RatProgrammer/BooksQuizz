using System.Collections.Generic;
using BooksQuizz.Models.Quizzes;
using BooksQuizz.ViewModel;

namespace BooksQuizz.Models.Mappers
{
    public class QuestionMapper
    {
        public static QuestionViewModel Map(Question question)
        {
            var questionViewModel = new QuestionViewModel
            { Answers = new List<AnswerViewModel>(),
                Text = question.Text
            };
            foreach (var answer in question.Answers)
            {
                questionViewModel.Answers.Add(AnswerMapper.Map(answer));
            }
            return questionViewModel;
        }
    }
}