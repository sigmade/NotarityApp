using DataLayer.Users.Models;

namespace DataLayer.Files.Models
{
    public class FileEntity
    {
        public long Id { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public long UserId { get; set; }
        public UserEntity User { get; set; }
    }
}