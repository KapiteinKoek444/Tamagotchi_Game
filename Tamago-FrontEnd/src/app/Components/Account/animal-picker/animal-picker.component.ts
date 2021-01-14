import { Component, OnInit } from '@angular/core';

//Models
import { AnimalModel } from '../../../Models/AnimalModel';

//Services
import { GuidFactory } from '../../../Services/GuidFactory';
import { Router } from '@angular/router';
import { ApiServiceAnimal } from '../../../Services/api_service/api-service.service';

@Component({
  selector: 'app-animal-picker',
  templateUrl: './animal-picker.component.html',
  styleUrls: ['../../../../assets/css/Account.css']
})
export class AnimalPickerComponent implements OnInit {

  constructor(private guidfactory: GuidFactory, private apiservice: ApiServiceAnimal, private router: Router) { }

  ngOnInit(): void {
  }

  public SetAnimal(name: String, animalType: number) {
    if (name == "") {
      return;
    }
    else {
      var id = this.guidfactory.GenerateGuid();
      var animal = new AnimalModel(id, localStorage.getItem("userid"), name, 100, 100, 100, animalType, 0);
      this.apiservice.SendAnimal(animal);
      setTimeout(() => { this.router.navigate(['dashboard']); }, 100);
    }
  }
}
