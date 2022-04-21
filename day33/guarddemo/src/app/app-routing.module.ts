import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { AnnounceeventComponent } from './components/announceevent/announceevent.component';
import { ContactComponent } from './components/contact/contact.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { ClientreportComponent } from './components/reports/clientreport/clientreport.component';
import { EmployeereportComponent } from './components/reports/employeereport/employeereport.component';
import { FinancereportComponent } from './components/reports/financereport/financereport.component';
import { ReportsComponent } from './components/reports/reports.component';
import { AuthChildService } from './services/auth-child.service';
import { AuthService } from './services/auth.service';

const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'home',component:HomeComponent},
  {path:'about',component:AboutComponent, canActivate:[AuthService]},
  {path:'contact',component:ContactComponent},
  {
    path:'reports',
    component:ReportsComponent,
    children:[
      {path:'finance',component:FinancereportComponent},
      {path:'client',component:ClientreportComponent},
      {path:'employee',component:EmployeereportComponent}      
    ],
    canActivateChild:[AuthChildService],
    canActivate:[AuthService]},








  {path:'announcements',component:AnnounceeventComponent,canActivate:[AuthService]},
  {path:'login',component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
