import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { AnimalModel } from 'src/app/Models/AnimalModel';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  })
}

@Injectable({
  providedIn: 'root'
})

//Universal
export class ApiServiceService {
  constructor() { }
}

@Injectable({
  providedIn: 'root'
})

//User
export class ApiServiceUser {
  constructor(private http: HttpClient) {
  }

  public GetUser(id: String) {
    return this.http.get("https://tamagotchigateway.azurewebsites.net/api/user/" + id, httpOptions);
  }

  public SendUser(user) {
    console.log(user);
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/user', user, httpOptions).subscribe();
    return user;
  }

  public GetUserPassword(loginModel) {
    this.http.post<string>(`https://tamagotchigateway.azurewebsites.net/api/user/login`, { email: loginModel.email, password: loginModel.password }, httpOptions).subscribe(data => {
    localStorage.removeItem("userid");  
    localStorage.setItem("userid", data);
    });
  }
} 

@Injectable({
  providedIn: 'root'
})

//Animal
export class ApiServiceAnimal {
  constructor(private http: HttpClient) {
  }

  public GetAnimal(userId: String) {
    return this.http.get(`https://tamagotchigateway.azurewebsites.net/api/animal/` + userId, httpOptions);
  }

  public SendAnimal(animal) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/animal', animal, httpOptions).subscribe();
    return animal;
  }

  public UpdateAnimal(animal, id: String) {
    var newAnimal = this.http.post('https://tamagotchigateway.azurewebsites.net/api/animal/' + id, animal, httpOptions).subscribe();
    return newAnimal;
  }
}

@Injectable({
  providedIn: 'root'
})

//Bank
export class ApiServiceBank {
  constructor(private http: HttpClient) {
  }

  public GetWallet(userId: String) {
    return this.http.get('https://tamagotchigateway.azurewebsites.net/api/bank/wallet/' + userId, httpOptions);
  }

  public SendWallet(wallet) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/bank/wallet/add', wallet, httpOptions).subscribe();
    return wallet;
  }

  public Update(wallet) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/bank/wallet/update', wallet, httpOptions);
  }

  public AddMoney(userId: String, money: number) {
    var newWallet = this.http.get('https://tamagotchigateway.azurewebsites.net/api/bank/wallet/' + userId + "/" + money, httpOptions).subscribe();
    return newWallet;
  }
}

@Injectable({
  providedIn: 'root'
})

//Inventory
export class ApiServiceInventory {
  constructor(private http: HttpClient) {
  }

  public GetInventory(userId: String) {
    return this.http.get('https://tamagotchigateway.azurewebsites.net/api/inventory/get/' + userId, httpOptions);
  }

  public SendInventory(inventory) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/inventory/add', inventory, httpOptions).subscribe();
    console.log(inventory);
    return inventory;
  }

  public UpdateInventory(inventory) {
    return this.http.post('https://tamagotchigateway.azurewebsites.net/api/inventory/add', inventory, httpOptions);
  }
}

@Injectable({
  providedIn: 'root'
})

//Shop
export class ApiServiceShop {
  constructor(private http: HttpClient) {
  }

  public GetAllFood() {
    return this.http.get('https://tamagotchigateway.azurewebsites.net/api/store/food', httpOptions);
  }

  public GetFood(id: String) {
    return this.http.get('https://tamagotchigateway.azurewebsites.net/api/store/food/' + id, httpOptions);
  }
}
