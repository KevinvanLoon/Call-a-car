using System;
using CallACar.Logic;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/statistics")]
    public class StatisticsController: Controller
    {
        private StatisticsLogic _statisticsLogic = new StatisticsLogic();

        [HttpGet]
        public IActionResult GetAggregateData(DateTime from, DateTime to)
        {
            return new OkObjectResult(this._statisticsLogic.GetAggregatedData(from, to));
        }
    }
}