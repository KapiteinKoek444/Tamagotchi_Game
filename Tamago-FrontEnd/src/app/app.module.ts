import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ApiServiceService, ApiServiceUser, ApiServiceAnimal, ApiServiceBank, ApiServiceInventory, ApiServiceShop } from './Services/api_service/api-service.service';
import { Hasher } from './Services/Hasher';
import { GuidFactory } from './Services/GuidFactory';
import { GamesPageComponent } from './Components/Account/games-page/games-page.component';
import { ShopPageComponent } from './Components/Account/shop-page/shop-page.component';
import { InventoryPageComponent } from './Components/Account/inventory-page/inventory-page.component';
import { SleepPageComponent } from './Components/Account/sleep-page/sleep-page.component';
import { ConfirmationDialogComponent } from './Components/Add-Ons/confirmation-dialog/confirmation-dialog.component';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationDialogService } from './Components/Add-Ons/Services/confirmation-dialog.service';

@NgModule({
  declarations: [
    AppComponent,
    routingComponents,
    GamesPageComponent,
    ShopPageComponent,
    InventoryPageComponent,
    SleepPageComponent,
    ConfirmationDialogComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    NgbModalModule,
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
    GuidFactory,
    ConfirmationDialogService 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
