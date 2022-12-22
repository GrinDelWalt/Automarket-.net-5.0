using Automarket.DAL.Interfeces;
using Automarket.Domain.Interfeces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Interfeces
{
    public interface IColorService
    {
        Task<IBaseRepository<IColorService>> GetColor(int id);
        Task<IBaseResponse<IEnumerable<IColorService>>> GetColorsAsync(int id);
    }
}
