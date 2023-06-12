using Microsoft.AspNetCore.Mvc;
using RepoPattern.Models;
using RepoPattern.Services.Interface;
using System.Diagnostics;

namespace RepoPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDetailsService _userDetailsService;
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger, IUserDetailsService userDetailsService)
        {
            _logger = logger;
            _userDetailsService = userDetailsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllUser()
        {
            List<UserDetails> userDetails= _userDetailsService.GetAllUserName();
            return View(userDetails);
        }
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult SaveUser(UserDetails userDetails)
        {
           var user=_userDetailsService.AddUserDetails(userDetails);
            return RedirectToAction("GetAllUser");
        }

    }
}