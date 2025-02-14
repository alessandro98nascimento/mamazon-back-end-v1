using System.ComponentModel.DataAnnotations;

namespace MamazonApi.Models
{
    public class Password
    {
        [Key]
        public int PasswordId { get; set; }

        [Required]
        [StringLength(200)]
        public string? UserPassword { get; set; }
    }
}
