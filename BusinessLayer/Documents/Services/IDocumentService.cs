using BusinessLayer.Documents.Models;

namespace BusinessLayer.Documents.Services
{
    public interface IDocumentService
    {
        Task<string> AddProxy(AddNewDocRequest request);
    }
}