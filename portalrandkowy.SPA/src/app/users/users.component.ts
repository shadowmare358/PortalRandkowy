import { Component, OnInit } from '@angular/core';
import {UsersinfoService} from '../_services/usersinfo.service';
import { User } from 'src/models/User';
import { AuthService } from '../_services/auth.service';
@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  users: User[] = [];
  constructor(private userService: UsersinfoService, private authService: AuthService) { }
  loggedIn() {
    return this.authService.loggedIn();
  }
  ngOnInit() {
    this.userService.getUsers().subscribe(users => { this.users = users; });
  }

}
