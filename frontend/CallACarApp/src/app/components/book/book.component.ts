import { Reservation } from './../../models/reservation.model';
import { Router } from '@angular/router';
import { ReservationService } from './../../services/reservation.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {


  reservations: Reservation[] = [];
  constructor(private reservationService: ReservationService,
    private router:Router) { }

  ngOnInit(): void {
    this.reservations = this.reservationService.getByUserId(1);
  }

  toConfirmation(reservation) {

    this.reservationService.add(reservation);
    this.router.navigate(['/book/confirmation'], {state : { reservation: reservation}});
  }

  toNewBooking() {
    this.router.navigate[('/new')]
  }



}
