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

  inventoryItems: FoodModel[];

  constructor(private apiServiceInventory : ApiServiceInventory,private router: Router) { }

  ngOnInit(): void {
  }
  back() {
    this.router.navigate(['dashboard']);
  }
  public Shop(){
    this.router.navigate(['ShopPage']);
  }
}
