import { AuthService } from './auth.service';
import { User } from './../models/user.model';
import { Reservation } from './../models/reservation.model';
import { Injectable } from '@angular/core';
import { Car } from '../models/car.model';
@Injectable({
    providedIn: 'root',
})

export class ReservationService {

    constructor(private authService : AuthService) {}

    car : Car =   {
        id: 1,
        brand: "Tesla",
        type: "Model S",
        seats: 4,
        numberPlate: "XYZ-XYZ"
    }

    user : User = this.authService.normalUser;

    reservations: Reservation[] = [
        {
            id:1,
            car: this.car,
            user: this.user,
            destination : "Avans hogeschool lovendijkstraat",
            pickupPoint: "Station Breda",
            from: new Date(),
            to: new Date(),
            kilometersDriven: 10,
            paid: false
        },
        {
            id:2,
            car: this.car,
            user: this.user,
            destination : "Avans hogeschool lovendijkstraat",
            pickupPoint: "Station Breda",
            from: new Date(),
            to: new Date(),
            kilometersDriven: 10,
            paid: false
        },
        {
            id:1,
            car: this.car,
            user: this.user,
            destination : "Avans hogeschool lovendijkstraat",
            pickupPoint: "Station Breda",
            from: new Date(),
            to: new Date(),
            kilometersDriven: 10,
            paid: false
        },
        {
            id:2,
            car: this.car,
            user: this.user,
            destination : "Avans hogeschool lovendijkstraat",
            pickupPoint: "Station Breda",
            from: new Date(),
            to: new Date(),
            kilometersDriven: 10,
            paid: false
        },    {
            id:1,
            car: this.car,
            user: this.user,
            destination : "Avans hogeschool lovendijkstraat",
            pickupPoint: "Station Breda",
            from: new Date(),
            to: new Date(),
            kilometersDriven: 10,
            paid: false
        },
        {
            id:2,
            car: this.car,
            user: this.user,
            destination : "Avans hogeschool lovendijkstraat",
            pickupPoint: "Station Breda",
            from: new Date(),
            to: new Date(),
            kilometersDriven: 10,
            paid: false
        }
    ]

    get() {
        return this.reservations;
    }

    getById(id) {
        return this.reservations.find(r => r.id === id);
    }

    getByUserId(id) {
        return this.reservations.filter(r => r.user.id === id);
    }

    add(reservation: Reservation) {
        this.reservations.push(reservation);
    }

    pay() {
        this.reservations.forEach((r => {
            r.paid = true;
        }))
    }
}