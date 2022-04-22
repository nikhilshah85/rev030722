import { Component } from '@angular/core';
import { ChekuserService } from './services/chekuser.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'projectlogindemo';

  _user:ChekuserService;
  constructor(_userRef:ChekuserService)
  {
    this._user = _userRef;
  }
}
