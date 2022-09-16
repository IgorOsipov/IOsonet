using IOsonet.Data;
using IOsonet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IOsonet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var profile = _dataContext.Profiles.Include(x => x.Friends).ThenInclude(x => x.FriendProfile).FirstOrDefault(x => x.Id == "0c71fad0-f9ae-4c10-82f3-558cda7519cf");
            var friends = profile.Friends.Select(x => x.FriendProfile).ToList();
            return View(profile);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}