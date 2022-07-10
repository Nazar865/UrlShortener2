using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener2.Data.Entities;
using UrlShortener2.Models;

namespace UrlShortener2.Services.Interfaces
{
    public interface IShortUrlService
    {
        Task<IEnumerable<ShorterUrl>> GetUrlsAsync();

        Task<ShorterUrl> GetUrlByIdAsync(Guid id);

        Task<ShorterUrl> AddUrlAsync(ShortUrlModel shortedModel);

        Task<bool> DeleteUrlAsync(Guid id);
    }
}