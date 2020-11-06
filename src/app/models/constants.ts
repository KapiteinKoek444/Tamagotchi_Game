export const COLS = 15;
export const ROWS = 25;
export const BLOCK_SIZE = 30;
export const LINES_PER_LEVEL = 10;

export class KEY {
    static readonly LEFT = 37;
    static readonly RIGHT = 39;
    static readonly DOWN = 40;
    static readonly SPACE = 32;   
    static readonly R = 82;   
}

export class Level {
  static readonly 0 = 800;
  static readonly 1 = 720;
  static readonly 2 = 630;
  static readonly 3 = 550;
  // ...
}

export class Points {
  static readonly SINGLE = 100;
  static readonly DOUBLE = 300;
  static readonly TRIPLE = 500;
  static readonly TETRIS = 800;
  static readonly SOFT_DROP = 1;
  static readonly HARD_DROP = 2;
}

export const COLORS = [
    'cyan',
    'blue',
    'orange',
    'yellow',
    'green',
    'purple',
    'red'
  ];

  export const SHAPES = [
    [[0, 0, 0, 0], [1, 1, 1, 1], [0, 0, 0, 0], [0, 0, 0, 0]],
    [[2, 0, 0], [2, 2, 2], [0, 0, 0]],
    [[0, 3, 0], [3, 3, 3], [0, 0, 0]],
    [[4, 4, 0], [0, 4, 4], [0, 0, 0]],
    [[0, 5, 5, 0], [0, 5, 5, 0]],
    [[0, 6, 6], [6, 6, 0], [0, 0, 0]]
  ];