using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Quiz
{
    [XmlRoot(ElementName = "question")]
    public class Question
    {
        [XmlElement(ElementName = "answer")]
        public List<Answer> Answers { get; set; }
        [XmlAttribute(AttributeName = "content")]
        public string Content { get; set; }
    }
}