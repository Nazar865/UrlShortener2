using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener2.Helpers
{
    public static class UrlConvertor
    {
        public static string ShortUrl(this string url)
        {
            var shortUrl = "https://";
            if (url.StartsWith(shortUrl))
            {
                shortUrl += Guid.NewGuid().ToString().Substring(0, 8);
                return shortUrl;
            }
            return null;
        }
    }
}
