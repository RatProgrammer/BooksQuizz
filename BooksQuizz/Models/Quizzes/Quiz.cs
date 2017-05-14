using System.Xml.Serialization;

namespace BooksQuizz.Models.Quizzes
{
    [XmlRoot(ElementName = "quizz")]
    public class Quiz
    {
        [XmlElement(ElementName = "questions")]
        public QuestionsContainer QuestionsContainer { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }
}