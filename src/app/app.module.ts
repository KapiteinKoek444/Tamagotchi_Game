import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { GameComponent } from './components/game/game.component';
import { GameButtonComponent } from './components/game/game-button/game-button.component';
import { GameStateService } from './services/game-state.service';

@NgModule({
  declarations: [
    AppComponent,
    GameComponent,
    GameButtonComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [GameStateService],
  bootstrap: [AppComponent]
})
export class AppModule { 
coints: number = 10;

constructor(){
  this.coints = 10;
}



}
