using System.ComponentModel.DataAnnotations;

namespace IWSCrud.Models
{
    public class CatalogTypes
    {
        [Key]
        public int idTypes { get; set; }

        [Display(Name ="Nombre")]
        public string Name { get; set; }
    }
}
