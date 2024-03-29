import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './components/about/about.component';
import { CommentsComponent } from './components/comments/comments.component';
@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    CommentsComponent    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule

    ],
  providers: [HttpClient],
  bootstrap: [AppComponent]
})
export class AppModule { }
