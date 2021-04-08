import { AuthService } from './auth.service';

import { Injectable } from '@angular/core';
import { Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { of } from 'rxjs';

@Injectable({
    providedIn: 'root'
})


export class AdminGuard {

    constructor(private authService: AuthService, 
        private router:Router){}

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) : Promise<boolean> {


        if(this.authService.userRole.value === "admin") {
            return of(true).toPromise();
        }
        else {
            this.router.navigate[('/login')]
            return of(false).toPromise();
        }
    }
}
