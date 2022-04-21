import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateChild, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthChildService implements CanActivateChild {

  constructor() { }
  canActivateChild(): boolean  {
    if(100 < 200)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
