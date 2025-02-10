using System.ComponentModel.DataAnnotations;

namespace MamazonApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(200)]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string? Email { get; set; }

        [Required]
        [StringLength(200)]
        public string? Password { get; set; }

        [Required]
        [StringLength(500)]
        public string? Adress { get; set; }

        [Required]
        public int NumberHouse { get; set; }

        [Required]
        public int Cep { get; set; }

        [Required]
        [StringLength(500)]
        public string? Complement { get; set; }

        [Required]
        [StringLength(500)]
        public string? Neighborhood { get; set; }

        [Required]
        [StringLength(200)]
        public string? City { get; set; }

        [Required]
        [StringLength(100)]
        public string? State { get; set; }

        [Required]
        public int ActiveUser { get; set; } = 1;

    }
}
