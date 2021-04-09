import { Reservation } from './../../../models/reservation.model';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-confirmation',
  templateUrl: './confirmation.component.html',
  styleUrls: ['./confirmation.component.css']
})
export class ConfirmationComponent implements OnInit {

  reservation: Reservation;
  constructor(private router:Router) {
    this.reservation = this.router.getCurrentNavigation().extras.state.reservation;
   }

  ngOnInit(): void {

  }

}
