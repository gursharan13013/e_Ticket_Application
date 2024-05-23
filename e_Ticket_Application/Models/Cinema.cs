using System.ComponentModel.DataAnnotations;

namespace e_Ticket_Application.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema Image")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
