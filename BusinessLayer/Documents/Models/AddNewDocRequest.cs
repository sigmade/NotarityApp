namespace BusinessLayer.Documents.Models
{
    public class AddNewDocRequest
    {
        public int Number { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string DocTerritory { get; set; }
        public string ActionTitle { get; set; }
        public string ActionDescription { get; set; }
        public string EmployeeId { get; set; }
        public long PrincipalId { get; set; }
        public long СonfidantId { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
    }
}