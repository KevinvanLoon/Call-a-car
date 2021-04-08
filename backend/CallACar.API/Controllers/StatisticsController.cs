using System;
using CallACar.Logic;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/statistics")]
    public class StatisticsController: Controller
    {
        private ReservationLogic _reservationLogic = new ReservationLogic();

        [HttpGet]
        public IActionResult GetAggregateData(DateTime from, DateTime to)
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
    }
}