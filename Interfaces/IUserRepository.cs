using SocialNetworkProject.DTOs;
using SocialNetworkProject.Entities;
using SocialNetworkProject.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetworkProject.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<Pagination<MemberDTO>> GetMembersAsync(UserParams userParams);
        Task<MemberDTO> GetMemberAsync(string username);
    }
}
