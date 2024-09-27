using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace assignment_1_heatherboden.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8 : ControllerBase
    {
        ///<summary>
        ///Takes price of diff size plushies and calculates the tax added and final cost
        ///
        /// </summary>
        /// <example>
        /// 
        /// </example>
        /// <returns> String of individual pricing, added pricing, and combined final total </returns>
        [HttpPost(template: "SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm] int NumSmallPlush, [FromForm] int NumLargePlush)
        {
            //Floats for additional variables   
            float Tax = 0.13f;


            //sub total of small
            float SmallPlushPrice = 25.50f;
            //sub total of larges
            float LargePlushPrice = 40.50f;
            //Small Plus Subtotal
            float SmallSubtotal = (NumSmallPlush * SmallPlushPrice);
            //Large Plush Subtotal
            float LargeSubtotal = (NumLargePlush * LargePlushPrice);

            //Total Subtotal:
            float Subtotal = SmallSubtotal + LargeSubtotal;

            //tax for total incld. HST at end of line
            float TotalTax = Subtotal * Tax;

            //final total price
            float FinalTotal = Subtotal + TotalTax;


            //Format variables into strings to output the final return!
            string formattedSmallPlushPrice = SmallPlushPrice.ToString("C", CultureInfo.CurrentCulture);
            string formattedLargePlushPrice = LargePlushPrice.ToString("C", CultureInfo.CurrentCulture);
            string formattedSmallSubtotal = SmallSubtotal.ToString("C", CultureInfo.CurrentCulture);
            string formattedLargeSubtotal = LargeSubtotal.ToString("C", CultureInfo.CurrentCulture);
            string formattedSubtotal = Subtotal.ToString("C", CultureInfo.CurrentCulture);
            string formattedTotalTax = TotalTax.ToString("C", CultureInfo.CurrentCulture);
            string formattedFinalTotal = FinalTotal.ToString("C", CultureInfo.CurrentCulture);

            //Final output of calculation

            return NumSmallPlush + " small @ " + formattedSmallPlushPrice + "; " + NumLargePlush + " large @ " + formattedLargePlushPrice + "; Subtotal= " + formattedSubtotal + "; Tax= " + formattedTotalTax + " HST; Total= " + formattedFinalTotal;

        }
    }
}
