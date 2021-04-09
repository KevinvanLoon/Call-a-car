using System;
using System.Collections.Generic;
using System.Linq;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class ReservationLogic
    {
        private ReservationRepository _reservationRepository = new ReservationRepository();
        
        public IList<Reservation> GetMyReservations(int userId)
        {
            return this._reservationRepository.GetReservationsByUser(userId).ToList();
        }

        public void Reserve(Reservation reservation)
        {
            this._reservationRepository.Add(reservation);
        }

        public void DeleteReservation(int reservationId)
        {
            this._reservationRepository.Delete(reservationId);
        }
    }
}