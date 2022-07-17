using CleanArch.Application.Intefaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourceRepository _courceRepository;

        public CourseService(ICourceRepository courceRepository)
        {
            _courceRepository = courceRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courceRepository.GetCourses()
            };
        }
    }
}
