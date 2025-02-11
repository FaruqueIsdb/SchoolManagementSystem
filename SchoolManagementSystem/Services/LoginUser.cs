using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Services
{
    //[Keyless]
    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IList<string>? Roles { get; set; }
    }
}
