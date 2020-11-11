import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GameUrls } from 'src/app/Services/constants';

@Component({
  selector: 'app-games-page',
  templateUrl: './games-page.component.html',
  styleUrls: ['../../../../assets/css/Account.css',
  'games-page.component.css']
})
export class GamesPageComponent implements OnInit {
  gameUrls: Object[];
  constructor(private router: Router) { }

  ngOnInit(): void {
    this.gameUrls = GameUrls;
  }

  onClick(url : string){
    console.log(url);

    if(url !== ""){
      window.location.href = url;
    } 
  }
  back(){
    this.router.navigate(['dashboard']);
  }

}
