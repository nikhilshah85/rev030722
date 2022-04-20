import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-comments',
  templateUrl: './comments.component.html',
  styleUrls: ['./comments.component.css']
})
export class CommentsComponent implements OnInit {

  _http:HttpClient;
  commentsDataFromJsonPlaceHolder:any = [];

  constructor(_httpRef:HttpClient)
  {
    this._http = _httpRef;
  }
  
  //this is when you want to make a call on a click of a button
  getCommentsData()
  {
      this._http.get('https://jsonplaceholder.typicode.com/comments').subscribe( (mydata)=>{
        this.commentsDataFromJsonPlaceHolder = mydata;
  });

      
  }


  
  //if you wish to display the data on the load of this component, make a call in this method
  ngOnInit(): void {

  }

}
