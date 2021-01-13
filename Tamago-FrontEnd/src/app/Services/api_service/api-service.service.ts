import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { AnimalModel } from 'src/app/Models/AnimalModel';
import { UserModel } from 'src/app/Models/UserModel';
import { BuyBleModel } from 'src/app/Models/BuyBleModel';


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
    return this.http.post('https://tamagotchigateway.azurewebsites.net/api/user', user, httpOptions);
  }

  public GetUserPassword(loginModel) {
    this.http.post<string>('https://tamagotchigateway.azurewebsites.net/api/user/login', { email: loginModel.email, password: loginModel.password }, httpOptions).subscribe(data => {
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

  public GetAnimal() {
    return this.http.get('https://tamagotchigateway.azurewebsites.net/api/animal/' + localStorage.getItem("userid"), httpOptions);
  }

  public ConnectAnimal(userId: String) {
    //var result = this.http.get('https://tamagotchigateway.azurewebsites.net/api/animal/ConnectAnimal/' + userId, httpOptions);
    var result = this.http.get('https://localhost:44337/animal/ConnectAnimal/' + userId, httpOptions);
    console.log(result);
    return result;
  }

  public SendAnimal(animal) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/animal', animal, httpOptions).subscribe();
    return animal;
  }

  public UpdateAnimal(animal: AnimalModel) {
    var newAnimal = this.http.post('https://tamagotchigateway.azurewebsites.net/api/animal/' + localStorage.getItem("userid"), animal, httpOptions).subscribe();
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

  public SendWallet(userId: String) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/bank/wallet/add/' + userId, httpOptions).subscribe();
  }

  public Update(wallet, userId: String) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/bank/wallet/update/' + userId, wallet, httpOptions);
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
    return this.http.get('https://tamagotchigateway.azurewebsites.net/api/inventory/' + userId, httpOptions);
  }

  public SendInventory(userId: String) {
    this.http.post('https://tamagotchigateway.azurewebsites.net/api/inventory/add/' + userId, httpOptions).subscribe();
  }

  public UpdateInventory(inventory) {
    return this.http.post('https://tamagotchigateway.azurewebsites.net/api/inventory/update', inventory, httpOptions).subscribe();
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
  public BuyFood(model: BuyBleModel) {
    return this.http.post('https://tamagotchigateway.azurewebsites.net/api/store/food/buy', model, httpOptions);
  }
}

@Injectable({
  providedIn: 'root'
})

export class APIClock {
  constructor(private http: HttpClient) {
  }
}

