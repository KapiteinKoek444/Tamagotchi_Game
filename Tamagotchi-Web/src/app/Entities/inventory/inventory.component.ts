import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.css']
})
export class InventoryComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    console.log(localStorage.getItem("userId"))
  }

}

export class Inventory {

}

export class Food {
  calories;
  cafeine
  price;

  constructor(cal, caf, pri) {
    this.calories = cal;
    this.cafeine = caf;
    this.price = pri;
  }

  GiveFood() {

  }

  SellFood() {

  }
}
