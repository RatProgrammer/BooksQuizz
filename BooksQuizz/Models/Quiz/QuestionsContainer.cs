using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Quiz
{
    [XmlRoot(ElementName = "questions")]
    public class QuestionsContainer
    {
        [XmlElement(ElementName = "question")]
        public List<Question> Question { get; set; }
    }
}