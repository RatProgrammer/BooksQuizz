using System.Xml.Serialization;

namespace BooksQuizz.Models.Quiz
{
    [XmlRoot(ElementName = "answer")]
    public class Answer
    {
        [XmlAttribute(AttributeName = "isValid")]
        public bool IsValid { get; set; }
        [XmlText]
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}