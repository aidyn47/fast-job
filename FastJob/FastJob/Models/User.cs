using Microsoft.AspNetCore.Identity;
namespace FastJob.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
