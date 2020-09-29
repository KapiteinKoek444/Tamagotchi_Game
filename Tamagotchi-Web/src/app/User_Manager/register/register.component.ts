import { Component, OnInit } from '@angular/core';
import { user, UserComponent } from '../../Entities/user/user.component';
import { Animal, AnimalComponent } from '../../Entities/Animal/animal.component';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  _user: user;

  constructor(private usercomp: UserComponent, private animalcomp: AnimalComponent) {
  }

  ngOnInit(): void {
  }

  Register(email, pword) {
    if (email == null || pword == null) {
      console.log("all boxes must be filled in");
      return;
    }

    var usr = new user(email, pword, this.newGuid())
    this.usercomp.RegisterUser(usr);
    this.animalcomp.generateAnimal(this.newGuid(), usr.id);

    localStorage.setItem("userId", usr.id);


  }

  newGuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
      var r = Math.random() * 16 | 0,
        v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
  }
}
