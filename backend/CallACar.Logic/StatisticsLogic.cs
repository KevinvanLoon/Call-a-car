using System;
using System.Collections.Generic;
using System.Linq;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class StatisticsLogic
    {
        private AbstractRepository<Reservation> _reservationRepository = new ReservationRepository();

        public object GetAggregatedData(DateTime from, DateTime to)
        {
            // we return everything where the reservation starting date was between the two given dates
            return this._reservationRepository.Get().Where(r => r.From >= from && r.From < to);
        }
    }
}