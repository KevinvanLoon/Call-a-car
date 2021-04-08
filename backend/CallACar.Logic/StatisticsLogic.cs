using System;
using System.Collections.Generic;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class StatisticsLogic
    {
        private AbstractRepository<Reservation> _reservationRepository = new ReservationRepository();

        public object GetAggregatedData(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}