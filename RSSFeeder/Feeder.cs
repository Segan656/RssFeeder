using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace RSSFeeder
{
    class Feeder
    {
       
        private SyndicationFeed _channel;
        public List<Item> Items { get; private set; }
        public string URL { get; private set; }

        public Feeder(string URL)
        {
            Items = new List<Item>();
            this.URL = URL;
            UpdateFeed();
        }
        public void UpdateFeed()
        {
            
            XmlReader feedReader = XmlReader.Create(URL);
            _channel = SyndicationFeed.Load(feedReader);
            FillItems();
        }

        public static bool IsFeed(string URL)
        {
            try
            {
                XmlReader feedReader = XmlReader.Create(URL);
            }
            catch (System.IO.FileNotFoundException)
            {
                return false;
            }
            return true;
        }
        
        private void FillItems()
        {
            if (_channel != null)
                foreach (SyndicationItem RSI in _channel.Items)
                    Items.Add(new Item(RSI));
                
        }

    }
}
