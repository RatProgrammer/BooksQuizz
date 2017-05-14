using System.IO;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Serialization
{
    public class XmlSerializator
    {
        public static T ReadXml<T>(string xmlFile)
        {
            var serializer = new XmlSerializer(typeof(T));
            var streamReader = new StreamReader(xmlFile);
            return (T) serializer.Deserialize(streamReader);
        }
    }
}