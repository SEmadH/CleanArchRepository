using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            ctx = _ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
