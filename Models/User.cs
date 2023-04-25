using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheffield_Car_Park_System.Models
{
    public class User
    {
    
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(200)]
        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }

        [EmailAddress()]
        [Required(ErrorMessage = "Email address is required")]
        public string? EmailAddress { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; } 

    }
}