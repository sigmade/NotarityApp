using DataLayer.Users.Models;

namespace DataLayer.Users
{
    public interface IUserDataProvider
    {
        Task<NotaryEntity> GetNotaryById(long id);
    }
}