using MA_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Reflection;
using MA_LAB1.Infrastructure;

namespace MA_LAB1.Controllers
{
	public class HomeController : Controller
	{

		private static Account a1 = new Account();
		private IAccountRepository _accounRepository;
		private IRouteRepository _irouteRepository;
		private ITruckRepository _itruckRepository;

		private readonly ILogger<HomeController> _logger;



		public HomeController(ILogger<HomeController> logger, IAccountRepository accounRepository, IRouteRepository irouteRepository, ITruckRepository itruckRepository)
		{
			_logger = logger;
			_accounRepository = accounRepository;
			_irouteRepository = irouteRepository;
			_itruckRepository = itruckRepository;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ActionFunction(Account a)
		{
			if (ModelState.IsValid)
			{
				foreach (var item in _accounRepository.GetAllUsers)
				{

					if ((item.Email).Equals(a.Email))
					{

						Response.WriteAsync("<script>alert('A user with this email address already exists, do you want to login? ');</script>");
						return View("Login");
					}
				}
				Response.WriteAsync("<script>alert('Successfully sign up!');</script>");
				_accounRepository.SaveAccount(a);
				return View("Login");
			}
			return View("Index");
		}

		public IActionResult GotoLogin()
		{
			return View("login");
		}

		[HttpPost]
		public IActionResult login(Account a)
		{
			foreach (var item in _accounRepository.GetAllUsers)
			{
				if ((item.Email).Equals(a.Email) && (item.Password).Equals(a.Password))
				{
					a = item;
					a1 = a;
					Response.WriteAsync("<script>alert('Login successful');</script>");
					return View("Dashboard", a1);
				}
			}
			Response.WriteAsync("<script>alert('Invalid email or password. Please try again');</script>");

			return View("login");
		}

		public IActionResult Bdash()
		{

			return View("Dashboard", a1);
		}

		public IActionResult GotoTruck()
		{
			return View("Truck", new DataOutput
			{
				Trucks = _itruckRepository.GetAllTrucks,
				Truck = new Models.Truck(),
				Routes = _irouteRepository.GetAllRoutes
			});
		}


		public IActionResult GotoRoute()
		{

			return View("Route", new DataOutput
			{
				Routes = _irouteRepository.GetAllRoutes,
				Route = new Models.Route()
			});
		}

		[HttpPost]
          public IActionResult AddRoute(DataOutput r)
          {
			
				_irouteRepository.SaveRoute(r.Route);
				Response.WriteAsync("<script>alert('Add Successful!');</script>");
				return View("Dashboard", a1);
		
        }  
        [HttpPost]
        public IActionResult AddTruck(DataOutput t)
        {
			
				_itruckRepository.SaveTruck(t.Truck);

				Response.WriteAsync("<script>alert('Add Successful!');</script>");
				return View("Dashboard", a1);
			
           
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