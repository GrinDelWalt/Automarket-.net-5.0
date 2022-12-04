using Automarket.DAL.Interfeces;
using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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


        public async Task<bool> Create(Car entity)
        {
            await _db.Car.AddAsync(entity);
            await _db.SaveChangesAsync();     //обязательная инструкция для обновления данных в бд

            return true;
        }

        public async Task<bool> Delete(Car entity)
        {
            _db.Car.Remove(entity);
            await _db.SaveChangesAsync();     //обязательная инструкция для обновления данных в бд

            return true;
        }

        public async Task<Car> Get(int id)
        {
            return await _db.Car.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Car> GetByModelAsync(string model)
        {
            return await _db.Car.FirstOrDefaultAsync(x => x.Model == model);
        }
        /// <summary>
        /// Возвращает коллекцию Car асинхронно
        /// </summary>
        /// <returns></returns>
        public async Task<List<Car>> Select()
        {
            return await _db.Car.ToListAsync();
        }

        public async Task<Car> Update(Car entity)
        {
            _db.Car.Update(entity);
            await _db.SaveChangesAsync();     //обязательная инструкция для обновления данных в бд
            return entity;
        }
    }
}
