using System.ComponentModel.DataAnnotations;

namespace RazorOduncTakip.Model
{
    public class OduncIslem
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Given")]
        public DateTime DateGive { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime DateReturn { get; set; }
    }
}
