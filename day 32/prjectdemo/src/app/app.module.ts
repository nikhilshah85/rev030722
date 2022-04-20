import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeComponent } from './components/employee/employee.component';
import { EmployeeService } from './services/employee.service';
import { SearchempComponent } from './components/searchemp/searchemp.component';
import { DeletempComponent } from './components/deletemp/deletemp.component';


@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    SearchempComponent,
    DeletempComponent,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
