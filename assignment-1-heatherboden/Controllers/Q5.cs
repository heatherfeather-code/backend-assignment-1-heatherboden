using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5 : ControllerBase
    {
        /// <summary>
        /// Recieves an HTTP Post request with body which then returns 
        /// the secret interger
        /// </summary>
        /// <param name="secretNum"> For user Input</param>
        /// <example>
        /// POST https://localhost:7144/api/Q5/secret
        /// </example>
        /// <returns>entered number from the user</returns>

        [HttpPost(template: "secret/{secretNum}")]
        [Consumes("application/json")]
        public string secretNum([FromBody] int secretNum)
        {
            return "Shhh...the secret is " + secretNum;
        }
    }
}
