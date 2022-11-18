using Automarket.DAL.Interfeces;
using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.DAL.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetByModel(string model)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Возвращает коллекцию Car асинхронно
        /// </summary>
        /// <returns></returns>
        public async Task<List<Car>> Select()
        {
            return await _db.Car.ToListAsync();
        }
    }
}
