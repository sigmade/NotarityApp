using DataLayer.Documents.Models;

namespace BusinessLayer.Documents.Models
{
    public class AddNewDocRequest
    {
        public string Number { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Territory { get; set; }
        public string ActionTitle { get; set; }
        public string ActionDescription { get; set; }
        public long UserId { get; set; }
        public long NotaryId { get; set; }
        public long MajorClientId { get; set; }
        public List<long> MinorsClientIds { get; set; }
        public DocType Type { get; set; }
        public DocSubType SubType { get; set; }
    }
}