using System;
using System.Collections.Generic;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class ReservationLogic
    {
        private AbstractRepository<Reservation> _reservationRepository = new ReservationRepository();
        
        public IList<Reservation> GetMyReservations(int userId)
        {
            throw new NotImplementedException();
        }

        public void Reserve(int carId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}