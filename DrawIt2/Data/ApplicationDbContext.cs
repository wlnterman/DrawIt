﻿using DrawIt2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawIt2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        public ApplicationDbContext()
            : base()
        {
        }


    }
}
