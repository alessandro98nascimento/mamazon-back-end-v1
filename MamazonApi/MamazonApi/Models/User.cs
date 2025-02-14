using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public required int EmailId { get; set; }

        [Required]
        public required int PasswordId { get; set; }

        [Required]
        public required int ActiveUser { get; set; } = 1;

        [ForeignKey("EmailId")]
        public Email? Email { get; set; }

        [ForeignKey("PasswordId")]
        public Password? Password { get; set; }
    }
}
