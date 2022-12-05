using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Account;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Automarket.Service.Interfeces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model);
    }
}
