using System;
using System.Drawing;
using System.ServiceModel.Syndication;
using System.Windows.Forms;


namespace RSSFeeder
{
    class Item
    {
        
        public LinkLabel LinkName { get; private set; }
        public String URL { get; private set; }
        public Label PubDate { get; private set; }
        public Label Description { get; private set; }
        
        public Item(SyndicationItem item)
        {
            LinkName = new LinkLabel();
            LinkName.Text = item.Title.Text;
            LinkName.LinkClicked += LinkName_LinkClicked;
            URL = item.Links[0].Uri.ToString();
            LinkName.AutoSize = true;
            
            LinkName.Font = new Font(LinkName.Font.Name, LinkName.Font.Height, FontStyle.Bold);

            PubDate = new Label();
            PubDate.Text = item.PublishDate.DateTime.ToString();
            PubDate.AutoSize = true;

            Description = new Label();
            Description.AutoSize = true;
            Description.Text = item.Summary.Text;
            
        }

        private void LinkName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(URL);
        }
    }
}
