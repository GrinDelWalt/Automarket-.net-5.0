using Automarket.Domain.Interfeces;
using Automarket.Domain.ViewModels.Order;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Interfeces
{
    public interface IBaskedServise
    {
        Task<IBaseResponse<IEnumerable<OrderViewModel>>> GetItems(string userName);

        Task<IBaseResponse<OrderViewModel>> GetItem(string userName, long id);
    }
}
