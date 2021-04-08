using System;
using System.Collections.Generic;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class CarLogic
    {
        private AbstractRepository<Car> _carRepository = new CarRepository();

        public IList<Car> GetCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int carId)
        {
            throw new NotImplementedException();
        }
        
        public void AddCar(Car car){
            throw new NotImplementedException();
        }

        public void Update(int carId, Car car)
        {
            throw new NotImplementedException();
        }

        public void Remove(int carId)
        {
            throw new NotImplementedException();
        }
    }
}