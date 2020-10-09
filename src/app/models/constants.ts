

import {Promise} from "bluebird";

export const START_COUNT = 2;

export const START_COINTS_MULTIPLIER = 20;

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


