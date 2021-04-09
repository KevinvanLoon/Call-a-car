using System;
using System.Collections.Generic;
using System.Linq;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class HelpdeskLogic
    {
        private ReservationRepository _reservationRepository = new ReservationRepository();

        public IList<Reservation> GetHistoryFromUser(int userId)
        {
            return this._reservationRepository.GetReservationsByUser(userId).ToList();
        }

        public void RequestAccess(int userId)
        {
            throw new NotImplementedException();
        }
    }
}