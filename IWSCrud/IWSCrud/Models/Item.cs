using System.ComponentModel.DataAnnotations;

namespace IWSCrud.Models
{
    public class Item
    {
        [Key]
        public int idItem { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio")]
        [Display(Name = "Tipo")]
        public int Type { get; set; }

        [Display(Name ="Activa")]
        public string Active { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }



}
