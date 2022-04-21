import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {

  constructor() {

    console.log('Hell I am a constructor, I am going to do something heavy ')
   }

  ngOnInit(): void {
    console.log('Hello I am going to make REST API call and get 100s of records and photos and start the video stream');
  }

}
