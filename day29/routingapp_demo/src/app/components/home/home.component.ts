import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {


  http:HttpClient;
constructor(_http:HttpClient)
{
this.http = _http;
}
 
    ngOnInit() {
      
   }

   
  
  

}
