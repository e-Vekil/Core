using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Models
{
    public class PropertySubcategory
    {
        public int Id { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
        public Document Document { get; set; }
        public int DocumentId { get; set; }
    }
}
