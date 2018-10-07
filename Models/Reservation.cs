using System;
using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public abstract class BaseEntity 
    {
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}
    }
    public class Reservation : BaseEntity
    {
        [Key]
        public int reserve_id {get;set;}
        public string first_name {get;set;}
        public string last_name {get;set;}
        public DateTime time {get;set;}
        public DateTime date {get;set;}
        public int rs_id {get;set;}
        public ReservationSchedule Schedule {get;set;}
        public Reservation()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
    }
}