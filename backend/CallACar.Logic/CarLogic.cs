using System;
using System.Collections.Generic;
using System.Linq;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class CarLogic
    {
        private CarRepository _carRepository = new CarRepository();

        public IList<Car> GetCars()
        {
            return this._carRepository.Get().ToList();
        }

        public Car GetCarById(int carId)
        {
            return this._carRepository.GetSingle(carId);
        }
        
        public void AddCar(Car car){
            this._carRepository.Add(car);
        }

        public void Update(int carId, Car car)
        {
            this._carRepository.Update(carId, car);
        }

        public void Remove(int carId)
        {
            this._carRepository.Delete(carId);
        }
    }
}