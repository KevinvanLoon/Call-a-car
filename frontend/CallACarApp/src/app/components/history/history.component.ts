import { ReservationService } from './../../services/reservation.service';
import { Reservation } from './../../models/reservation.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent implements OnInit {

  accepted:boolean;
  request:boolean = true;
  history: Reservation[];
  constructor(private historyService: ReservationService) { }

  ngOnInit(): void {
    this.history = this.historyService.getByUserId(1);
  }

}
