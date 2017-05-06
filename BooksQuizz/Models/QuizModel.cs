using System;
using BooksQuizz.Models.Quiz;
using BooksQuizz.Models.Serialization;

namespace BooksQuizz.Models
{
    public class QuizModel
    {
        public TagsContainer TagsContainer { get; set; }

        public void LoadQuestions()
        {
            var filePath = $"{AppDomain.CurrentDomain.BaseDirectory}Models\\Config\\QuizQuestions.xml";
            TagsContainer = XmlSerializator.ReadXml<TagsContainer>(filePath);
        }
    }
}