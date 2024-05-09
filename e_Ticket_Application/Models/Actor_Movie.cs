namespace e_Ticket_Application.Models
{
    public class Actor_Movie
    {
        //Actor
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        
        //Movie
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
