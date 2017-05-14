using System.Collections.Generic;

namespace BooksQuizz.ViewModel
{
    public class QuestionViewModel
    {
        public string Text { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
    }
}