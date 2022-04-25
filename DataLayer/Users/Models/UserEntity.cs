namespace DataLayer.Users.Models
{
    public class UserEntity
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public long NotaryId { get; set; }
        public NotaryEntity Notary { get; set; }
    }
}