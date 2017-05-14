using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Quizzes
{
    [XmlRoot(ElementName = "questions")]
    public class QuestionsContainer
    {
        [XmlElement(ElementName = "question")]
        public List<Question> Questions { get; set; }}
}