using DataLayer.Clients;
using DataLayer.Documents.DataProvider;
using DataLayer.Files;
using DataLayer.Users;

namespace WebApi.Extension
{
    public static class DataProviderExtension
    {
        public static IServiceCollection AppDataProviders(this IServiceCollection services)
        {
            services.AddScoped<IDocDataProvider, DocDataProvider>();
            services.AddScoped<IClientDataProvider, ClientDataProvider>();
            services.AddScoped<IUserDataProvider, UserDataProvider>();
            services.AddScoped<IFilesDataProvider, FilesDataProvider>();

            return services;
        }
    }
}