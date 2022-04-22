import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { LogoutComponent } from './components/logout/logout.component';
import { ReportsComponent } from './components/reports/reports.component';
import { ChekuserService } from './services/chekuser.service';

const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},  
  {path:'home',component:HomeComponent},
  {path:'about',component:AboutComponent},
  {path:'reports',component:ReportsComponent,canActivate:[ChekuserService]},
  {path:'login',component:LoginComponent},
  {path:'logout',component:LogoutComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
