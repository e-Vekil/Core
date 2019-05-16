using EvekilApp.Data;
using EvekilApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Core.Extensions
{
    public static class HttpContextExtensions
    {
        public static async Task SetLanguage(this HttpContext context,string culture,EvekilEntity db)
        {
            Language language = await db.Languages.Where(l => l.Key == culture).FirstOrDefaultAsync();
            context.Session.SetString("langId", language.Id.ToString());
            context.Session.SetString("langKey", language.Key);
        }

        public static async Task<int> GetLanguage(this HttpContext context, EvekilEntity db)
        {
            int languageId = await db.Languages.Where(l => l.Key == context.Session.GetString("langKey")).Select(l=>l.Id).FirstOrDefaultAsync();
            return languageId;
        }
    }
}
