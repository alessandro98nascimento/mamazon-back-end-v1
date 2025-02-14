using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamazonApi.Models
{
    public class ResidencesUser
    {
        [Key]
        public int ResidencesUserId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ResidenceId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("ResidenceId")]
        public Residence? Residence { get; set; }
    }
}
