using BusinessLayer.Documents.Services;
using WebApi.monitoring.Errors;

namespace WebApi.Extension
{
    public static class AppServicesExtenisons
    {
        public static IServiceCollection AppServices(this IServiceCollection services)
        {
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IErrorHandler, ErrorHandler>();
            services.AddScoped<IFileService, FileService>();

            return services;
        }
    }
}