using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
    }
}
