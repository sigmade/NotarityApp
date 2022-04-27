using DataLayer.Clients.Models;

namespace BusinessLayer.Clients.Services
{
    public interface IClientService
    {
        Task<long> AddClient(AddClientRequest request);
    }
}
