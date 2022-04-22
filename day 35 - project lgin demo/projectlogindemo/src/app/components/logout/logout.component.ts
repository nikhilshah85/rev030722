import { Component, OnInit } from '@angular/core';
import { ChekuserService } from 'src/app/services/chekuser.service';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrls: ['./logout.component.css']
})
export class LogoutComponent implements OnInit {

  _user:ChekuserService;
  constructor(_userRef:ChekuserService) {
  
    this._user = _userRef;
    this._user.isUserLoggedin = false;
    this._user.userDetails ="blank";
   }
  
  
  ngOnInit(): void {
  }

}
