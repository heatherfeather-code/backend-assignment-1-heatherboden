using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6 : ControllerBase
    {
        /// <summary>
        /// function that doubles the area, and side of a hexagon 
        /// to produce the interger result
        /// </summary>
        /// <param name="hexagonSide">Holds the side of a hexagon to then be doubled</param>
        /// <returns>program returns the area of a hexagon</returns>
        [HttpGet(template: "{hexagonSide}")]

        public double HexagonArea (double hexagonSide)
        {
            double hexagon = (3 * Math.Sqrt(3) / 2) * (Math.Pow(hexagonSide, 2));

            return hexagon;
        }
    }
}
