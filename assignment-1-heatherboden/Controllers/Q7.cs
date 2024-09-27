using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7 : ControllerBase
    {
        /// <summary>
        /// create a timemachine to tell the date in YYYY-MM-DD format
        /// </summary>
        /// <param name="Days">holds the value of number of days to offset by</param>
        /// <returns></returns>
        [HttpGet(template: "TimeMachine")]
        public string TimeMachine(int Days)
        {

            DateTime thisDay = DateTime.Today;
            DateTime modifiedDate = thisDay.AddDays(Days);
            return modifiedDate.ToString("yyyy-MM-dd");




        }
    }
}
