import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';
// import { alertify } from '../../../node_modules/alertifyjs/build/alertify.min.js';
declare let alertify: any;
@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(public authService: AuthService, private alertify: AlertifyService, private router: Router) { }

  ngOnInit() {
  }

  logIn(){
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success("Login successful!")
    }, error => {
      this.alertify.error(error.message + 'error!');
    });
  }
  loggedIn() {
    return this.authService.loggedIn();
  }
  logOut() {
    localStorage.removeItem('token');
    this.alertify.message("Logged out successfully!");
    this.router.navigate(['/home']);
  }
}

