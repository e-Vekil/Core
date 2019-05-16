using EvekilApp.Data;
using EvekilApp.Models;
using EvekilApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvekilApp.Core.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EvekilApp.Components
{
    public class HomeProductViewComponent: ViewComponent
    {
        private readonly EvekilEntity db;
        public HomeProductViewComponent(EvekilEntity _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var langId = await HttpContext.GetLanguage(db);
            HomeProductViewModel model = new HomeProductViewModel()
            {
                CategoryLanguages = await db.CategoryLanguages.Where(cl => cl.LanguageId == langId).Include(cl => cl.Category).ToListAsync(),
                SubcategoryLanguages = await db.SubcategoryLanguages.Where(sl => sl.LanguageId == langId).Include(sl=>sl.Subcategory).ToListAsync()
            };
            return View(model);
        }
    }
}
