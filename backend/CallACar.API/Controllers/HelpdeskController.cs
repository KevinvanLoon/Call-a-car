using System;
using System.Linq;
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
            // in advance there should be a check if I have got 
            return new OkObjectResult(this._reservationLogic.GetMyReservations(userId).Where(r => r.To < DateTime.Today));
        }

        [HttpPost]
        public IActionResult RequestAccess()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
    }
}