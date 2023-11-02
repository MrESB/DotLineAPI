using DotLineAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotLineAPI.Controllers
{
    public class DotController : ControllerBase
    {
        IDotLine dotline;
        public DotController(IDotLine dotLine)
        {
            this.dotline = dotLine;
        }

        public IActionResult Index()
        {
            return Ok("please enter coordinates at the order below:" +
                "\n x1, y1, x2, y2, x3, y3" +
                "\n request example: http://localhost:5230/Dot/IsOnALine/?x1=3&y1=11&x2=2&y2=9&x3=0&y3=5");
        }
        public IActionResult IsonALine(string x1, string y1, string x2, string y2, string x3, string y3)
        {
            try
            {
                double X1 = Convert.ToDouble(x1);
                double Y1 = Convert.ToDouble(y1);
                double X2 = Convert.ToDouble(x2);
                double Y2 = Convert.ToDouble(y2);
                double X3 = Convert.ToDouble(x3);
                double Y3 = Convert.ToDouble(y3);
                return Ok(dotline.IsOnALine(X1, Y1, X2, Y2, X3, Y3));
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
