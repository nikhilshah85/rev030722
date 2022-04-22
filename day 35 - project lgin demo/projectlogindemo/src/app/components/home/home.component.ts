import { Component, OnInit } from '@angular/core';
import { ChekuserService } from 'src/app/services/chekuser.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  _userService:ChekuserService;
  
  constructor(_userSerRef:ChekuserService)
   {
     this._userService = _userSerRef;
    }

    getData()
    {
       this._userService.userDetails;
    }


  ngOnInit(): void {
  }

}
