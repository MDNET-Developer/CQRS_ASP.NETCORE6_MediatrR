using CQRS_ASP.NETCore6.CQRS.Handlers;

namespace CQRS_ASP.NETCore6.Extension
{
    public static class CustomExntensionProgramcs
    {
        public static void CustomService(this IServiceCollection services)
        {
            services.AddScoped<GetStudentByIdQueryHandler>();
            services.AddScoped<GetAllStudentsQueryHandler>();
            services.AddScoped<CreateStudendCommandHandler>();
            services.AddScoped<UpdateStudentCommandHandler>();
            services.AddScoped<DeleteStudentCommandHandler>();
        }
    }
}
