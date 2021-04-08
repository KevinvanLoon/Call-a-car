import { Injectable } from '@angular/core';
import { Car } from '../models/car.model';
@Injectable({
    providedIn: 'root',
})

export class InventoryService {

    public carBrands = ['Tesla', 'Volkswagen', 'Nio', 'Polestar']
    public carTypes = ['Model X', 'Model Y', "Model 3"]

}