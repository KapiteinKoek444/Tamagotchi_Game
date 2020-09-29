import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { JsonPipe } from '@angular/common';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class ApiService {
  constructor(private httpClient: HttpClient) { }

  //Users
  public getUsers() {
    return this.httpClient.get(`https://tamagotchiuserapi.azurewebsites.net/user`);
  }

  public sendUsers(user) {
    this.httpClient.post('https://tamagotchiuserapi.azurewebsites.net/user', user, httpOptions).subscribe();
    return user;
  }

  public getUserId(userID) {
    var user = this.httpClient.get(`https://tamagotchiuserapi.azurewebsites.net/user/` + userID);
    return user;
  }

  public getUserPassword(loginmodel) {

    this.httpClient.post<any>(`https://tamagotchiuserapi.azurewebsites.net/user/login`, { email: loginmodel.email, password: loginmodel.password }).subscribe(data => {
      localStorage.setItem("userId", data);
    });
  }

  //Animals
  public getAnimals() {
    return this.httpClient.get(`https://tamagotchianimalapi.azurewebsites.net/animal`);
  }

  public sendAnimals(animal) {
    this.httpClient.post('https://tamagotchianimalapi.azurewebsites.net/animal', animal, httpOptions).subscribe();
    return animal;
  }

  public getAnimalId(animalID) {
    var animal = this.httpClient.get('https://tamagotchianimalapi.azurewebsites.net/animal/' + animalID).subscribe();
    return animal;
  }

  public getAnimalUserId(userID) {
    var animal = this.httpClient.get('https://tamagotchianimalapi.azurewebsites.net/animal/' + userID).subscribe();
    console.log(animal);
    return animal;
  }

  public updateAnimal(newAnimal) {
    var curAnimal = this.httpClient.put('https://tamagotchianimalapi.azurewebsites.net/animal/', newAnimal).subscribe();
    return curAnimal;
  }
}
