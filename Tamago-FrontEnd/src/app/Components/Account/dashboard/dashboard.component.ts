import { Component, OnInit } from '@angular/core';
import { ApiServiceAnimal } from '../../../Services/api_service/api-service.service';
import { AnimalModel } from '../../../Models/AnimalModel';
import { Router } from '@angular/router';
import { AnimalImages } from 'src/app/Services/constants';
import { SignalRService } from 'src/app/Services/api_service/signal-r.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['../../../../assets/css/Account.css']
})

export class DashboardComponent implements OnInit {
  images: String[];
  animal: AnimalModel;


  constructor(
    private apiserviceAnimal: ApiServiceAnimal,
    public signalRService: SignalRService,
    private router: Router
  ) {
    this.images = AnimalImages;
  }

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.GetAnimalDataListener();
    this.startHttpRequest();



    this.animal = new AnimalModel(0, 0, "null", 0, 0, 0, 1, 0);

    this.apiserviceAnimal.GetAnimal(localStorage.getItem("userid")).subscribe((data) => {
      this.animal = new AnimalModel(0, 0, "0", 0, 0, 0, 0, 0).fromJSON(data)
      var image = document.getElementById('tamagotchi') as HTMLImageElement;

      if (this.animal.energy > 0 && this.animal.food > 0 && this.animal.happiness > 0) {
        image.src = '../../../../assets/animalTypes/' + this.images[this.animal.animalType] + ".png";
      } else {
        image.src = '../../../../assets/animalTypes/DEADPET.png'
      }
    });
  }

  startHttpRequest() {
    var result = this.apiserviceAnimal.ConnectAnimal(localStorage.getItem("userid")).subscribe((data) => {
      console.log("SignalR werk good boi:                                                   " + data);
    });
  }



  public Sleep() {
    this.router.navigate(['SleepPage']);
  }

  public Play() {
    this.router.navigate(['GamesPage']);
  }

  public Shop() {
    this.router.navigate(['ShopPage']);
  }

  public Inventory() {
    this.router.navigate(['InventoryPage']);
  }
}
