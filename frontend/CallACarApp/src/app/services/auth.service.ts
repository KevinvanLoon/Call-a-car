import { Injectable } from '@angular/core';
import { Observable, Subject, BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})

export class AuthService {

    public loggedIn = new BehaviorSubject<boolean>(false);
    public userRole = new BehaviorSubject<string>(null);
    public userName = new BehaviorSubject<string>("");

    constructor() {}

    public login(username, password) {
        if(password === 'admin') {
            this.userRole.next("admin");
            this.loggedIn.next(true);
        }
        else {
            this.userRole.next("user");
            this.loggedIn.next(true);
        }
        this.userName.next(username);

    }

    public register(username, password) {
        if(password === 'admin') {
            this.userRole.next("admin");
            this.loggedIn.next(true);
        } 
        else {
            this.userRole.next("user");
            this.loggedIn.next(true);
        }
        this.userName.next(username);

    }

    public logout() {
        this.loggedIn.next(false);
        this.userRole.next(null);
        this.userName.next(null);

    }
}