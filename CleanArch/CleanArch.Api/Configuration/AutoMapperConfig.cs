using CleanArch.Application.AutoMapper;

namespace CleanArch.Api.Configuration
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapprConfiguration));
            AutoMapprConfiguration.RegisterMappings();
        }
    }
}
