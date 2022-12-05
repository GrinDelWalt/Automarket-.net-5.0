using Automarket.Domain.Entity;
using Automarket.Domain.Interfeces;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Interfeces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Create(UserViewModel model);

        BaseResponse<Dictionary<int, string>> GetRoles();

        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();

        Task<IBaseResponse<bool>> DeleteUser(long id);
    }
}
