using System;
using BooksQuizz.Models.Quizzes;
using BooksQuizz.Models.Serialization;

namespace BooksQuizz.Models
{
    public class QuizModel
    {
        public QuizzesContainer QuizzesContainer { get; set; }

        public void LoadQuestions()
        {
            var filePath = $"{AppDomain.CurrentDomain.BaseDirectory}Models\\Config\\QuizQuestions.xml";
            QuizzesContainer = XmlSerializator.ReadXml<QuizzesContainer>(filePath);
        }
    }
}