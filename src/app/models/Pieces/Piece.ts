import { BLOCK_SIZE, COLORS, COLS, SHAPES } from '../constants';
import { IPiece } from './IPiece';

export class Piece implements IPiece {
  x: number;
  y: number;
  color: string;
  shape: number[][];


  constructor(private ctx: CanvasRenderingContext2D) {
    this.spawn();
  }

  spawn() {

    this.shape = SHAPES[this.GetRandomIndex(SHAPES.length)];
    this.color = COLORS[this.GetRandomIndex(COLORS.length)];
    // Position where the shape spawns.
    this.x = Math.round(COLS/3);
    this.y = 0;
  }

  draw() {
    this.ctx.fillStyle = this.color;
    this.shape.forEach((row, y) => {
      row.forEach((value, x) => {
        if (value > 0) {
          this.ctx.fillRect(this.x + x, this.y + y, 1, 1);
        }
      });
    });
  }




  move(p: IPiece) {
    this.x = p.x;
    this.y = p.y;

    this.shape = p.shape;
  }
   GetRandomIndex(length: number): number {
    return Math.floor(Math.random() * length);
  }

}