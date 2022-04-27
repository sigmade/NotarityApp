using DataLayer.Clients.Models;
using DataLayer.EF;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Clients
{
    public class ClientDataProvider : IClientDataProvider
    {
        private readonly ApplicationDbContext _dbContext;

        public ClientDataProvider(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ClientEntity> GetClientById(long id)
        {
            return await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<long> SaveClient(ClientEntity client)
        {
            _dbContext.Clients.Add(client);
            await _dbContext.SaveChangesAsync();
            return client.Id;
        }
    }
}