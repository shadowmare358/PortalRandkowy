import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UsersinfoService } from '../_services/usersinfo.service';
import { User } from 'src/models/User';
import { AuthService } from '../_services/auth.service';
import { Message } from 'src/models/Message';
import { AlertifyService } from '../_services/alertify.service';
@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {
  users: User[] = [];
  message: Message = new Message();
  constructor(private http: HttpClient, private userService: UsersinfoService, private authService: AuthService, private alertify: AlertifyService) {
  }
  loggedIn() {
    return this.authService.loggedIn();
  }
  send() {
   this.message.authorusername = this.authService.decodedToken.unique_name;
   console.log("Author username: " + this.message.authorusername);
   console.log("Receiever useranem: " + this.message.receieverusername);
   console.log("Message content: " + this.message.content);
    this.authService.send(this.message).subscribe(() => {
     this.alertify.success('Message send!');
    }, error => {
      this.alertify.error(error + " Error!");
    });
  }
  ngOnInit() {
    this.userService.getUsers().subscribe(users => { this.users = users; });
  }

}
