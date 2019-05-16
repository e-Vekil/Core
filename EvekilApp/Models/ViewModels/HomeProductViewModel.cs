using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Models.ViewModels
{
    public class HomeProductViewModel
    {
        public List<CategoryLanguage> CategoryLanguages { get; set; }
        public List<SubcategoryLanguage> SubcategoryLanguages { get; set; }
    }
}
