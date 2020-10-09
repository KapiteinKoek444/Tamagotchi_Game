import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TAMAGOTCHI MEMORY';
  coints: number;

  constructor(){
    this.coints = 10;
  }
  
}
