using DataLayer.EF;
using DataLayer.Files.Models;

namespace DataLayer.Files
{
    public class FilesDataProvider : IFilesDataProvider
    {
        private readonly ApplicationDbContext _dbContext;

        public FilesDataProvider(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddNewFile(FileEntity file)
        {
            _dbContext.Add(file);
            await _dbContext.SaveChangesAsync();
        }
    }
}