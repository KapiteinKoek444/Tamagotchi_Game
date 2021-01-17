import { Component, OnInit } from '@angular/core';
import { ApiServiceAnimal } from '../../../Services/api_service/api-service.service';
import { AnimalModel } from '../../../Models/AnimalModel';
import { Router } from '@angular/router';
import { AnimalImages } from 'src/app/Services/constants';
import { SignalRService } from 'src/app/Services/api_service/signal-r.service';
import { SubscriptionLike } from 'rxjs';
import { Location } from '@angular/common';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['../../../../assets/css/Account.css']
})

export class DashboardComponent implements OnInit {
  images: String[];
  animal: AnimalModel;
  public subscription: SubscriptionLike;


  constructor(
    private apiserviceAnimal: ApiServiceAnimal,
    public signalRService: SignalRService,
    private location: Location,
    private router: Router,
  ) {
    this.images = AnimalImages;
    this.handleBackButtonPress();
  }

  ngOnInit(): void 
  {
    this.animal = new AnimalModel(0, 0, "null", 0, 0, 0, 1,0, 0,false);

    this.apiserviceAnimal.GetAnimal(localStorage.getItem("userid")).subscribe((data) => {
      this.animal = new AnimalModel(0, 0, "0", 0, 0, 0, 0,0, 0,false).fromJSON(data)
      var image = document.getElementById('tamagotchi') as HTMLImageElement;
      this.SelectedImage(image);
            console.log(this.animal);
    });
    
    console.log(this.animal);
   setTimeout(() => {
    if (this.animal.energy <= 0 || this.animal.food <= 0 || this.animal.happiness <= 0) return;

    this.signalRService.startConnection();
    this.signalRService.GetAnimalDataListener();
    this.startHttpRequest();

    const websocketAlerts = this.signalRService
    .retrieveMappedObject()
    .subscribe((receivedObj: AnimalModel) => {
      this.animal = receivedObj;
    });
    }, 5000);
  }

  startHttpRequest() {
    var result = this.apiserviceAnimal.ConnectAnimal(localStorage.getItem("userid")).subscribe((data) => {
      console.log("SignalR werk good boi:                                                   " + data);
    });
  }
  
  
  SelectedImage(image){
    if (this.animal.energy <= 0 || this.animal.food <= 0 || this.animal.happiness <= 0) {
      var PetName = this.animal.name;
      this.animal.name = "RIP " + PetName + " you were a good pet..";
      image.src = '../../../../assets/animalTypes/DEADPET.png'
      this.signalRService.disconnect();

    } else {
      image.src = '../../../../assets/animalTypes/' + this.images[this.animal.animalType] + ".png";
    }
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

  handleBackButtonPress() {
    this.subscription = this.location.subscribe(redirect => {
      if (redirect.pop === true) {
        this.signalRService.disconnect();
      }
    });
  }
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
