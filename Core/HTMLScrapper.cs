using HtmlAgilityPack;
using System;
using System.Text;

namespace HTML_Scrapper.Core
{
    public static class HTMLScrapper
    {
        public static HtmlDocument GetDocumentFromURL(string html)
        {
            try
            {
                return new HtmlWeb().Load(html);
            }
            catch (Exception e)
            {
                ////Logger.Error(e.ToString());
                return null;
            }
        }

        public static HtmlDocument GetDocumentFromURL(string html, Encoding encoding)
        {
            try
            {
                return new HtmlWeb() { AutoDetectEncoding = false, OverrideEncoding = encoding }.Load(html);
            }
            catch (Exception e)
            {
                //Logger.Error(e.ToString());
                return null;
            }
        }

        public static HtmlNode GetNode(HtmlDocument html, string xpath)
        {
            try
            {
                return html.DocumentNode.SelectSingleNode(xpath);
            }
            catch (Exception e)
            {
                //Logger.Error(e.ToString());
                return null;
            }
        }

        public static string GetElementContent(HtmlDocument html, string xpath)
        {
            try
            {
                return html.DocumentNode.SelectSingleNode(xpath).InnerText;
            }
            catch (Exception e)
            {
                //Logger.Error(e.ToString());
                return null;
            }
        }

        public static string GetElementAttribute(HtmlDocument html, string xpath, string attribute)
        {
            try
            {
                return html.DocumentNode.SelectSingleNode(xpath).GetAttributeValue(attribute, "NA"); ;
            }
            catch (Exception e)
            {
                //Logger.Error(e.ToString());
                return null;
            }
        }
    }
}
