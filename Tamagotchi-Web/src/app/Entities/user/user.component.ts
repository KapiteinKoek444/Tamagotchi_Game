import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../../Data_Manager/api.service';
import { HasherComponent } from '../../User_Manager/hasher/hasher.component';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent {

  constructor(private apiservice: ApiService, private hasher: HasherComponent, private router: Router) { }

  RegisterUser(user) {
    user.password = this.hasher.MD5(user.password);
    JSON.stringify(user);
    this.apiservice.sendUsers(user);
  }

  LoginUser(model) {
    model.password = this.hasher.MD5(model.password);
    this.apiservice.getUserPassword(model);

    var id = localStorage.getItem("userId");

    if (id == "00000000-0000-0000-0000-000000000000" || id == null) {
      console.log("Failed to log in, try a different username or password..");
      return;
    }
    else {
      this.router.navigate(['animal'])
    }
  }

  GetAllUser() {
    this.apiservice.getUsers().subscribe((data) => {
      console.log(data);
    })
  }
}

export class user {
  email;
  password;
  id;

  constructor(_email, _password, _id) {
    this.email = _email;
    this.password = _password;
    this.id = _id;
  }
}

export class LoginModel {
  email;
  password;

  constructor(email, password) {
    this.email = email;
    this.password = password;
  }
}

