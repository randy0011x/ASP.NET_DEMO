using Microsoft.AspNetCore.Mvc;
namespace hello_world.Controllers
{
    public class BlogController:Controller

    {
        [Route("Blog/{id:int}")] //attribute routing
        public IActionResult Story(int id)
        {
            return Content(id.ToString());
        }
    }
}