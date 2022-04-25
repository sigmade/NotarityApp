using DataLayer.EF;
using DataLayer.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Users
{
    public class UserDataProvider : IUserDataProvider
    {
        private readonly ApplicationDbContext _dbContext;

        public UserDataProvider(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<NotaryEntity> GetNotaryById(long id)
        {
            return await _dbContext.Notaries.FirstOrDefaultAsync(n => n.Id == id);
        }
    }
}