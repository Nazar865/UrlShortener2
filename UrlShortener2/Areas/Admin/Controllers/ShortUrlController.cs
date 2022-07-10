using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener2.Models;
using UrlShortener2.Services.Interfaces;

namespace UrlShortener2.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class ShortUrlController : Controller
    {
        private readonly IShortUrlService _urlService;

        public ShortUrlController(IShortUrlService urlService)
        {
            _urlService = urlService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var shortUrls = await _urlService.GetUrlsAsync();
            ViewBag.Urls = shortUrls;
            return View(shortUrls);
        }

        public IActionResult Short()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Short(ShortUrlModel url)
        {
            var result = await _urlService.AddUrlAsync(url);

            if (result == null)
            {
                ModelState.Clear();
                ViewData["Response"] = "This Url already exists";
                return View();
            }

            return RedirectToAction("Index", "ShortUrl");
        }

        public ActionResult DeleteUrl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUrl(Guid id)
        {
            var result = await _urlService.DeleteUrlAsync(id);

            if (!result)
            {
                return View();
            }

            return RedirectToAction("Index", "ShortUrl");
        }
    }
}
