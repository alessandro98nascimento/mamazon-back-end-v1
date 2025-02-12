using System.ComponentModel.DataAnnotations;

namespace MamazonApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(200)]
        public required string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public required string Email { get; set; }

        [Required]
        [StringLength(200)]
        public required string Password { get; set; }

        [Required]
        [StringLength(500)]
        public required string Adress { get; set; }

        [Required]
        public int NumberHouse { get; set; }

        [Required]
        public int Cep { get; set; }

        [Required]
        [StringLength(500)]
        public required string Complement { get; set; }

        [Required]
        [StringLength(500)]
        public required string Neighborhood { get; set; }

        [Required]
        [StringLength(200)]
        public required string City { get; set; }

        [Required]
        [StringLength(100)]
        public required string State { get; set; }

        [Required]
        public int ActiveUser { get; set; } = 1;

    }
}
