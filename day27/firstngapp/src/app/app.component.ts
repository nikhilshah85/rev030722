import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'firstngapp'; 
  devloper = "Nikhil";
  teamSize = 22;
  appName = "Angular Training APP";

  developerOne = "Nikhil";
  developerTwo = "Nikhil";

  greetUser(){
    return  "Welcome to the APP development using Angular";
  }

}
