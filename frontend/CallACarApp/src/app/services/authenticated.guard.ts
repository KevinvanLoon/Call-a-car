import { AuthService } from './auth.service';

import { Injectable } from '@angular/core';
import { Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { of } from 'rxjs';

@Injectable({
    providedIn: 'root'
})


export class AuthenticatedGuard {

    constructor(private authService: AuthService, 
        private router:Router){}

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) : Promise<boolean> {


        if(this.authService.loggedIn.value === true) {
            return of(true).toPromise();
        }
        else {
            this.router.navigate[('/login')]
            return of(false).toPromise();
        }
    }
}
