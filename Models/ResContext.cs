using Microsoft.EntityFrameworkCore;
 
namespace Reservation.Models
{
    public class ResContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public ResContext(DbContextOptions<ResContext> options) : base(options) { }
            public DbSet<Reservation> reservations {get;set;}
            public DbSet<ReservationSchedule> reservation_schedule {get;set;}
    }
}