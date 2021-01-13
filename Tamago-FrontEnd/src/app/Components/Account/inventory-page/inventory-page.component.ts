import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FoodModel } from 'src/app/Models/FoodModel';
import { InventoryModel } from 'src/app/Models/InventoryModel';
import { WalletModel } from 'src/app/Models/WalletModel';
import { ApiServiceAnimal, ApiServiceBank, ApiServiceInventory, ApiServiceShop } from 'src/app/Services/api_service/api-service.service';
import { AnimalModel } from '../../../Models/AnimalModel';

@Component({
  selector: 'app-inventory-page',
  templateUrl: './inventory-page.component.html',
  styleUrls: ['./inventory-page.component.css', '../../../../assets/css/Account.css']
})
export class InventoryPageComponent implements OnInit {

  inventoryItems: InventoryItem[] = [];
  items: String[] = [];
  inventoryData;

  walletbalance: number;

  constructor(
    private apiServiceInventory: ApiServiceInventory,
    private apiServiceShop: ApiServiceShop,
    private apiServiceAnimal: ApiServiceAnimal,
    private apiServiceBank: ApiServiceBank,
    private router: Router) { }

  ngOnInit(): void {

    this.inventoryItems = [];
    var user = localStorage.getItem("userid");


    this.apiServiceInventory.GetInventory(user).subscribe((intventory) => {

      this.inventoryData = intventory as any;
      this.items = this.inventoryData.itemId as any[];

      for (let index = 0; index < this.items.length; index++) {
        var element = this.items[index];
        this.apiServiceShop.GetFood(element).subscribe((data) => {
          var food = new FoodModel("0", "0", 0, 0, "0", 0, 0, 0).fromJSON(data);
          var inventoryItem = new InventoryItem(food, 1);
          this.inventoryItems.push(inventoryItem);
        })
      }
    });

    this.apiServiceBank.GetWallet(user).subscribe((data) => {
      var wallet = data as WalletModel;
      this.walletbalance = wallet.balance;
    });

  }

  GiveFood(clickedFood: FoodModel) {
    var isRemoved = false;

    for (var i = 0; i < this.inventoryItems.length; i++) {
      if (!isRemoved) {
        if (this.inventoryItems.find(item => item.item.id == clickedFood.id) != null) {
          this.inventoryItems.splice(i, 1);
          isRemoved = true;
        }
      }
    }

    //removing from inventory
    this.apiServiceInventory.GetInventory(localStorage.getItem("userid")).subscribe((intventory) => {
      this.inventoryData = intventory as InventoryModel;
      var itemId: String[] = [];

      for (var i = 0; i < this.inventoryItems.length; i++) {
        var id = this.inventoryItems[i].item.id;
        itemId.push(id);
      }

      var newModel = new InventoryModel(this.inventoryData.id, localStorage.getItem("userid"), itemId);
      console.log(newModel);
      this.apiServiceInventory.UpdateInventory(newModel);
    });

    //giving food to animal
    this.apiServiceAnimal.GetAnimal().subscribe((data) => {
      var animal = new AnimalModel(0, 0, "0", 0, 0, 0, 0).fromJSON(data)

      animal.food += clickedFood.foodVal;
      animal.energy += clickedFood.energyVal;
      animal.happiness += clickedFood.happyVal;

      this.apiServiceAnimal.UpdateAnimal(animal);
    });
  }

  back() {
    this.router.navigate(['dashboard']);
  }
  public Shop() {
    this.router.navigate(['ShopPage']);
  }
}

export class InventoryItem {

  constructor(item: FoodModel, amount: number) {
    this.item = item;
    this.amount = amount;
  }
  item: FoodModel;
  amount: number;
}
