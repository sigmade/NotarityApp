namespace DataLayer.Users.Models
{
    public class NotaryEntity
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Territory { get; set; }
        public DateTime LicenseDate { get; set; }
        public string LicenseNumber { get; set; }
    }
}