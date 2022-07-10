using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener2.Data.Entities
{
    public class ShorterUrl : KeyEntity
    {
        public string OriginalUrl { get; set; }

        public string ShortUrl { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UserName { get; set; }

        public User User { get; set; }
    }
}
