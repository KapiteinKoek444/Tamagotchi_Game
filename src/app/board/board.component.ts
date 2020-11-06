import { Component, ViewChild, ElementRef, OnInit, HostListener } from '@angular/core';
import { COLS, BLOCK_SIZE, ROWS, KEY, COLORS, Points, LINES_PER_LEVEL, Level } from '../models/constants';
import { IPiece } from '../models/Pieces/IPiece';
import { Piece } from '../models/Pieces/Piece';
import { BoardService } from '../Services/boardService';

@Component({
  selector: 'game-board',
  templateUrl: './board.component.html',
  styleUrls: ["./board.component.css",]
})
export class BoardComponent implements OnInit {
  // Get reference to the canvas.
  @ViewChild('board', { static: true })


  canvas: ElementRef<HTMLCanvasElement>;

  ctx: CanvasRenderingContext2D;
  gameRunning: boolean;

  points: number;
  lines: number;
  level: number;
  board = [,];

  piece: Piece;

  time = { start: 0, elapsed: 0, level: 1000 };

  moves = {
    [KEY.LEFT]: (p: IPiece): IPiece => ({ ...p, x: p.x - 1, y: p.y }),
    [KEY.RIGHT]: (p: IPiece): IPiece => ({ ...p, x: p.x + 1, y: p.y }),
    [KEY.DOWN]: (p: IPiece): IPiece => ({ ...p, x: p.x, y: p.y + 1 }),
    [KEY.SPACE]: (p: IPiece): IPiece => ({ ...p, y: p.y + 1 }),
    [KEY.R]: (p: IPiece): IPiece => this.boardService.rotate(p)
  };


  constructor(private boardService: BoardService) { }

  ngOnInit() {
    this.initBoard();
    this.points = 0;
    this.lines = 0;
    this.level = 1;

    this.ctx.scale(BLOCK_SIZE, BLOCK_SIZE);

    this.piece = new Piece(this.ctx);
  }


  initBoard() {
    // Get the 2D context that we draw on.
    this.ctx = this.canvas.nativeElement.getContext('2d');

    // Calculate size of canvas from constants.
    this.ctx.canvas.width = COLS * BLOCK_SIZE;
    this.ctx.canvas.height = ROWS * BLOCK_SIZE;
    this.board = this.boardService.getEmptyBoard();
  }

  play() {
    this.resetGame();
  }
  gameOver() {
    this.cancelAllAnimationFrames();
    this.gameRunning = false;
    this.ctx.fillStyle = 'black';
    this.ctx.fillRect(3.5, 3, 8, 1.2);
    this.ctx.font = '1px Arial';
    this.ctx.fillStyle = 'red';
    this.ctx.fillText('GAME OVER', 4.3, 4);
  }

  resetGame() {
    this.points = 0;
    this.lines = 0;
    this.level = 0;
    this.board = this.boardService.getEmptyBoard();
    this.gameRunning = true;
    this.spawnPiece();
  }

  spawnPiece() {
    this.piece = new Piece(this.ctx);
    this.animate();
  }


  freeze() {
    this.piece.shape.forEach((row, y) => {
      row.forEach((value, x) => {
        if (value > 0) {
          //console.log(" x: " + y + "| p:x" + this.piece.x + " - "+  " y: " + y + "| p:y" + this.piece.y);
          this.board[y + this.piece.y][x + this.piece.x] = value;
        }
      });
    });
  }

  draw() {
    this.ctx.clearRect(0, 0, this.ctx.canvas.width, this.ctx.canvas.height);
    this.piece.draw();
    this.drawBoard();
  }

  drawBoard() {

    this.board.forEach((row, y) => {
      row.forEach((value, x) => {
        if (value > 0) {
          this.ctx.fillStyle = COLORS[value];
          this.ctx.fillRect(x, y, 1, 1);
        }
      });
    });
  }

  animate(now = 0) {


    this.time.elapsed = now - this.time.start;

    if (this.time.elapsed > this.time.level) {
      this.time.start = now;
      this.drop();

      console.log(this.piece.y);
      console.log(this.board);
      if (this.piece.y === 0 && !this.boardService.isNotOccupied(this.board, this.piece.x, this.piece.y + 1)) {
        this.gameOver();
        return;
      }
    }
    this.draw();

    requestAnimationFrame(this.animate.bind(this));

  }
  cancelAllAnimationFrames() {
    var id = window.requestAnimationFrame(function () { });
    while (id--) {
      window.cancelAnimationFrame(id);
    }
  }

  clearLines() {
    let lines = 0; // Set variable
    this.board.forEach((row, y) => {
      if (row.every(value => value !== 0)) {
        lines++; // Increase for cleared line
        this.board.splice(y, 1);
        this.board.unshift(Array(COLS).fill(0));
      }
    });

    if (lines > 0) {
      // Calculate points from cleared lines and level.
      this.points += this.getLineClearPoints(lines);
      this.lines += lines;
      // If we have reached the lines per level
      if (this.lines >= LINES_PER_LEVEL) {
        // Goto next level
        this.level++;
        // Remove lines so we start working for the next level
        this.lines -= LINES_PER_LEVEL;
        // Increase speed of game.
        this.time.level = Level[this.level];
      }
    }
  }

  getLineClearPoints(lines: number): number {
    return (this.level + 1) *
      (lines === 1 ? Points.SINGLE :
        lines === 2 ? Points.DOUBLE :
          lines === 3 ? Points.TRIPLE :
            lines === 4 ? Points.TETRIS : 0
      );
  }

  private onCollision() {
    if (!this.boardService.valid(this.moves[KEY.DOWN](this.piece), this.board)) {
      this.freeze();
      this.clearLines();
      this.spawnPiece();
    }
  }

  private drop() {
    var p = this.moves[KEY.DOWN](this.piece);

    this.points += Points.SOFT_DROP;
    this.piece.move(p);

    this.onCollision();
  }

  private softDrop(p: any) {
    if (this.boardService.valid(p, this.board)) {
      this.piece.move(p);
      // Clear the old position before drawing
      this.ctx.clearRect(0, 0, this.ctx.canvas.width, this.ctx.canvas.height);
      // Draw the new position.
      this.animate();
    }
  }

  private hardDrop(event: KeyboardEvent, p: any) {
    if (event.keyCode === KEY.SPACE) {
      while (this.boardService.valid(p, this.board)) {
        this.points += Points.HARD_DROP;
        this.piece.move(p);
        p = this.moves[KEY.DOWN](this.piece);
      }
      this.ctx.clearRect(0, 0, this.ctx.canvas.width, this.ctx.canvas.height);
      // Draw the new position.
      this.animate();
    }
    return p;
  }



  @HostListener('window:keydown', ['$event'])
  keyEvent(event: KeyboardEvent) {
    if (!this.gameRunning) {
      return;
    }

    var keyCode = event.keyCode;
    if (this.moves[keyCode] != null) {

      event.preventDefault();
      var p = this.moves[keyCode](this.piece);
      p = this.hardDrop(event, p);
      this.softDrop(p);
      this.onCollision();
    }
  }
}
