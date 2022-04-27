using DataLayer.Clients;
using DataLayer.Clients.Models;

namespace BusinessLayer.Clients.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientDataProvider _clientDataProvider;

        public ClientService(IClientDataProvider clientDataProvider)
        {
            _clientDataProvider = clientDataProvider;
        }

        public async Task<long> AddClient(AddClientRequest request)
        {
            var clientId = await _clientDataProvider.SaveClient(new()
            {
                BirthDate = request.BirthDate,
                BirthPlace = request.BirthPlace,
                FirstName = request.FirstName,
                HomeAddress = request.HomeAddress,
                IINBIN = request.IINBIN,
                LastName = request.LastName,
                MiddleName = request.MiddleName
            });
            return clientId;
        }
    }
}