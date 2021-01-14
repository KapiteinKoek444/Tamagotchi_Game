import { Component, OnInit } from '@angular/core';

//models
import { LoginModel } from 'src/app/Models/LoginModel';
import { AnimalModel } from 'src/app/Models/AnimalModel';

//Services
import { Router } from '@angular/router';
import { Hasher } from '../../../Services/Hasher';
import { ApiServiceUser, ApiServiceAnimal } from 'src/app/Services/api_service/api-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['../../../../assets/css/Account.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private apiserviceUser: ApiServiceUser,
    private apiserviceAnimal: ApiServiceAnimal,
    private router: Router,
    private hasher: Hasher) { }

  ngOnInit(): void {
  }

  public Login(email: String, password: String) {
    var securePassword = this.hasher.MD5(password);

    var loginModel = new LoginModel(email, securePassword);
    this.apiserviceUser.GetUserPassword(loginModel);

    if (localStorage.getItem("userid") != "00000000-0000-0000-0000-000000000000" && localStorage.getItem("userid") != null) {

      this.apiserviceAnimal.GetAnimal(localStorage.getItem("userid")).subscribe(data => {
        let animal = new AnimalModel(0, 0, "0", 0, 0, 0, 0, 0).fromJSON(data);

        if (animal.id == "00000000-0000-0000-0000-000000000000" || animal.id == null) {
          this.router.navigate(['animalpicker']);
        } else {
          this.router.navigate(['dashboard']);
        }
      });

      return;
    }
  }
}
