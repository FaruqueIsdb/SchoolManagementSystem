using SchoolManagementSystem.SecurityModels;

namespace SchoolManagementSystem.Services
{
    public interface ITokenService
    {
        string CreateToken(ApplicationUser user);
    }
}
