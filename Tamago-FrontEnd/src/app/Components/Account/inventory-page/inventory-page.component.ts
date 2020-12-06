import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FoodModel } from 'src/app/Models/FoodModel';
import { ApiServiceInventory } from 'src/app/Services/api_service/api-service.service';

@Component({
  selector: 'app-inventory-page',
  templateUrl: './inventory-page.component.html',
  styleUrls: ['./inventory-page.component.css', '../../../../assets/css/Account.css']
})
export class InventoryPageComponent implements OnInit {

  inventoryItems: InventoryItem[];

  constructor(private apiServiceInventory : ApiServiceInventory,private router: Router) { }

  ngOnInit(): void {

    this.inventoryItems = [];
    var user = localStorage.getItem("userid");
    this.apiServiceInventory.GetInventory(user).subscribe((data) => { 

      var inventoryData = data as any[];

      for (let index = 0; index < inventoryData.length; index++) {
        var element = inventoryData[index];
        var food = new FoodModel("0","0", 0, 0, "0", 0, 0, 0).fromJSON(element);
        var inventoryItem = new InventoryItem(food,1);
        this.inventoryItems.push(inventoryItem);
      }
    });

  }
  back() {
    this.router.navigate(['dashboard']);
  }
  public Shop(){
    this.router.navigate(['ShopPage']);
  }
}

export class InventoryItem {

  constructor(item  : FoodModel,amount: number){
   this.item = item;
   this.amount = amount;
  }
  item : FoodModel;
  amount : number;
}
