using Automarket.Domain.Enam;
using System.Threading.Tasks;

namespace Automarket.Domain.Interfeces
{
    public interface IBaseResponse<T>
    {
        T Data { get; set; }
        StatusCode StatusCode { get; set; }
        string Description { get; set; }
    }
}
