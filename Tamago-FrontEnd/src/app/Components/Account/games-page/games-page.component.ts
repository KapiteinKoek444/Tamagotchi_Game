import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
    var result = this.apiServiceBank.AddMoney(localStorage.getItem("userid"),addedmoney);
    console.log(result);

  }
  back(){
    this.router.navigate(['dashboard']);
  }

}
