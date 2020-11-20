using System.IO;
using System.Xml.Serialization;

namespace H2D.AudioPlayer.App
{
    public static class XmlHelper
    {
        public static T LoadXML<T>(string filePath)
        {
            var reader = new XmlSerializer(typeof(T));
            var file = new StreamReader(filePath);
            var result = (T)reader.Deserialize(file);
            file.Close();
            file.Dispose();
            return result;
        }

        public static void SaveXML<T>(this T obj, string filePath)
        {
            var writer = new XmlSerializer(typeof(T));
            string folderPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            FileStream file = File.Create(filePath);

            writer.Serialize(file, obj);
            file.Close();
            file.Dispose();
        }
    }
}
