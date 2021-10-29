using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWorld.Models
{
    public class Countries
    {
        public int Id { get; set; }

        [Display(Name = "Название страны")]
        public string Name { get; set; }

        [Display(Name = "Название континента")]
        public string Continent { get; set; }

        [Display(Name = "Год создания")]
        public int Year { get; set; }

        [Display(Name = "Описание страны")]
        public string Description { get; set; }

        [Display(Name = "Название столицы")] public string Capital { get; set; }
        
        [Display(Name = "Фото страны")] public byte[] Photo { get; set; }
        public string PhotoType { get; set; }
        
        public ICollection<Cities> Cities { get; set; }
        public Countries()
        {
            Cities = new List<Cities>();
        }
    }
}