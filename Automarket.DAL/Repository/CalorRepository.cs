using Automarket.DAL.Interfeces;
using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public Task<bool> Create(Color entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(Color entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Color> GetAll()
        {
            return _db.Сolor;
        }

        public Task<List<Color>> Select()
        {
            throw new System.NotImplementedException();
        }

        public Task<Color> Update(Color entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
