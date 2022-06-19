using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text;

namespace Example.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("STRING")]
        public string Get()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"HOME CONTROLLER");
            sb.AppendLine($"cALLED");
            _logger.LogInformation(sb.ToString());
            return "";

        }

    }
}
