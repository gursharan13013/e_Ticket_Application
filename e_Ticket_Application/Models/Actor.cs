using System.ComponentModel.DataAnnotations;

namespace e_Ticket_Application.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name is Required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="Name should be between 3 and 50 Chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
