import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService implements CanActivate {

  constructor() { }


  canActivate(): boolean 
  {

    //can make a rest api call to login, and pass the username and passwrd, whih will return result
    if(10 < 5)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

}
