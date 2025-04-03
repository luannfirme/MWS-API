using MWS.WebAPI.Middlewares;

namespace MWS.WebAPI.Configurations
{
    public static class ServiceExtensions
    {
        public static void ConfigurePresentationApp(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
