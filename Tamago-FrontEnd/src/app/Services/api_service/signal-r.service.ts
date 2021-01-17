import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';
import { Subject ,Observable} from 'rxjs';
import { AnimalModel } from 'src/app/Models/AnimalModel';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {

  public data: AnimalModel;
  private sharedObj = new Subject<AnimalModel>();

  private hubconnection: signalR.HubConnection;
  //private url = "https://tamagotchigateway.azurewebsites.net/api/socket/animalValues";
  private url = "https://localhost:44337/AnimalValues";

  constructor() { }

  public startConnection = () => {

    console.log(this.url);
    this.hubconnection = new signalR.HubConnectionBuilder()
      .withUrl(this.url , {
        skipNegotiation: true,
        transport: signalR.HttpTransportType.WebSockets
      })
      .configureLogging(signalR.LogLevel.Debug)
      .build();

      var thenable = this.hubconnection.start();
      thenable
      .then(() => console.log('Connection started'))
      .catch(error => console.error('Error While starting connection: ' + error))
  }

  public GetAnimalDataListener = () => {
    this.hubconnection.on('getAnimalData', (data) => {
      this.data = data;
      console.log(data);
      this.sharedObj.next(data);
    })
  };

  public disconnect() {
    if (this.hubconnection) {
      this.hubconnection.stop();
      this.hubconnection = null;
    }
  }
  public retrieveMappedObject(): Observable<AnimalModel> {
    return this.sharedObj.asObservable();
  }
}
