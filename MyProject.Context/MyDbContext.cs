﻿using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Context
{
    public class MyDbContext:DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DvoriDbName;Trusted_Connection=True");
        }
    }
}
