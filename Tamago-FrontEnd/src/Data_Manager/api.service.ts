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
    return this.httpClient.get(`https://tamagotchigateway.azurewebsites.net/api/user`);
  }

  public sendUsers(user) {
    this.httpClient.post('https://tamagotchigateway.azurewebsites.net/api/user', user, httpOptions).subscribe();
    return user;
  }

  public getUserId(userID) {
    var user = this.httpClient.get(`https://tamagotchigateway.azurewebsites.net/api/user` + userID).subscribe();
    return user;
  }

  public getUserPassword(loginmodel) {
    this.httpClient.post<string>(`https://tamagotchigateway.azurewebsites.net/api/user/login`, { email: loginmodel.email, password: loginmodel.password }).subscribe(data => {
      localStorage.setItem("userId", data);
    });
  }

  //Animals
  public getAnimals() {
    return this.httpClient.get(`https://tamagotchigateway.azurewebsites.net/api/animal`);
  }

  public sendAnimals(animal) {
    this.httpClient.post('https://tamagotchigateway.azurewebsites.net/api/animal', animal, httpOptions).subscribe();
    return animal;
  }

  public getAnimalId(animalID) {
    var animal = this.httpClient.get('https://tamagotchigateway.azurewebsites.net/api/animal/' + animalID).subscribe();
    return animal;
  }

  public getAnimalUserId(userID) {
    var animal = this.httpClient.get('https://tamagotchigateway.azurewebsites.net/api/animal/' + userID);
    return animal;
  }

  public updateAnimal(newAnimal, id) {
    this.httpClient.post('https://tamagotchigateway.azurewebsites.net/api/animal/' + id, newAnimal, httpOptions).subscribe();
  }
}
