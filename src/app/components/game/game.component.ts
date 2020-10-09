import { Component, OnInit } from '@angular/core';
import { waitTime } from 'src/app/models/constants';
import { GameStateService } from 'src/app/services/game-state.service';


@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {
  count: number;
  colors: any = {
   red: false,
   blue: false,
   green : false,
   yellow: false,
  };



  constructor(private game: GameStateService) { }

  ngOnInit(): void {
   this.game.state.subscribe(state =>{
     console.log(state);
     if(this.count !== state.count){
       this.count = state.count;
       this.showPlayer(state.simon);
     }
   });

   this.game.GenerateSimon();
  }

  playerGuess(e: string) {
    this.game.playerInput(e);
    
  }

  async showPlayer(simon: string[]){
    for (let i = 0; i < simon.length; i++) {
      await waitTime(100);
      this.colors[simon[i]] = true; 
      await waitTime(500);    // this shows the player the order of the colors
      this.colors[simon[i]] = false; 
      await waitTime(200);
    }
  }

  restartGame(){
    window.location.reload();
  }

}
