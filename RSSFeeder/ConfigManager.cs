using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RSSFeeder
{
    class ConfigManager
    {
        private readonly XmlDocument _configFile;
        public List<string> SourceStrings { get; private set; }
        public int UpdateInterval { get; private set; } = 60;

        
        public ConfigManager()
        {

            SourceStrings = new List<string>();
            _configFile = new XmlDocument();
            if (!System.IO.File.Exists("config.xml"))
                SetConfigFile("config.xml");
            _configFile.Load("config.xml");
          
            int interval;
            if (int.TryParse(_configFile.DocumentElement["UpdateFrequency"].Attributes[0].Value, out interval))
                UpdateInterval = interval;

            FillSourceStrings();
            
        }

        public void AddSource(string URL)
        {
            SourceStrings.Add(URL);
            SetConfigFile("config.xml");
        }

        public void SetUpdateInterval(int interval)
        {
            UpdateInterval = interval;
        }
        private void SetConfigFile(string fileName)
        {
            /*Creation file*/
            
            XmlTextWriter textWritter = new XmlTextWriter(fileName, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("root");
            textWritter.WriteEndElement();
            textWritter.Close();

            /*Add Update Frequency element*/

            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XmlNode updateElement = document.CreateElement("UpdateFrequency");
            document.DocumentElement.AppendChild(updateElement); 
            XmlAttribute updateAttribute = document.CreateAttribute("Value"); 
            updateAttribute.Value = UpdateInterval.ToString();
            updateElement.Attributes.Append(updateAttribute);

            /*Add Feed Strings section*/

            XmlNode FeedStrringsSection = document.CreateElement("FeedStrings");
            document.DocumentElement.AppendChild(FeedStrringsSection);

            /*Add Feed Strings elements*/
            foreach (string URL in SourceStrings)
            {
                XmlNode element = document.CreateElement("FeedString");
                FeedStrringsSection.AppendChild(element);
                XmlAttribute attribute = document.CreateAttribute("URL");
                attribute.Value = URL;
                element.Attributes.Append(attribute);
            }
            document.Save(fileName);
        }

        
        private void FillSourceStrings()
        {
            foreach (XmlNode node in _configFile.DocumentElement["FeedStrings"])
                SourceStrings.Add(node.Attributes[0].Value);
        }
    }
}
