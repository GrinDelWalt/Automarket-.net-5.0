using Automarket.DAL.Interfeces;
using Automarket.Domain.Interfeces;
using Automarket.Service.Interfeces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Implementations
{
    public class ColorService : IColorService
    {
        public Task<IBaseRepository<IColorService>> GetColor(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IBaseResponse<IEnumerable<IColorService>>> GetColorsAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
