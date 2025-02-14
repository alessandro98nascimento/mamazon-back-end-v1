using System.ComponentModel.DataAnnotations;

namespace MamazonApi.Models
{
    public class Email
    {
        [Key]
        public int EmailId  { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public  string? UserEmail {  get; set; }
    }
}
