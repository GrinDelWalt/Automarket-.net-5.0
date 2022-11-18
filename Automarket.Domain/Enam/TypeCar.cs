using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.Enam
{
    public enum TypeCar
    {
        [Display(Name = "Кабриолет")]
        Body = 0,
        [Display(Name = "Седан")]
        Sedan = 1,
        [Display(Name = "Хатчбек")]
        HatchBack = 2,
        [Display(Name = "")]
        Coupe = 3, 
        [Display(Name = "Купе")]
        StationWagon = 4,
        [Display(Name = "Кроссовер")]
        Crossover = 5,
    }
}
