using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Automarket.Domain.Enam
{
    public enum Role
    {
        [Display(Name = "Пользователь")]
        User = 0,
        [Display(Name = "Модератор")]
        Moderator = 1,
        [Display(Name = "Админ")]
        Admin = 2,
    }
}
