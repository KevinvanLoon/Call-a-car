using System;
using System.Linq;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class ReservationRepository : AbstractRepository<Reservation>
    {
        
        public ReservationRepository(){
            Entities = DatabaseMock.Reservations.ToList();
        }
        
        public IQueryable<Reservation> GetReservationsByUser(int userId)
        {
            throw new NotImplementedException();
        }

    }
}