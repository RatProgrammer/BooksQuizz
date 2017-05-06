using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Quiz
{
    [XmlRoot(ElementName = "tags")]
    public class TagsContainer
    {
        [XmlElement(ElementName = "tag")]
        public List<Tag> Tag { get; set; }
    }
}