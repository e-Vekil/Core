﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegisterDate { get; set; }

        [NotMapped]
        public string Roles { get; set; }
        public bool IsViewed { get; set; }
    }
}
