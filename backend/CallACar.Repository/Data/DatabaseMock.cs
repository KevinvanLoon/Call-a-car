using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class DatabaseMock
    {
        public static IQueryable<Car> Cars = new List<Car>
        {
            new Car
            {
                Id = 1,
                Brand = "Tesla",
                Type = "Model S",
                Seats = 5,
                Kenteken = "AA-AG-11"
            },
            new Car
            {
                Id = 2,
                Brand = "Tesla",
                Type = "Model S",
                Seats = 5,
                Kenteken = "AA-AG-12"
            },
            new Car
            {
                Id = 3,
                Brand = "Tesla",
                Type = "Model S",
                Seats = 5,
                Kenteken = "AA-AG-13"
            },
            new Car
            {
                Id = 4,
                Brand = "Tesla",
                Type = "Model S",
                Seats = 5,
                Kenteken = "AA-AG-14"
            },
            new Car
            {
                Id = 5,
                Brand = "Waymo",
                Type = "Selfdriving XL",
                Seats = 7,
                Kenteken = "WA-YM-01"
            },
            new Car
            {
                Id = 6,
                Brand = "Waymo",
                Type = "Selfdriving XL",
                Seats = 7,
                Kenteken = "WA-YM-02"
            }
        }.AsQueryable();

        public static IQueryable<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Jan van der Starre",
                Email = "jan@vanderstar.re",
                HasDriverLicense = true
            },
            new User
            {
                Id = 2,
                Name = "Kevin van Loon",
                Email = "kevin@vanlo.on",
                HasDriverLicense = true
            },
            new User
            {
                Id = 3,
                Name = "Admin",
                Email = "a@dm.in",
                HasDriverLicense = true
            }
        }.AsQueryable();

        public static IQueryable<Reservation> Reservations = new List<Reservation>
        {
            new Reservation
            {
                Id = 1,
                carId = 3,
                Car = Cars.FirstOrDefault(c => c.Id == 3),
                From = new DateTime(2020, 08, 04, 08, 00, 00),
                To = new DateTime(2020, 08, 04, 11, 58, 33),
                kmsDriven = 36,
                User = Users.FirstOrDefault(u => u.Id == 1),
                UserId = 1
            },
            new Reservation
            {
                Id = 2,
                carId = 3,
                Car = Cars.FirstOrDefault(c => c.Id == 3),
                From = new DateTime(2022, 08, 04, 08, 00, 00),
                To = default(DateTime),
                kmsDriven = -1,
                User = Users.FirstOrDefault(u => u.Id == 2),
                UserId = 2
            }
        }.AsQueryable();
        
        public static IQueryable<Payment> Payments = new List<Payment>
        {
            new Payment
            {
                Id = 1,
                ReservationId = 1,
                Reservation = Reservations.FirstOrDefault(c => c.Id == 1),
                Date = DateTime.Today,
                externId = Guid.NewGuid().ToString(),
                
                User = Users.FirstOrDefault(u => u.Id == 1),
                UserId = 1,
                
                Amount = new decimal(50.33)
            }
        }.AsQueryable();
    }
}