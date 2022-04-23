using DataLayer.Documents.Models;

namespace DataLayer.Documents.DataProvider
{
    public interface IDocDataProvider
    {
        Task SaveNewDoc(DocumentEntity document);
    }
}