using DataLayer.Documents.Models;
using DataLayer.EF;

namespace DataLayer.Documents.DataProvider
{
    public class DocDataProvider : IDocDataProvider
    {
        private readonly ApplicationDbContext _dbContext;

        public DocDataProvider(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task SaveFilePath(DocumentEntity document)
        {
            throw new NotImplementedException();
        }

        public async Task SaveNewDoc(DocumentEntity document)
        {
            _dbContext.Add(document);
            await _dbContext.SaveChangesAsync();
        }
    }
}