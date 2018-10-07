using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public class ReservationSchedule
    {
        [Key]
        public int rs_id {get;set;}
        public int speed_time {get;set;}
        public List<Reservation> Reservations {get;set;}
        public ReservationSchedule()
        {
            Reservations = new List<Reservation>();
        }
    }
}