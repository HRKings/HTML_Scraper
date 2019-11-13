using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTML_Scrapper.Helper
{
    public static class Extensions
    {
        public static string DeEntitize(this string entitized)
        {
            return HtmlEntity.DeEntitize(entitized);
        }
    }
}
