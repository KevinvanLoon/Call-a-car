using CallACar.Logic;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/reservation")]
    public class ReservationController: Controller
    {
        private ReservationLogic _reservationLogic = new ReservationLogic();

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
        
        [HttpPost]
        public IActionResult Add()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
        
        [HttpDelete]
        public IActionResult Delete()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
    }
}