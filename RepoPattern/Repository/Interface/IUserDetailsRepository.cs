using RepoPattern.Models;

namespace RepoPattern.Repository.Interface
{
    public interface IUserDetailsRepository
    {
        List<UserDetails> GetAllUserName();
        UserDetails AddUserDetails(UserDetails userDetails);
    }
}
