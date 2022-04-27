using BusinessLayer.Documents.Models;

namespace BusinessLayer.Documents.Services
{
    public interface IFileService
    {
        Task<string> CreateProxy(AddNewDocRequest request);

        Task<byte[]> GetFileByPath(string path);
    }
}