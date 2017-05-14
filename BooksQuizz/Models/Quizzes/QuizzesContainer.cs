using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Quizzes
{
    [XmlRoot(ElementName = "quizzes")]
    public class QuizzesContainer
    {
        [XmlElement(ElementName = "quizz")]
        public List<Quiz> Quizzes { get; set; }
    }
}