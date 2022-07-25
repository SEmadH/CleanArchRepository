﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext()
        {

        }
        public UniversityDBContext(DbContextOptions options): base (options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
