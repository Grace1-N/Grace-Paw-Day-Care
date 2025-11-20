namespace Paw_Day_Care.Models
{
    public class Rating
    {
        public int ratingId { get; set; }
        public int UserId { get; set; }
        public int PetSitterId { get; set; }
        public double Score { get; set; } // 1 to 5

        public Rating() 
        { 
        
        }
    }
}
