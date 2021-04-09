using CallACar.Logic;
using CallACarr.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/reservation")]
    public class ReservationController: Controller
    {
        private ReservationLogic _reservationLogic = new ReservationLogic();

        [HttpGet]
        public IActionResult Get([FromQuery] int userId)
        {
            
            return new OkObjectResult(_reservationLogic.GetMyReservations(userId));
        }
        
        [HttpPost]
        public IActionResult Add([FromBody] Reservation reservation)
        {
            _reservationLogic.Reserve(reservation);
            
            return new OkResult();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _reservationLogic.DeleteReservation(id);
            
            return new OkResult();
        }
    }
}