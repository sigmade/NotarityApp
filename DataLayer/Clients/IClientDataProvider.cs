using DataLayer.Clients.Models;

namespace DataLayer.Clients
{
    public interface IClientDataProvider
    {
        Task<ClientEntity> GetClientById(long id);

        Task<long> SaveClient(ClientEntity client);
    }
}