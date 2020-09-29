import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from '../app/User_Manager/register/register.component';
import { LoginComponent } from '../app/User_Manager/login/login.component';
import { AppComponent } from './app.component';
import { UserComponent } from './Entities/user/user.component';
import { AnimalComponent } from './Entities/Animal/animal.component';
import { DinoRunComponent } from './dino-run/dino-run.component';
import { InventoryComponent } from './Entities/inventory/inventory.component';

const routes: Routes = [
  { path: 'index', component: AppComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: 'user', component: UserComponent },
  { path: 'animal', component: AnimalComponent },
  { path: 'dinoRun', component: DinoRunComponent },
  { path: 'inventory', component: InventoryComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [RegisterComponent, LoginComponent, AppComponent, UserComponent, AnimalComponent, DinoRunComponent];
