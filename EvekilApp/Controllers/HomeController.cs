using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EvekilApp.Models;
using EvekilApp.Core.Extensions;
using EvekilApp.Data;

namespace EvekilApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly EvekilEntity db;
        public HomeController(EvekilEntity _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            //if language is not setted
            var languageId = await HttpContext.GetLanguage(db);
            if (languageId == 0)
            {
                return RedirectToAction("SetLanguage","Language", new { culture = "en", returnUrl = "/" });
            }

            return View();
        }
    }
}
