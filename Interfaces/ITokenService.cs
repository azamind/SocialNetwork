using SocialNetworkProject.Entities;

namespace SocialNetworkProject.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}
