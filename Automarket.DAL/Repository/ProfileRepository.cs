using Automarket.DAL.Interfeces;
using Automarket.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Automarket.DAL.Repository
{
    public class ProfileRepository : IBaseRepository<Profile>
    {
        private readonly ApplicationDbContext _dbContext;

        public ProfileRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Create(Profile entity)
        {
            await _dbContext.Profiles.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public IQueryable<Profile> GetAll()
        {
            return _dbContext.Profiles;
        }

        public async Task<bool> Delete(Profile entity)
        {
            _dbContext.Profiles.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Profile> Update(Profile entity)
        {
            _dbContext.Profiles.Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
