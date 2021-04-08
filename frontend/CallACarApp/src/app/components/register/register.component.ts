import { Component, OnInit } from '@angular/core';
import { AuthService } from './../../services/auth.service';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  loginForm = this.formBuilder.group({
    email: [null, Validators.required],
    password: [null,Validators.required]
  });

  constructor(private authService : AuthService,
    private formBuilder: FormBuilder,
    private router: Router) { }

  ngOnInit(): void {
    this.authService.logout();
  }

  submit() {
    this.authService.login(this.loginForm.value.email, this.loginForm.value.password);
      if(this.loginForm.value.password === 'admin') {
        this.router.navigate(['/admin']);
      } else {
        this.router.navigate(['/home']);
      }
  }

  navigate(): void {
    this.authService.login("user", "user");
    this.router.navigate(['/home']);
  }
}
