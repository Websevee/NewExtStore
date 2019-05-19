using Microsoft.AspNet.Identity.EntityFramework;

namespace ExtStore.Models.User
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public User()
        {
        }
    }
}