import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { UserComponent } from './Entities/user/user.component';
import { AnimalComponent } from './Entities/Animal/animal.component';

import { HasherComponent } from '../app/User_Manager/hasher/hasher.component';

const routes: Routes = [];

@NgModule({
  declarations: [
    AppComponent,
    HasherComponent,
    routingComponents
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    HttpClientModule,
    FormsModule,
  ],
  exports: [
    RouterModule
  ],
  providers: [UserComponent, AnimalComponent, HasherComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
