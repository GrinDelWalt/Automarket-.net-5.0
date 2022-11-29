﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.DAL.Interfeces
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Базовый класс интефейса создания объекта (Т)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Create(T entity);
        /// <summary>
        /// Возврат объекта по ID объект типа (Т)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Get(int id);
        /// <summary>
        ///  возврат коллекции элеметов типа (Т)
        /// </summary>
        /// <returns></returns>
        Task<List<T>> Select();
        /// <summary>
        /// Удаление объекта типа (Т)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);

    }
}
