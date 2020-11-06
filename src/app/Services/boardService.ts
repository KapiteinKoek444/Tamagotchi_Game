import { Injectable } from '@angular/core';
import { COLS, ROWS } from '../models/constants';
import { IPiece } from '../models/Pieces/IPiece';


@Injectable({
    providedIn: 'root'
})

export class BoardService {



    getEmptyBoard(): number[][] {
        return Array.from({ length: ROWS }, () => Array(COLS).fill(0));
    }

    valid(p: IPiece , board = [,]): boolean {
        return p.shape.every((row, dy) => {
            return row.every((value, dx) => {
                let x = p.x;
                let y = p.y;
                
                x += dx;
                y += dy;

                return (
                    this.isEmpty(value) || 
                    (this.insideWalls(x) &&
                        this.aboveFloor(y) &&
                        this.isNotOccupied(board,x,y)
                    ));
            });
        });
    }

    isEmpty(value): boolean {
        return value <= 0;
    }

    isNotOccupied(board,x,y): boolean {
         return board[y][x] === 0;
    }

    insideWalls(x: number): boolean {
        return x >= 0 && x < COLS;
    }   

    aboveFloor(y: number): boolean {
        return y < ROWS;
    }

    rotate(p: IPiece): IPiece {
        // Cloning with JSON
        let clone: IPiece = JSON.parse(JSON.stringify(p));

        // Do algorithm
        // Transpose matrix
        for (let y = 0; y < clone.shape.length; ++y) {
            for (let x = 0; x < y; ++x) {
                [clone.shape[x][y], clone.shape[y][x]] =
                    [clone.shape[y][x], clone.shape[x][y]];
            }
        }
        // Reverse the order of the columns.
        clone.shape.forEach(row => row.reverse());

        return clone;
    }

} 