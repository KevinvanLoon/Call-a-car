using System;
using System.Linq;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class ReservationRepository : AbstractRepository<Reservation>
    {
        public IQueryable<Reservation> GetReservationsByUser()
        {
            throw new NotImplementedException();
        }

    }
}