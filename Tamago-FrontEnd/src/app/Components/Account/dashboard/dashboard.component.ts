import { Component, OnInit } from '@angular/core';
import { ApiServiceAnimal } from '../../../Services/api_service/api-service.service';
import { AnimalModel } from '../../../Models/AnimalModel';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['../../../../assets/css/Account.css']
})

export class DashboardComponent implements OnInit {
  images: String[];
  animal: AnimalModel;

  constructor(private apiserviceAnimal: ApiServiceAnimal) {
    this.images = ["Kikker", "UIL", "BLOEM", "VOGEL", "OCTOPUS"];
  }

  ngOnInit(): void {
    this.animal = new AnimalModel(0, 0, "null", 0, 0, 0, 1);

    this.apiserviceAnimal.GetAnimal(localStorage.getItem("userid")).subscribe((data) => {
      this.animal = new AnimalModel(0, 0, "0", 0, 0, 0, 0).fromJSON(data)

      var image = document.getElementById('tamagotchi') as HTMLImageElement;
      image.src = '../../../../assets/animalTypes/' + this.images[this.animal.animalType] + ".png";
    });
  }

  public Feed() {

  }

  public Sleep() {

  }

  public Play() {

  }
}
