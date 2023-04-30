using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hello_world.Models;
using Newtonsoft.Json;
namespace hello_world.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // private readonly LinkGenerator<HomeController> _linkGenerator;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        // _linkGenerator = linkGenerator;
    }
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]


    public IActionResult Index()
    {
        return View();
    }

      private static User _User  = new User{
            username = "todd",
            fullname = "Todd Astun",
            password = "234sdfs"

        };
       // [HttpGet("[action]" , Name = "Products_list")]
    public IActionResult Privacy()
    {
      
        var json = JsonConvert.SerializeObject(_User, Formatting.Indented);
        _logger.LogInformation(json);
        //throw new Exception("Bad site");
        return View(_User) ;
    }
    [HttpPost("[action]")]
    public IActionResult Privacy(User user)
    {
        if(ModelState.IsValid)
        {
            _User.fullname = user.fullname;
            _User.username = user.username;
            _User.password = user.password;
            return  RedirectToAction("Privacy");
        }
        else
        {
            return View(user);
        }
        
    }
    public string Contact()
    {
        var   user  = new User{
            username = "todd",
            fullname = "Todd Astun",
            password = "234sdfs"

        };
        var json = JsonConvert.SerializeObject(user, Formatting.Indented);
        return json;
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
