import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FoodModel } from 'src/app/Models/FoodModel';
import { ApiServiceShop } from 'src/app/Services/api_service/api-service.service';

@Component({
  selector: 'app-shop-page',
  templateUrl: './shop-page.component.html',
  styleUrls: ['./shop-page.component.css', '../../../../assets/css/Account.css']
})
export class ShopPageComponent implements OnInit {

  featuredItems: FoodModel[];
  dailyItems: FoodModel[];
  constructor(private apiServiceShop: ApiServiceShop ,private router: Router) {

   }

  ngOnInit(): void {
    this.dailyItems = [];
    this.featuredItems =[];
    this.apiServiceShop.GetAllFood().subscribe((data) => { 

      var foodData = data as any[];

      for (let index = 0; index < foodData.length; index++) {
        var element = foodData[index];
        var food = new FoodModel("0","0", 0, 0, "0", 0, 0, 0).fromJSON(element);
        if(food.discount <= 0){
          this.dailyItems.push(food);
        }else{
          this.featuredItems.push(food);
        }
        
      }
    });
  }

  BuyItem(data){
   console.log(data.name + " clicked");
  }

  back() {
    this.router.navigate(['dashboard']);
  }
  inventory() {
    this.router.navigate(['InventoryPage']);
  }

}
