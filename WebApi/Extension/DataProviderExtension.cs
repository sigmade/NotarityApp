using DataLayer.Documents.DataProvider;

namespace WebApi.Extension
{
    public static class DataProviderExtension
    {
        public static IServiceCollection AppDataProviders(this IServiceCollection services)
        {
            services.AddScoped<IDocDataProvider, DocDataProvider>();

            return services;
        }
    }
}