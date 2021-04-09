import { User } from './../models/user.model';
import { Injectable } from '@angular/core';
import { Observable, Subject, BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})

export class AuthService {

    public loggedIn = new BehaviorSubject<boolean>(false);
    public userRole = new BehaviorSubject<string>(null);
    public user = new BehaviorSubject<User>(null);


    normalUser: User = {
        id:1,
        username: "",
        email: "user@user.nl",
        hasDriversLicense: true
    }

    admin: User = {
        id: 5, 
        username: "admin",
        email: "admin@admin.nl",
        hasDriversLicense: true
    }
    
    constructor() {}

    public login(username, password) {
        if(password === 'admin') {
            this.userRole.next("admin");
            this.loggedIn.next(true);
            this.user.next(this.admin)
        }
        else {
            this.userRole.next("user");
            this.loggedIn.next(true);
            this.normalUser.username = username;
            this.user.next(this.normalUser)
        }
    }

    public register(username, password) {
        if(password === 'admin') {
            this.userRole.next("admin");
            this.loggedIn.next(true);
            this.user.next(this.admin)
        } 
        else {
            this.userRole.next("user");
            this.loggedIn.next(true);
            this.normalUser.username = username;
            this.user.next(this.normalUser)
        }
    }

    public logout() {
        this.loggedIn.next(false);
        this.userRole.next(null);
        this.user.next(null);

    }
}