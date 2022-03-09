﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserRegistrationMVCcore.Models
{
    public class ApplicationUserClass:DbContext
    {
        public ApplicationUserClass(DbContextOptions<ApplicationUserClass> options):base(options)
        {

        }
        public DbSet<UserClass> UserReg1 { get; set; } 
    }
}
