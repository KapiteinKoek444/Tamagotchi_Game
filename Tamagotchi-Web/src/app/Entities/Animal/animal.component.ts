import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../../Data_Manager/api.service';

@Component({
  selector: 'app-animal',
  templateUrl: './animal.component.html',
  styleUrls: ['./animal.component.css']
})
export class AnimalComponent implements OnInit {
  animal: Animal
  images: Array<string>;

  constructor(private apiservice: ApiService) {
    this.images = ["Kikker", "UIL", "BLOEM", "VOGEL", "OCTOPUS"];
  }

  ngOnInit(): void {
    this.apiservice.getAnimalUserId(localStorage.getItem("userId")).subscribe((data) => {
      this.animal = new Animal(0, 0, "0", 0, 0, 0, 0).fromJSON(data);

      var type = this.animal.animalType;
      var image = document.getElementById('tamagotchi') as HTMLImageElement;
      image.src = "../../../assets/Images/" + this.images[type] + ".png";
    });
  }

  generateAnimal(id, Uid, name, type) {
    var animal = new Animal(id, Uid, name, 100, 100, 100, type);
    this.apiservice.sendAnimals(animal);
  }

  getAllAnimals() {
    this.apiservice.getAnimals().subscribe((data) => {
      console.log(data);
    })
  }

  Feed() {
    this.animal.food += 5;
    this.animal.happiness++;
    this.animal.energy += 2;
    this.UpdateAnimal(this.animal, this.animal.userId);
  }

  Play() {
    this.animal.energy -= 3;
    this.animal.happiness += 5;
    this.animal.food -= 2;
    this.UpdateAnimal(this.animal, this.animal.userId);
  }

  Sleep() {
    this.animal.energy += 10;
    this.animal.food -= 8;
    this.animal.happiness -= 20;
    this.UpdateAnimal(this.animal, this.animal.userId);
  }


  UpdateAnimal(Animal, id) {
    this.apiservice.updateAnimal(Animal, id);
  }
}

export class Animal {
  id: string;
  userId: string;
  name: string;
  food: number;
  energy: number;
  happiness: number;
  animalType: number;

  constructor(id, Uid, n, f, e, h, type) {
    this.id = id;
    this.userId = Uid;
    this.name = n;
    this.food = f;
    this.energy = e;
    this.happiness = h;
    this.animalType = type;
  }

  fromJSON(json) {
    for (var propName in json)
      this[propName] = json[propName];
    return this;
  }
}
