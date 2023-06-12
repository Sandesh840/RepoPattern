using RepoPattern.Models;
using RepoPattern.Repository.Interface;
using RepoPattern.Services.Interface;

namespace RepoPattern.Services.Implementation
{
    public class UserDetailsService : IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetailsRepository;
        public UserDetailsService(IUserDetailsRepository userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;
        }

        public UserDetails AddUserDetails(UserDetails userDetails)
        {
            return _userDetailsRepository.AddUserDetails(userDetails);
        }

        public List<UserDetails> GetAllUserName()
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            userDetails.AddRange(_userDetailsRepository.GetAllUserName());
            //extea logic
            userDetails.Add(new UserDetails()
            {
                Name="sandesh",
                Address="Kapan"
            });
            return userDetails;
        }
    }
}
