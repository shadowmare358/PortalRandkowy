import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/models/User';

@Injectable({
  providedIn: 'root'
})
export class UsersinfoService {
  baseUrl = 'https://localhost:5001/api/auth/';

constructor(private http: HttpClient) { }
getUsers() {
  return this.http.get<User[]>(this.baseUrl + "users");
}
}
