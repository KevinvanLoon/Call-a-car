import { Router } from '@angular/router';
import { Reservation } from 'src/app/models/reservation.model';
import { ReservationService } from './../../services/reservation.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.css']
})
export class InvoiceComponent implements OnInit {

  constructor(private reservationService : ReservationService,
    private router:Router) { }

  pricePerKm: number;
  kmDriven: number = 0;
  reservations: Reservation[]
  ngOnInit(): void {
    this.reservations = this.reservationService.get().filter(r => !r.paid);
    this.reservations.forEach((r => {
      this.kmDriven += r.kilometersDriven;
    }))
    this.pricePerKm = 1 - (this.reservations.length * 0.05);
  }

  pay() {
    this.reservationService.pay();
    this.router.navigate(['/home'])
  }

}
