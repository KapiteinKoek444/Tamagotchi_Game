import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ApiServiceService, ApiServiceUser, ApiServiceAnimal, ApiServiceBank, ApiServiceInventory, ApiServiceShop } from './Services/api_service/api-service.service';
import { Hasher } from './Services/Hasher';
import { GuidFactory } from './Services/GuidFactory';

@NgModule({
  declarations: [
    AppComponent,
    routingComponents,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
  ],
  providers: [
    HttpClientModule,
    ApiServiceService,
    ApiServiceUser,
    ApiServiceAnimal,
    ApiServiceBank,
    ApiServiceInventory,
    ApiServiceShop,
    Hasher,
    GuidFactory],
  bootstrap: [AppComponent]
})
export class AppModule { }
