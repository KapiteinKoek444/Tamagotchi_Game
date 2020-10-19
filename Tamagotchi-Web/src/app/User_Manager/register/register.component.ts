import { Component, OnInit } from '@angular/core';
import { user, UserComponent } from '../../Entities/user/user.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  _user: user;

  constructor(private usercomp: UserComponent, private router: Router) {
  }

  ngOnInit(): void {
  }

  public Register(email, password) {
    if (email == null || password == null) {
      console.log("all boxes must be filled in");
      return;
    }

    var usr = new user(email, password, this.newGuid())
    this.usercomp.RegisterUser(usr);

    localStorage.setItem("userId", usr.id);

    this.router.navigate(['shelter']);
  }

  private newGuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
      var r = Math.random() * 16 | 0,
        v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
  }
}
