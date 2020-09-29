import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../../Data_Manager/api.service';

@Component({
  selector: 'app-animal',
  templateUrl: './animal.component.html',
  styleUrls: ['./animal.component.css']
})
export class AnimalComponent implements OnInit {
  animal: Animal;

  constructor(private apiservice: ApiService) { }

  ngOnInit(): void {
    var data = this.apiservice.getAnimalUserId(localStorage.getItem("userId"))
    console.log(data);
  }

  generateAnimal(id, Uid) {
    var animal = new Animal(id, Uid, "testSubject", 100, 100, 100);
    this.apiservice.sendAnimals(animal);
  }

  getAnimal(user) {

  }

  getAllAnimals() {
    this.apiservice.getAnimals().subscribe((data) => {
      console.log(data);
    })
  }

  UpdateAnimal(Animal) {
    this.apiservice.updateAnimal(Animal);
  }
}

export class Animal {
  id: string;
  userId: string;
  name: string;
  food: number;
  energy: number;
  happiness: number;

  constructor(id, Uid, n, f, e, h) {
    this.id = id;
    this.userId = Uid;
    this.name = n;
    this.food = f;
    this.energy = e;
    this.happiness = h;
  }

  Feed() {
    this.food += 5;
    this.happiness++;
    this.energy += 2;
  }

  Play() {
    this.energy -= 3;
    this.happiness += 5;
    this.food -= 2;
  }

  Sleep() {
    this.energy += 10;
    this.food -= 8;
    this.happiness -= 20;
  }
}
