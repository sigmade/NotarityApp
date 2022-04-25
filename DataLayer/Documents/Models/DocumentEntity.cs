using DataLayer.Clients.Models;
using DataLayer.Users.Models;

namespace DataLayer.Documents.Models
{
    public class DocumentEntity
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Territory { get; set; }
        public string ActionTitle { get; set; }
        public string ActionDescription { get; set; }
        public long UserId { get; set; }
        public UserEntity User { get; set; }
        public long NotaryId { get; set; }
        public NotaryEntity Notary { get; set; }
        public long MajorClientId { get; set; }
        public ClientEntity MajorClient { get; set; }
        public long? MinorClientId { get; set; }
        public ClientEntity? MinorClient { get; set; }
        public DocType Type { get; set; }
        public DocSubType SubType { get; set; }
    }

    public enum DocType
    {
        Proxy,
        Deal
    }

    public enum DocSubType
    {
        Proxy,
        Deal
    }
}