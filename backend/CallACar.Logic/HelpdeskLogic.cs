using System;
using System.Collections.Generic;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class HelpdeskLogic
    {
        private AbstractRepository<Reservation> _carRepository = new ReservationRepository();

        public IList<Reservation> GetHistoryFromUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void RequestAccess(int userId)
        {
            throw new NotImplementedException();
        }
    }
}