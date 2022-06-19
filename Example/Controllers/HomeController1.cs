using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;

namespace Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController1 : Controller
    {
        private readonly ILogger<HomeController1> _logger;

        public HomeController1(ILogger<HomeController1> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("STRING11")]
        public string Get()
        {
            return "";

        }

    }
}
