import { Component, OnInit } from '@angular/core';
import { START_COINTS_MULTIPLIER, START_COUNT } from './models/constants';
import { GameStateService } from './services/game-state.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'TAMAGOTCHI MEMORY';

  coints: number;
  count: number;

  constructor(private game: GameStateService){
    this.coints = 0;
  }
  ngOnInit(): void {
    this.game.state.subscribe(state =>{
      if(this.count !== state.count){
        this.count = state.count;
        this.addCoints(this.count);
      }
    });
  }
   addCoints(level: number){
    var amount = START_COINTS_MULTIPLIER * (level - START_COUNT);
    this.coints += amount;
   }


  

  
}
