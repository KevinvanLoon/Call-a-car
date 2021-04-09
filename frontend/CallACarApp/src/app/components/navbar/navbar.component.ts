import { AuthService } from './../../services/auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {


  isLoggedIn: boolean;
  userRole: string;
  constructor(public authService:AuthService) { }

  ngOnInit(): void {

  }

}
