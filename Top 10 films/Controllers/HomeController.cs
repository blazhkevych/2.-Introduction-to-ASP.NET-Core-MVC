//// Import necessary namespaces

//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;
//using Top_10_films.Models;

//// Define the namespace for the controller
//namespace Top_10_films.Controllers;

//// Define the HomeController class which inherits from the Controller base class
//public class HomeController : Controller
//{
//    // Declare a private readonly variable for the ILogger interface
//    private readonly ILogger<HomeController> _logger;

//    // Define the HomeController constructor which takes an ILogger<HomeController> as a parameter
//    public HomeController(ILogger<HomeController> logger)
//    {
//        // Assign the logger parameter to the _logger variable
//        _logger = logger;
//    }

//    // Define the Index action which returns the Index view
//    public IActionResult Index()
//    {
//        return View();
//    }

//    // Define the Privacy action which returns the Privacy view
//    public IActionResult Privacy()
//    {
//        return View();
//    }

//    // Define the Error action which returns the Error view
//    // The ResponseCache attribute specifies that the response should not be stored and the duration of the cache should be 0
//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//    public IActionResult Error()
//    {
//        // Return the Error view with a new ErrorViewModel
//        // The RequestId is set to the current Activity Id or the TraceIdentifier if the current Activity is null
//        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }
//}

