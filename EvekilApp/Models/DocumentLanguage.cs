using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Models
{
    public class DocumentLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public Document Document { get; set; }
        public int DocumentId { get; set; }
        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}
