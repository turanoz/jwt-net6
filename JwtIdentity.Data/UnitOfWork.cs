using JwtIdentity.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace JwtIdentity.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
