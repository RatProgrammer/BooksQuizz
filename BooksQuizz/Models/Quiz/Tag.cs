using System.Xml.Serialization;

namespace BooksQuizz.Models.Quiz
{
    [XmlRoot(ElementName = "tag")]
    public class Tag
    {
        [XmlElement(ElementName = "questions")]
        public QuestionsContainer QuestionsContainer { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}