import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { Employee } from './employee/employee.component';
import { Products } from './products/products.component';

@NgModule({
  declarations: [
    AppComponent,Employee,Products
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
