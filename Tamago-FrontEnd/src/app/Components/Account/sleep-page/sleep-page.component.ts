import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AnimalModel } from 'src/app/Models/AnimalModel';
import { ApiServiceAnimal } from 'src/app/Services/api_service/api-service.service';
import { AnimalImages } from 'src/app/Services/constants';

@Component({
  selector: 'app-sleep-page',
  templateUrl: './sleep-page.component.html',
  styleUrls: ['./sleep-page.component.css', '../../../../assets/css/Account.css']
})
export class SleepPageComponent implements OnInit {


  images: String[];
  animal: AnimalModel;

  constructor(private apiserviceAnimal: ApiServiceAnimal, private router: Router) {
    this.images = AnimalImages;
  }

  ngOnInit(): void {
    this.animal = new AnimalModel(0, 0, "null", 0, 0, 0, 1);

    this.apiserviceAnimal.GetAnimal().subscribe((data) => {
      this.animal = new AnimalModel(0, 0, "0", 0, 0, 0, 0).fromJSON(data)

      var imageAnimal = document.getElementById('animal') as HTMLImageElement;
      imageAnimal.src = '../../../../assets/animalTypes/' + this.images[this.animal.animalType] + ".png";

      var imageBed = document.getElementById('bed') as HTMLImageElement;
      imageBed.src = '../../../../assets/furnitureTypes/' + "Bed_1.png";
    });
  }

  back() {
    this.router.navigate(['dashboard']);
  }

}
