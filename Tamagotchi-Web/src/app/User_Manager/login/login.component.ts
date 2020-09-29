import { Component, OnInit } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from '../../Entities/user/user.component';

const routes: Routes = [];

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  logger: LoginModel;

  constructor(private usercomponent: UserComponent) { }

  ngOnInit(): void {
  }

  Login(email, pword) {
    this.logger = new LoginModel(email, pword);

    this.usercomponent.LoginUser(this.logger);
  }
}

class LoginModel {
  email: string;
  password: string;

  constructor(em, pas) {
    this.email = em;
    this.password = pas;
  }
}
