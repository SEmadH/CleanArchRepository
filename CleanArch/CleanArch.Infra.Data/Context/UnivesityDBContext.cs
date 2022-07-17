using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UnivesityDBContext: DbContext
    {
        public UnivesityDBContext(DbContextOptions options): base (options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
