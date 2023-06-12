using RepoPattern.Data;
using RepoPattern.Models;
using RepoPattern.Repository.Interface;

namespace RepoPattern.Repository.Implementation
{
    public class UserDetailRepository : IUserDetailsRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserDetailRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public UserDetails AddUserDetails(UserDetails userDetails)
        {
            _applicationDbContext.UserDetails.Add(userDetails);
            _applicationDbContext.SaveChanges();
            return userDetails;
        }

        public List<UserDetails> GetAllUserName()
        {
            return _applicationDbContext.UserDetails.ToList();
        }
    }
}
