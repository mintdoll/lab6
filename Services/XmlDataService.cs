using System.IO;
using System.Xml.Serialization;
using MicrofinanceApp.Models;

namespace MicrofinanceApp.Services
{
    public class XmlDataService
    {
        public void SaveToXml(string filePath, MicrofinanceCompany company)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MicrofinanceCompany));

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, company);
            }
        }

        public MicrofinanceCompany LoadFromXml(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new MicrofinanceCompany();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(MicrofinanceCompany));

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (MicrofinanceCompany)serializer.Deserialize(stream);
            }
        }
    }
}

