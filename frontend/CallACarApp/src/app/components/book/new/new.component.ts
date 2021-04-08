import { CarService } from './../../../services/car.service';
import { InventoryService } from './../../../services/inventory.service';
import { ReservationService } from './../../../services/reservation.service';
import { AuthService } from './../../../services/auth.service';

import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Reservation } from 'src/app/models/reservation.model';
@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.scss']
})
export class NewComponent implements OnInit {


  addForm = this.formBuilder.group({
    destination: [null, Validators.required],
    carBrand: [null,Validators.required],
    carType: [null,Validators.required],
    driversLicense: [null, Validators.required],
    wheelchair: [null, Validators.required]
  });

  constructor(private authService: AuthService,
    private carService: CarService,
    private reservationService: ReservationService,
    private formBuilder: FormBuilder,
    public inventoryService:InventoryService,
    private router:Router
    ) { }

  ngOnInit(): void {
  }

  submit() {
    var reservation = this.reservationService.get()[0]
    reservation.destination = this.addForm.value.destination;
    reservation.car.brand = this.addForm.value.carBrand,
    reservation.car.type = this.addForm.value.carType
    this.reservationService.add(reservation);
    this.router.navigate(['/book/confirmation'], {state : { reservation: reservation}});
  }

}
