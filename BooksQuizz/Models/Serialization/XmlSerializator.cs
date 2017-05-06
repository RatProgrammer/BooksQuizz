using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BooksQuizz.Models.Serialization
{
    public class XmlSerializator
    {
        public static T ReadXml<T>(String xmlFile)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader streamReader = new StreamReader(xmlFile);
            return (T) serializer.Deserialize(streamReader);
        }
    }
}