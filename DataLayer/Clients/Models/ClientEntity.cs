namespace DataLayer.Clients.Models
{
    public class ClientEntity
    {
        public long Id { get; set; }
        public string IINBIN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string HomeAddress { get; set; }
    }
}