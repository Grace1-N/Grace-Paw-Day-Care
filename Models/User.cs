using System.Globalization;

namespace Paw_Day_Care.Models
{
    public class User
    {
        public int userId {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin or User 

        public User()
        {

        }
    }
}
