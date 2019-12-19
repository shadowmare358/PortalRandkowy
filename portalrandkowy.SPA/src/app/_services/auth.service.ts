import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

baseUrl = 'https://localhost:5001/api/auth/';

constructor(private http: HttpClient) { }
login(model: any){
  // const headers = new HttpHeaders()
  //     .append('Content-Type', 'application/json')
  //      .append('Access-Control-Allow-Methods', 'POST')
  //      .append('Access-Control-Allow-Methods', 'GET')
  //     .append('Access-Control-Allow-Origin', 'https://localhost:5001/api/auth/');
  return this.http.post(this.baseUrl + 'login', model)
  .pipe(map((response: any) => {
    const user = response;
    if (user) {
      localStorage.setItem('token', user.token);
    }
  }));
}
}
