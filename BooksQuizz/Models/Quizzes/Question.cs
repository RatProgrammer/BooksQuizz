using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Quizzes
{
    [XmlRoot(ElementName = "question")]
    public class Question
    {
        [XmlElement(ElementName = "answer")]
        public List<Answer> Answers { get; set; }
        [XmlAttribute(AttributeName = "content")]
        public string Text { get; set; }
    }
}