import { Injectable } from '@angular/core';
import { Car } from '../models/car.model';
@Injectable({
    providedIn: 'root',
})

export class CarService {
    cars : Car[] = [
        {
            id: 1,
            brand: "Tesla",
            type: "Model S",
            seats: 4,
            numberPlate: "XYZ-XYZ"
        },
        {
            id: 2,
            brand: "Tesla",
            type: "Model X",
            seats: 4,
            numberPlate: "XYZ-XYZ"
        },
        {
            id: 3,
            brand: "Tesla",
            type: "Model Y",
            seats: 4,
            numberPlate: "XYZ-XYZ"
        }
    ]

    get() {
        return this.cars;
    }

    getById(id) {
        return this.cars.find(r => r.id === id);
    }


}