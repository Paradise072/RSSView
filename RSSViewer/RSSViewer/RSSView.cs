using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Collections.ObjectModel;

namespace RSSViewer
{
    public partial class RSSView : Form
    {

        SyndicationFeed feed;

        public RSSView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FetchFromURL();
        }
        private void FetchFromURL()
        {
            string url = "https://feeds.npr.org/1001/rss.xml";

            // I'm going to use XmlReader here following guidance from:
            // https://stackoverflow.com/questions/10399400/best-way-to-read-rss-feed-in-net-using-c-sharp
            XmlReader xml = XmlReader.Create(url);
            feed = SyndicationFeed.Load(xml);
            xml.Close();

            UpdateUI(); // This could be detached and put right after function call in theory
        }

        private void UpdateUI()
        {
            headlines.Items.Clear();
            foreach (SyndicationItem item in feed.Items)
            {
                string headline = item.Title.Text;
                headlines.Items.Add(headline);
            }
        }

        private string SyndicationAuthorsToString(Collection<SyndicationPerson> persons)
        {
            string finalString = "";
            foreach(SyndicationPerson person in persons)
            {
                finalString += $"{person.Name}, ";
            }
            if (persons.Count > 0)
            {
                // Remove the last two characters (, ) from the string
                finalString = finalString.Substring(0, finalString.Length - 2);
            }
            return finalString;
        }

        private void UpdateMainView(object sender, EventArgs e)
        {
            IEnumerable<SyndicationItem> filteredItems = feed.Items.Where((h) => h.Title.Text == headlines.Text);
            SyndicationItem[] filteredItemsArr = filteredItems.ToArray();
            if (filteredItemsArr.Length > 0) // We found an article!
            {
                SyndicationItem selectedItem = filteredItemsArr[0];
                string publishDate = "No Publishing Date";
                string summary = "No Summary Provided";
                string author = "No Authors Provided";
                string link = "No URL";
                if (selectedItem.PublishDate != null)
                {
                    publishDate = selectedItem.PublishDate.ToString();
                }
                if (selectedItem.Summary != null)
                {
                    summary = selectedItem.Summary.Text;
                }
                if (selectedItem.Authors != null && selectedItem.Authors.Count > 0)
                {
                    author = SyndicationAuthorsToString(selectedItem.Authors);
                }
                if (selectedItem.Links != null &&  selectedItem.Links.Count > 0)
                {
                    Uri linkUri = selectedItem.Links[0].GetAbsoluteUri();
                    WebView.Source = linkUri;
                    link = linkUri.ToString();
                }

                ArticleView.Text = $"Published {publishDate} by {author}\n{link}\n\n{summary}";
            }
        }
    }
}
