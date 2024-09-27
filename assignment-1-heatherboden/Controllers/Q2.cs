using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2 : ControllerBase
    {
        /// <summary>
        /// Get request greets user with their supplied name
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>Greeting with supplied name</returns>
        [HttpGet(template: "Greeting/{UserName}")]
        public string Greeting(string UserName)
        {
            return "Hi " + UserName + "!";
        }

    }

}
