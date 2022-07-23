using CleanArc.Infra.Bus;
using CleanArch.Application.Intefaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.CommandHandler;
using CleanArch.Domain.Commands;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.IoC
{
    public class DependecyContainer
    {
        public static void RegisterSevices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemmoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UnivesityDBContext>();
        }
    }
}
