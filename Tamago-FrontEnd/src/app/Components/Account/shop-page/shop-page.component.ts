import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FoodModel } from 'src/app/Models/FoodModel';

@Component({
  selector: 'app-shop-page',
  templateUrl: './shop-page.component.html',
  styleUrls: ['./shop-page.component.css', '../../../../assets/css/Account.css']
})
export class ShopPageComponent implements OnInit {

  featuredItems: FoodModel[] = [
    new FoodModel("9", "Red Robe", 30000, 0, "Clothing", 0, 0, 0),
    new FoodModel("10", "Bear Pajamas", 20000, 0, "Clothing", 0, 0, 0),
    new FoodModel("11", "Gold Sunglasses", 80000, 0, "Clothing", 0, 0, 0),
  ];
  dailyItems: FoodModel[] = [
    new FoodModel("1", "Dogfood", 400, 0, "Food", 0, 0, 0),
    new FoodModel("2", "Bief", 1000, 0, "Food", 0, 0, 0),
    new FoodModel("3", "Chicken", 500, 0, "Food", 0, 0, 0),
    new FoodModel("4", "Tuna", 3000, 0, "Food", 0, 0, 0),
    new FoodModel("5", "Bagel", 1600, 0, "Food", 0, 0, 0),
    new FoodModel("6", "Pumpkin", 300, 0, "Food", 0, 0, 0),
    new FoodModel("7", "Goat Cheese", 20, 0, "Food", 0, 0, 0),
    new FoodModel("8", "Grapefruit", 600, 0, "Food", 0, 0, 0),
  ];
  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  back() {
    this.router.navigate(['dashboard']);
  }
  inventory() {
    console.error("Not implemented yet...");
  }

}
