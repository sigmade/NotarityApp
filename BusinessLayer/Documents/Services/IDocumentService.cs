using BusinessLayer.Documents.Models;

namespace BusinessLayer.Documents.Services
{
    public interface IDocumentService
    {
        Task AddProxy(AddNewDocRequest request);
    }
}