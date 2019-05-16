using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Tagname { get; set; }
        public Document Document { get; set; }
        public int DocumentId { get; set; }
    }
}
