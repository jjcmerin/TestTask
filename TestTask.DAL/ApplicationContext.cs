﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Service.Models;

namespace TestTask.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // create a database at the first request
        }
    }
}
