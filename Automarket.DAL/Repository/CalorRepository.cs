using Automarket.DAL.Interfeces;
using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.DAL.Repository
{
    public class CalorRepository : ICalorRepository
    {
        private readonly ApplicationDbContext _db;

        public CalorRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<bool> Create(Calor entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(Calor entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Calor> Get(int id)
        {
            return await _db.calors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Calor>> Select()
        {
            throw new System.NotImplementedException();
        }

        public Task<Calor> Update(Calor entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
