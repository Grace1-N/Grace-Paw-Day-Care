namespace Paw_Day_Care.Models
{
    public class Booking
    {
        public int bookingId { get; set; }
        public int UserId { get; set; }
        public int PetSitterId { get; set; }
        public DateTime BookingDate { get; set; }

        public Booking()
        {

        }

    }
}
