

import {Promise} from "bluebird";

export const START_COUNT = 2;

export enum COLORS{
    red,
    green,
    blue,
    yellow,
}

export const waitTime =async time =>{
  var timer = new Promise(resolve=> setTimeout(resolve,time));
  return timer;
};


