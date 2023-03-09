using Microsoft.AspNetCore.Mvc;
using PeriodTracker.BLL.Interfaces;
using PeriodTracker.BLL.Models;

namespace PeriodTracker.MVC.Controllers
{
    public class PeriodTrackerController: Controller
    {
        private readonly IUserServices _userServices;
        private readonly IPeriodTrackerServices _periodTrackerServices;
        public PeriodTrackerController(IUserServices userServices, IPeriodTrackerServices periodTrackerServices) 
        {
            _userServices = userServices;
            _periodTrackerServices = periodTrackerServices;
        }

        public IActionResult Index()
        {
            var model = _userServices.GetUsersWithTrackerVM();
            return View(model);
        }
    }
}
