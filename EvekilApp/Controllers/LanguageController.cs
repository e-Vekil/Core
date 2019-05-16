using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvekilApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using EvekilApp.Core.Extensions;

namespace EvekilApp.Controllers
{
    public class LanguageController : Controller
    {
        private readonly EvekilEntity db;
        public LanguageController(EvekilEntity _Db)
        {
            db = _Db;
        }

        public async Task<IActionResult> SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            await HttpContext.SetLanguage(culture,db);

            return LocalRedirect(returnUrl);
        }
    }
}