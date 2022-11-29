using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.Enam
{
    public enum TypeCar
    {
        [Display(Name = "Кабриолет")]
        Кабриолет = 0,
        [Display(Name = "Седан")]
        Седан = 1,
        [Display(Name = "Хатчбек")]
        Хатчбек = 2,
        [Display(Name = "Купе")]
        Купе = 3,
        [Display(Name = "Универсал")]
        Универсал = 4,
        [Display(Name = "Кроссовер")]
        Кроссовер = 5,
    }
}
