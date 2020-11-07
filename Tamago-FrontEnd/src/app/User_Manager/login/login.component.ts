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

  public Login(email, password) {
    this.logger = new LoginModel(email, password);
    this.usercomponent.LoginUser(this.logger);
  }
}

export class LoginModel {
  email: string;
  password: string;

  constructor(email, pword) {
    this.email = email;
    this.password = pword;
  }
}
