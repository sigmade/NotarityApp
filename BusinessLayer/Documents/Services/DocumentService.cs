using BusinessLayer.Documents.Models;
using DataLayer.Documents.DataProvider;

namespace BusinessLayer.Documents.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocDataProvider _dataProvider;
        private readonly IFileService _fileService;

        public DocumentService(
            IDocDataProvider dataProvider,
            IFileService fileService)
        {
            _dataProvider = dataProvider;
            _fileService = fileService;
        }

        public async Task<string> AddProxy(AddNewDocRequest request)
        {
            await _dataProvider.SaveNewDoc(new()
            {
                DateBegin = request.DateBegin,
                DateEnd = request.DateEnd,
                ActionDescription = request.ActionDescription,
                ActionTitle = request.ActionTitle,
                DocDate = request.DocDate,
                Territory = request.Territory,
                UserId = request.UserId,
                Number = request.Number,
                MajorClientId = request.MajorClientId,
                SubType = request.SubType,
                Type = request.Type,
                MinorClientId = request.MinorsClientIds.FirstOrDefault(),
                NotaryId = request.NotaryId,
            });

            var docId = await _fileService.CreateProxy(request);

            return docId;
        }
    }
}