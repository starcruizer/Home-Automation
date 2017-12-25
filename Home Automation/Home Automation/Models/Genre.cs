using System.ComponentModel.DataAnnotations;

namespace Home_Automation.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}