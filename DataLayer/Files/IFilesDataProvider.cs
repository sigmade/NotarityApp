using DataLayer.Files.Models;

namespace DataLayer.Files
{
    public interface IFilesDataProvider
    {
        Task AddNewFile(FileEntity file);
    }
}