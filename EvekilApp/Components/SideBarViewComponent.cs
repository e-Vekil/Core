using EvekilApp.Data;
using EvekilApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvekilApp.Core.Extensions;

namespace EvekilApp.Components
{
    public class SideBarViewComponent:ViewComponent
    {
        private readonly EvekilEntity db;
        public SideBarViewComponent(EvekilEntity _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var langId = await HttpContext.GetLanguage(db);
            List<CategoryLanguage> categoryLanguages =await db.CategoryLanguages.Where(cl=>cl.LanguageId == langId).Include(cl => cl.Category).ToListAsync(); 
            return View(categoryLanguages);
        }
    }
}
