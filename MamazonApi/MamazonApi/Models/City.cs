using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamazonApi.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(500)]
        public string? CityName { get; set; }

        [Required]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public State? State { get; set; }
    }
}
