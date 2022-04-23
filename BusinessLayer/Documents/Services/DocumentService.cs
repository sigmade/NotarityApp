using BusinessLayer.Documents.Models;
using DataLayer.Documents.DataProvider;

namespace BusinessLayer.Documents.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocDataProvider _dataProvider;

        public DocumentService(IDocDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public async Task AddNewDoc(AddNewDocRequest request)
        {
            await _dataProvider.SaveNewDoc(new()
            {
                DateBegin = request.DateBegin,
                DateEnd = request.DateEnd,
                ActionDescription = request.ActionDescription,
                ActionTitle = request.ActionTitle,
                DocDate = request.DocDate,
                DocTerritory = request.DocTerritory,
                EmployeeId = request.EmployeeId,
                Number = request.Number,
                PrincipalId = request.PrincipalId,
                SubType = request.SubType,
                Type = request.Type,
                СonfidantId = request.СonfidantId
            });
        }
    }
}