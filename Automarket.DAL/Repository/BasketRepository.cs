using Automarket.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;
using System;
using Automarket.DAL.Interfeces;

namespace Automarket.DAL.Repository
{
    public class BasketRepository : IBaseRepository<Basket>
    {
        private readonly ApplicationDbContext _dbContext;

        public BasketRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Basket> GetAll()
        {
            return _dbContext.Baskets;
        }

        public Task<bool> Delete(Basket entity)
        {
            throw new NotImplementedException();
        }

        public Task<Basket> Update(Basket entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Basket entity)
        {
            throw new NotImplementedException();
        }
    }
}
