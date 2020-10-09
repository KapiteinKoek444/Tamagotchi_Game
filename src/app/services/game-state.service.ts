import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { COLORS, START_COUNT } from '../models/constants';

@Injectable({
  providedIn: 'root'
})
export class GameStateService {
  simon: string[] = [];
  player: string[] = [];
  count: number;

  state = new Subject<any>();

  constructor() {
    this.count = START_COUNT;
  }

  private get randomColor(): string {
    var rand = Math.floor(Math.random() * (Object.keys(COLORS).length / 2));
    return COLORS[rand];
  }

  appendSimon(increment: boolean = false): void {
    if (increment) {
      this.count++;
    }
    this.simon.push(this.randomColor);

  }

  GenerateSimon(): string[] {
    this.simon = [];
    for (let i = 0; i < this.count; i++) {
      this.appendSimon();
    }

    this.setState();
    return this.simon;
  }

  restartSimon(): string[] {
    this.count = START_COUNT;
    return this.GenerateSimon();
  }

  playerInput(val: string) {
    this.player.push(val);

    if (!this.compareSimon()) {
      this.player = [];
    }

    this.setState();

  }

  compareSimon(): boolean {
    for (let i = 0; i < this.player.length; i++) {
      if (this.player[i] !== this.simon[i]) {
        return false;
      }
    }

    if (this.player.length === this.simon.length) {
      this.updateGame();
    }
    return true;
  }

  updateGame() {
    this.appendSimon(true);
    this.player = [];
  }

  setState() {
    this.state.next({
      Player: this.player,
      simon: this.simon,
      count: this.count,
    });
  }
}
