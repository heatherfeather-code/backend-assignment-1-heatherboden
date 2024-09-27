using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4 : ControllerBase
    {
        /// <summary>
        /// Create an output that produces the beginning of a 
        /// knock knock joke
        /// </summary>
        /// <returns> a string "who's there" </returns>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {

            return "Who's there?";

        }
    }
}
