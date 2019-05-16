using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Models
{
    public class PropertyLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Language Language { get; set; }
        public int LanguageId { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
    }
}
