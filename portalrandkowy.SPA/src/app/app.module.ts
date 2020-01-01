import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {RouterModule, Routes} from '@angular/router';

import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AlertifyService } from './_services/alertify.service';
import { UsersComponent } from './users/users.component';
import { NotfoundComponent } from './notfound/notfound.component';
import { MessagesComponent } from './messages/messages.component';

const appRoutes: Routes = [
  {
    path: 'users',
    component: UsersComponent,
  },
  {
   path: 'home',
   component: HomeComponent
 },
 {
   path: 'messages',
   component: MessagesComponent
 },
 {
   path: '',
   redirectTo: '/home',
   pathMatch: 'full'
 },
 { path: '*',
 component: NotfoundComponent }
];
@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      UsersComponent,
      NotfoundComponent,
      MessagesComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      RouterModule.forRoot(
         appRoutes,
         { enableTracing: true } // <-- debugging purposes only
      )],
   providers: [
      AuthService,
      AlertifyService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
