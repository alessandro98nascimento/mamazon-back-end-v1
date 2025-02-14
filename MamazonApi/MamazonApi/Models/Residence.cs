using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamazonApi.Models
{
    public class Residence
    {
        [Key]
        public int ResidenceId { get; set; }

        [Required]
        [StringLength(500)]
        public string? Adress { get; set; }

        [Required]
        public int NumberHouse { get; set; }

        [Required]
        public int Cep { get; set; }

        [Required]
        [StringLength(500)]
        public string? Neighborhood { get; set; }

        [Required]
        [StringLength(500)]
        public string? Complement { get; set; }

        [Required]
        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City? City { get; set; }

    }
}
