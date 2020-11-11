import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './Components/Account/login/login.component';
import { RegisterComponent } from './Components/Account/register/register.component';
import { AnimalPickerComponent } from './Components/Account/animal-picker/animal-picker.component';
import { DashboardComponent } from './Components/Account/dashboard/dashboard.component';
import { GamesPageComponent } from './Components/Account/games-page/games-page.component';
import { ShopPageComponent } from './Components/Account/shop-page/shop-page.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'animalpicker', component: AnimalPickerComponent },
  { path: 'GamesPage', component: GamesPageComponent },
  { path: 'ShopPage', component: ShopPageComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [LoginComponent, RegisterComponent, AnimalPickerComponent,GamesPageComponent];
