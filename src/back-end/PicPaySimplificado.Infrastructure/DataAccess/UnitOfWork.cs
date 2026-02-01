using PicPaySimplificado.Domain.Repositories;

namespace PicPaySimplificado.Infrastructure.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PicPaySimplificadoDbContext _dbContext;

        public UnitOfWork(PicPaySimplificadoDbContext dbContext) => _dbContext = dbContext;

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
