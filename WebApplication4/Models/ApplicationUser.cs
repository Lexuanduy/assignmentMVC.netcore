﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}