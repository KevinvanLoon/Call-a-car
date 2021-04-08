using System;
using CallACar.Logic;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/payment")]
    public class PaymentController: Controller
    {
        private PaymentLogic _paymentLogic = new PaymentLogic();

        [HttpPost]
        public IActionResult VerifyPayment()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
    }
}