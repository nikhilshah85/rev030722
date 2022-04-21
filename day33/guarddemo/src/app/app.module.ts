import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { ReportsComponent } from './components/reports/reports.component';
import { AnnounceeventComponent } from './components/announceevent/announceevent.component';
import { LoginComponent } from './components/login/login.component';
import { ContactComponent } from './components/contact/contact.component';
import { AuthService } from './services/auth.service';
import { FinancereportComponent } from './components/reports/financereport/financereport.component';
import { EmployeereportComponent } from './components/reports/employeereport/employeereport.component';
import { ClientreportComponent } from './components/reports/clientreport/clientreport.component';
import { AuthChildService } from './services/auth-child.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    ReportsComponent,
    AnnounceeventComponent,
    LoginComponent,
    ContactComponent,
    FinancereportComponent,
    EmployeereportComponent,
    ClientreportComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [AuthService,AuthChildService],
  bootstrap: [AppComponent]
})
export class AppModule { }
