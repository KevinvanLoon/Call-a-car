using CallACar.Logic;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/helpdesk")]
    public class HelpdeskController: Controller
    {
        private ReservationLogic _reservationLogic = new ReservationLogic();

        [HttpGet]
        public IActionResult GetHistoryFromUser([FromQuery] int userId)
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }

        [HttpPost]
        public IActionResult RequestAccess()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
    }
}