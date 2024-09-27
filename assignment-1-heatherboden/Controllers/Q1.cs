using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1 : ControllerBase
    {
        /// <summary>
        /// Create a controller that outputs the message 
        /// "Welcome to 5125!"
        /// </summary>
        /// <returns>"Welcome to 5125!"</returns>
        /// <example>
        /// GET: http://localhost:xxx/api/Q1/Welcome
        /// </example>
        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
