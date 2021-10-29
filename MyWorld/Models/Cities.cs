using System.ComponentModel.DataAnnotations;

namespace MyWorld.Models
{
    public class Cities
    {
        public int Id { get; set; }

        [Display(Name = "Название города")] public string Name { get; set; }

        [Display(Name = "Население города")] public int Population { get; set; }

        [Display(Name = "Фото города")] public byte[] Photo { get; set; }
        public string PhotoType { get; set; }

        public int? CountryId { get; set; }
        
        public Countries Country { get; set; }
    }
}