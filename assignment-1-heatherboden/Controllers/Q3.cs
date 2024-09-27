using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3 : ControllerBase
    {
        /// <summary>
        /// Uses the double perameter to double a given number
        /// to make the double perameter work, need the Math.Pow
        /// </summary>
        /// <param name="UserInput"></param>
        /// <returns>A multiplied int of the given number</returns>
        /// <example>
        /// GET localhost:xx/api/q3/4
        /// </example>

        [HttpGet(template: "Cube/{UserInput}")]
        public double Cube(double UserInput)
        {
            return Math.Pow(UserInput, 12);
        }
    }
}
