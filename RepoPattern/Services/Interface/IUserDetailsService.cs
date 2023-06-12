using RepoPattern.Models;

namespace RepoPattern.Services.Interface
{
    public interface IUserDetailsService
    {
        List<UserDetails> GetAllUserName();
        UserDetails AddUserDetails(UserDetails userDetails);
    }
}
