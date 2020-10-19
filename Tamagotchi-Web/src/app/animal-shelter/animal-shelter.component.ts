import { Component, OnInit } from '@angular/core';
import { Animal, AnimalComponent } from '../Entities/Animal/animal.component';
import { Router } from '@angular/router';


@Component({
  selector: 'app-animal-shelter',
  templateUrl: './animal-shelter.component.html',
  styleUrls: ['./animal-shelter.component.css']
})
export class AnimalShelterComponent implements OnInit {

  constructor(private animalComponent: AnimalComponent, private router: Router) { }

  ngOnInit(): void {
  }

  public async setAnimal(name, type) {
    if (name == "") {
      console.log("Fill in your name please!")
    }
    else {
      this.animalComponent.generateAnimal(this.newGuid(), localStorage.getItem('userId'), name, type);

      setTimeout(() => { this.router.navigate(['animal']); }, 100);
    }
  }

  private newGuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
      var r = Math.random() * 16 | 0,
        v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
  }
}
