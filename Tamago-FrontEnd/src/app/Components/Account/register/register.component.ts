import { Component, OnInit } from '@angular/core';

//models
import { UserModel } from '../../../Models/UserModel';

//services
import { GuidFactory } from '../../../Services/GuidFactory';
import { Hasher } from 'src/app/Services/Hasher';
import { Router } from '@angular/router';
import { ApiServiceUser, ApiServiceBank, ApiServiceInventory } from '../../../Services/api_service/api-service.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['../../../../assets/css/Account.css']
})
export class RegisterComponent implements OnInit {

  constructor(
    private apiserviceUser: ApiServiceUser,
    private apiserviceBank: ApiServiceBank,
    private apiserviceInventory: ApiServiceInventory,
    private guidFactory: GuidFactory,
    private hasher: Hasher,
    private router: Router) { }

  ngOnInit(): void {
  }

  public Register(email: String, password: String) {
    var id = this.guidFactory.GenerateGuid();
    var securePassword = this.hasher.MD5(password);
    var user = new UserModel(email, securePassword, id);


    this.apiserviceUser.SendUser(user).subscribe(
      data => {
      this.apiserviceBank.SendWallet(id);
      this.apiserviceInventory.SendInventory(id);
  
      localStorage.setItem("userid", id);
      this.router.navigate(['animalpicker']);
    },
    error => {
      console.error(error);
    }
    );
      

  }
}
