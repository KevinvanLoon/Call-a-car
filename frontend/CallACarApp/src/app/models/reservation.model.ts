import { User } from './user.model';
import { Car } from "./car.model";

export class Reservation {
    public id: number;
    public car: Car;
    public user: User;
    public pickupPoint: string;
    public destination: string;
    public from: Date;
    public to: Date;
    public kilometersDriven: number;
}