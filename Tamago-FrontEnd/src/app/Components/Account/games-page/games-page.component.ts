import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { WalletModel } from 'src/app/Models/WalletModel';
import { ApiServiceBank } from 'src/app/Services/api_service/api-service.service';
import { GameUrls } from 'src/app/Services/constants';

@Component({
  selector: 'app-games-page',
  templateUrl: './games-page.component.html',
  styleUrls: ['../../../../assets/css/Account.css',
  'games-page.component.css']
})
export class GamesPageComponent implements OnInit {
  gameUrls: Object[];

  constructor(private router: Router,private apiServiceBank: ApiServiceBank) { }

  ngOnInit(): void {
    this.gameUrls = GameUrls;  
  }

  onClick(url : string){
    console.log(url);

    var addedmoney = Math.floor((Math.random() * 1000) + 1);
    this.apiServiceBank.GetWallet(localStorage.getItem("userid")).subscribe(data => {

      var model = data as WalletModel;
      model.balance += addedmoney;
      console.log(model);
      this.apiServiceBank.Update(model);
    });
 
    
    if(url !== ""){
      window.location.href = url;
    } 
  }
  back(){
    this.router.navigate(['dashboard']);
  }

}
