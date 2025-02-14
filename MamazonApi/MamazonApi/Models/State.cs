using System.ComponentModel.DataAnnotations;

namespace MamazonApi.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        [StringLength(200)]
        public string? StateName { get; set; }
    }
}
