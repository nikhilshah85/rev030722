import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ChekuserService } from 'src/app/services/chekuser.service';
import { AboutComponent } from '../about/about.component';
import { HomeComponent } from '../home/home.component';
import { ReportsComponent } from '../reports/reports.component';





@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  _user:ChekuserService;
  _router:Router;

 
  constructor(_userRef:ChekuserService,private routerRef:Router)
   {
     this._user = _userRef;
     this._router = routerRef;
    }

    Login(email:string,pwd:string)
    {
      this._user.getUser(email,pwd).subscribe( (data)=>{
        if(data == null)
        {
          console.log('User Not Found, Login Faile');
        }
        else
        {
          // console.log(data);
          this._user.userDetails = data;
          console.log('Login Successful');       
          this._user.isUserLoggedin = true;
          this._router.navigateByUrl("/home");
        
          
        

        }
      },(err)=>{
          console.log('Login Failed');
      });
    }

  ngOnInit(): void {
  }

}
