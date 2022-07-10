using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener2.Data.Entities;
using UrlShortener2.Helpers;
using UrlShortener2.Models;
using UrlShortener2.Services.Interfaces;

namespace UrlShortener2.Services
{
    public class ShortUrlService : IShortUrlService
    {
        private readonly GenericService<ShorterUrl> _genericService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ShortUrlService(GenericService<ShorterUrl> genericService, IMapper mapper, UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _genericService = genericService;
            _mapper = mapper;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<IEnumerable<ShorterUrl>> GetUrlsAsync()
        {
            var result = await _genericService.GetRangeAsync();

            return result;
        }

        public async Task<ShorterUrl> GetUrlByIdAsync(Guid id)
        {
            var result = await _genericService.GetAsync(id);

            return result;
        }

        public async Task<ShorterUrl> AddUrlAsync(ShortUrlModel shortedModel)
        {
            var currentUserName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(currentUserName);

            var urlExist = await _genericService.FindByConditionAsync(c => c.OriginalUrl.Equals(shortedModel.OriginalUrl));

            if (urlExist == null)
            {
                var mappedShorterUrl = _mapper.Map<ShorterUrl>(shortedModel);

                mappedShorterUrl.ShortUrl = mappedShorterUrl.OriginalUrl.ShortUrl();
                mappedShorterUrl.UserName = currentUser.UserName;
                mappedShorterUrl.User = currentUser;

                var duplicateShortUrl = await _genericService.FindByConditionAsync(c => c.ShortUrl.Equals(mappedShorterUrl.ShortUrl));

                while (duplicateShortUrl != null)
                {
                    mappedShorterUrl.ShortUrl = mappedShorterUrl.OriginalUrl.ShortUrl();
                    duplicateShortUrl = await _genericService.FindByConditionAsync(c => c.ShortUrl.Equals(mappedShorterUrl.ShortUrl));
                }

                if (mappedShorterUrl.ShortUrl != null)
                {
                    await _genericService.InserAsynct(mappedShorterUrl);

                    return mappedShorterUrl;
                }
                return null;
            }
            return null;
        }

        public async Task<bool> DeleteUrlAsync(Guid id)
        {
            var url = await GetUrlByIdAsync(id);

            if (url != null)
            {
                await _genericService.RemoveAsync(url);

                return true;
            }
            return false;
        }
    }
}
