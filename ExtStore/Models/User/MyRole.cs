using Microsoft.AspNet.Identity.EntityFramework;

namespace ExtStore.Models.User
{
    public class MyRole : IdentityRole
    {
        public MyRole() { }

        public string Description { get; set; }
    }
}