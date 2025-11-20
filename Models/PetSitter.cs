namespace Paw_Day_Care.Models
{
    public class PetSitter
    {
        public int petsitterID { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
        public string Area { get; set; }
        public string AvailableTimes { get; set; }
        public double Rating { get; set; }

        public PetSitter() 
        {
        
        }
    }
}
