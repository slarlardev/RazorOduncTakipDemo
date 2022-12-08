using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorOduncTakip.Model
{
    public class OduncIslem
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Item")]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Given")]
        public DateTime DateGive { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DateReturn { get; set; }
    }
}
