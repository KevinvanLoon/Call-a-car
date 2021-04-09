using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class CarRepository : AbstractRepository<Car>
    {
        public CarRepository()
        {
            Entities = DatabaseMock.Cars.ToList();
        }
    }
}